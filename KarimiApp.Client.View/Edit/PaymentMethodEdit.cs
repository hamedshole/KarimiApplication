using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace KarimiApp.Client.View.Edit
{
    public partial class PaymentMethodEdit : DevExpress.XtraEditors.XtraForm
    {

        private UnitOfWork repository;
        private CultureInfo cultureInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryTypeEdit"/> class.
        /// </summary>
        public PaymentMethodEdit()
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.repository = new UnitOfWork();
            this.InitializeComponent();
            repository.PaymentType.List(ComboBoxPaymentType);
            repository.PosInfo.List(this.ComboBoxPos);
            this.Text = "روش پرداخت جدید";
            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_Click;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryTypeEdit"/> class.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        public PaymentMethodEdit(PaymentMethodModel paymentMethod)
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.repository = new UnitOfWork();
            this.InitializeComponent();
            this.repository.PaymentType.List(ComboBoxPaymentType);
            this.Text = "ویرایش روش پرداخت";
            if (paymentMethod != null)
            {
                this.SetValues(paymentMethod);
            }
            repository.PaymentType.List(ComboBoxPaymentType);
            repository.PosInfo.List(this.ComboBoxPos);
            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitUpdate_Click;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmitCreate_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentMethodModel tmp = this.GetValuesCreate();
                this.repository.PaymentMethod.Create(tmp);
                this.Close();
            }
            catch (ValidateException ve)
            {

                System.Windows.Forms.MessageBox.Show(ve.Message);
            }
        }

        /// <summary>
        /// Sets the values.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        private void SetValues(PaymentMethodModel paymentMethod)
        {
            this.TextBoxId.Text = paymentMethod.Id.ToString(this.cultureInfo);
            this.ComboBoxPaymentType.Text = paymentMethod.PaymentType;
            this.ComboBoxPos.Text = paymentMethod.Pos;
            this.TextBoxTitle.Text = paymentMethod.Title;
            this.CheckBoxActive.Checked = paymentMethod.Active;
        }

        private void ButtonSubmitUpdate_Click(object sender, EventArgs e)
        {
            PaymentMethodModel tmp = this.GetValuesUpdate();
            this.repository.PaymentMethod.Update(tmp);
            this.Close();
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <returns>InventoryTypeModel.</returns>
        private PaymentMethodModel GetValuesUpdate()
        {
            return new PaymentMethodModel(id: Convert.ToInt32(this.TextBoxId.Text, this.cultureInfo), title: this.TextBoxTitle.Text, active: this.CheckBoxActive.Checked, paymentType: ComboBoxPaymentType.Text,pos:this.ComboBoxPos.Text);
        }

        private PaymentMethodModel GetValuesCreate()
        {
            List<string> inputparameters = new List<string>();
            if (this.TextBoxTitle.EditValue == null)
            {
                inputparameters.Add("عنوان");
            }
            if (this.ComboBoxPaymentType.EditValue == null)
            {
                inputparameters.Add("نوع پرداخت");
            }
            if (this.ComboBoxPos.EditValue == null)
            {
                inputparameters.Add("کارتخوان");
            }
            if (inputparameters.Count != 0)
            {
                throw new ValidateException(inputparameters.ToArray());
            }
            return new PaymentMethodModel(title: this.TextBoxTitle.Text, active: this.CheckBoxActive.Checked, paymentType: ComboBoxPaymentType.Text,pos:this.ComboBoxPos.Text);
        }

        private void ButtonPaymentMethodRefresh_Click(object sender, EventArgs e)
        {
            repository.PaymentMethod.List(ComboBoxPaymentType);
        }

        private void ButtonPaymentTypeNew_Click(object sender, EventArgs e)
        {
            PaymentTypeEdit paymentTypeEdit = new PaymentTypeEdit();
            paymentTypeEdit.Show();
        }

        private void ButtonPosNew_Click(object sender, EventArgs e)
        {
            PosInfoEdit posInfoEdit = new PosInfoEdit();
            posInfoEdit.Show();
        }

        private void ButtonPosRefresh_Click(object sender, EventArgs e)
        {
            this.repository.PosInfo.List(this.ComboBoxPos);
        }

        private void ComboBoxPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PosInfoModel posInfo = this.repository.PosInfo.Get(ComboBoxPos.Text);
            this.TextBoxPosTitle.Text = posInfo.Title;
            this.TextBoxPosCom.Text = posInfo.Com.ToString();
        }

       
    }
}