using System;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using KarimiApp.Model;
using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;
using System.Collections.Generic;

namespace KarimiApp.Client.View.Edit
{
    public partial class RegisterEdit : DevExpress.XtraEditors.XtraForm
    {

        private CultureInfo cultureInfo;
        private UnitOfWork repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterEdit"/> class.
        /// </summary>
        public RegisterEdit()
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.repository = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "سیستم جدید";
            this.TextBoxComputerName.Text = System.Environment.MachineName;
            this.TextBoxMac.Text = this.GetMacAddresss();
            this.TextBoxIp.Text = GetLocalIPAddress();
            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_Click;
        }

        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {

                    // return ip.ToString();
                    return ip.MapToIPv4().ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        private string GetMacAddresss()
        {
            string addr = "";
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (n.OperationalStatus == OperationalStatus.Up)
                {
                    // addr +="\n"+ n.GetPhysicalAddress().ToString();
                    addr += n.GetPhysicalAddress();
                    break;
                }
            }
            return addr;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterEdit"/> class.
        /// </summary>
        /// <param name="register">The register.</param>
        public RegisterEdit(RegisterModel register)
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.repository = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "ویرایش سیستم";
            if (register != null)
            {
                this.SetValues(register);
            }

            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitUpdate_Click;
        }

        private void SetValues(RegisterModel register)
        {
            this.TextBoxId.Text = register.Id.ToString(this.cultureInfo);
            this.TextBoxTitle.Text = register.Title;
            this.TextBoxComputerName.Text = register.ComputerName;
            this.TextBoxDescription.Text = register.Description;
            this.TextBoxIp.Text = register.IpAddress;
            this.TextBoxMac.Text = register.MacAddress;
            this.CheckBoxActive.Checked = register.Active;
        }

        private void ButtonSubmitUpdate_Click(object sender, EventArgs e)
        {
            RegisterModel tmp = this.GetValuesUpdate();
            this.repository.Register.Update(tmp);
            this.Close();
        }

        private RegisterModel GetValuesCreate()
        {
            List<string> inputparameters = new List<string>();
            if (this.TextBoxTitle.EditValue == null)
            {
                inputparameters.Add("عنوان");
            }
            if (this.TextBoxComputerName.EditValue == null)
            {
                inputparameters.Add("نام سیستم");
            }
            if (this.TextBoxIp.EditValue == null)
            {
                inputparameters.Add("آی پی");
            }
            if (this.TextBoxMac.EditValue == null)
            {
                inputparameters.Add("مک");
            }
            if (inputparameters.Count != 0)
            {
                throw new ValidateException(inputparameters.ToArray());
            }
            return new RegisterModel(title: this.TextBoxTitle.Text,computerName: this.TextBoxComputerName.Text,description: this.TextBoxDescription.Text, ipAddress: this.TextBoxIp.Text,macAddress: this.TextBoxMac.Text,active: this.CheckBoxActive.Checked);
        }

        private RegisterModel GetValuesUpdate()
        {
            return new RegisterModel(id: Convert.ToInt32(this.TextBoxId.Text, this.cultureInfo),title: this.TextBoxTitle.Text,computerName: this.TextBoxComputerName.Text,description: this.TextBoxDescription.Text,ipAddress: this.TextBoxIp.Text,macAddress: this.TextBoxMac.Text,active: this.CheckBoxActive.Checked);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmitCreate_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterModel tmp = this.GetValuesCreate();
                this.repository.Register.Create(tmp);
                this.Close();
            }
            catch (ValidateException ve)
            {
                System.Windows.Forms.MessageBox.Show(ve.Message);
            }
            
        }

        private void LabelMac_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string x = @"C:\Windows\System32\osk.exe";
            Process.Start(x);
        }
    }
}