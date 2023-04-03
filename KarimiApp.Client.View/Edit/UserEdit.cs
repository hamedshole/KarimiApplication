using KarimiApp.Client.Repository;
using KarimiApp.Model;
using System;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Edit
{
    public partial class UserEdit : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        private System.Globalization.CultureInfo cultureInfo;

        /// <summary>
        /// use when we want use clear and new in update page.
        /// </summary>
        private bool update = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="x"/> class to Create new Customer.
        /// </summary>
        public UserEdit()
        {
            unitOfWork = new UnitOfWork();
            this.cultureInfo = new System.Globalization.CultureInfo("fa-IR");
            this.Text = "مشتری جدید";
            this.InitializeComponent();
            this.unitOfWork.UserRole.List(this.ComboBoxUserRole);
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_Click;
            this.ButtonSubmitClear.Click += this.ButtonSubmitClear_Click;
            this.ButtonCancel.Click += this.ButtonCancel_Click;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="x"/> class to update a customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public UserEdit(UserModel user)
        {
            this.cultureInfo = new System.Globalization.CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.unitOfWork.UserRole.List(this.ComboBoxUserRole);
            this.Text = "ویرایش مشتری";
            if (user != null)
            {
                this.SetValues(user);
            }

            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitUpdate_CLick;
            this.ButtonSubmitClear.Click += this.ButtonSubmitClearUpdate_Click;
        }

        private void ButtonSubmitClearUpdate_Click(object sender, EventArgs e)
        {
            if (this.update)
            {
                PersonModel tmp = this.GetValuesUpdate();
                this.unitOfWork.Person.Update(tmp);
                this.ClearFields();
                this.update = false;
            }
            else
            {
                PersonModel tmp = this.GetValuesCreate();
                this.unitOfWork.Person.Create(tmp);
                this.ClearFields();
            }
        }

        private void ButtonSubmitUpdate_CLick(object sender, EventArgs e)
        {
            PersonModel tmp = this.GetValuesUpdate();
            this.unitOfWork.Person.Update(tmp);
            this.Close();
        }

        /// <summary>
        /// Set default values in forms.
        /// </summary>
        private void ClearFields()
        {
            this.TextBoxFirstName.Text = string.Empty;
            this.TextBoxPhoneNumber.Text = string.Empty;
        }

        /// <summary>
        /// Get values from field and fill a customer model .
        /// </summary>
        /// <returns>CustomerModel.</returns>
        private UserModel GetValuesCreate()
        {
     
            return new UserModel(personGroup: "کارکن", name: this.TextBoxFirstName.Text, mobileNumber: this.TextBoxPhoneNumber.Text, address: TextBoxAddress.Text, userName: this.TextBoxUsername.Text, password: this.TextBoxPassword.Text, role: this.ComboBoxUserRole.Text);
        }

        private UserModel GetValuesUpdate()
        {
            return new UserModel(personGroup:"کارکن",id: Convert.ToInt32(TextBoxId.Text), name: TextBoxFirstName.Text, mobileNumber: TextBoxPhoneNumber.Text,  role: ComboBoxUserRole.Text, userName: TextBoxUsername.Text, password: TextBoxPassword.Text, address: TextBoxAddress.Text);
        }

        /// <summary>
        /// fill fields to edit customer .
        /// </summary>
        /// <param name="user">The customer.</param>
        private void SetValues(UserModel user)
        {
            if (user != null)
            {
               
                this.TextBoxId.Text = user.Id.ToString();
                this.TextBoxFirstName.Text = user.Name;
                this.TextBoxPhoneNumber.Text = user.MobileNumber;
                this.TextBoxAddress.Text = user.Address;
                this.TextBoxUsername.Text = user.UserName;
                this.TextBoxPassword.Text = user.Password;
                this.ComboBoxUserRole.Text = user.Role;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// handle click event when open form to create new customer .
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonSubmitClear_Click(object sender, EventArgs e)
        {
            UserModel tmp = this.GetValuesCreate();
            this.unitOfWork.User.Create(tmp);
            this.ClearFields();
        }

        /// <summary>
        /// handle click event when open form to create new customer .
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonSubmitCreate_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel tmp = this.GetValuesCreate();
                this.unitOfWork.User.Create(tmp);
                this.Close();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message + ee.Source + ee.StackTrace);
            }


        }

        private void ButtonUserRole_Click(object sender, EventArgs e)
        {
            UserRoleEdit userRoleEdit = new UserRoleEdit();
            userRoleEdit.Show();
        }

        private void ButtonUserRoleRefresh_Click(object sender, EventArgs e)
        {
            this.unitOfWork.UserRole.List(this.ComboBoxUserRole);
        }

    }
}