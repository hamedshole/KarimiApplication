using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Edit
{
    public partial class PersonEdit : DevExpress.XtraEditors.XtraForm
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
        public PersonEdit()
        {
            unitOfWork = new UnitOfWork();
            this.cultureInfo = new System.Globalization.CultureInfo("fa-IR");
            this.Text = "مشتری جدید";
            this.InitializeComponent();
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_Click;
            this.ButtonSubmitClear.Click += this.ButtonSubmitClear_Click;
            this.ButtonCancel.Click += this.ButtonCancel_Click;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="x"/> class to update a customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public PersonEdit(PersonModel person)
        {
            this.cultureInfo = new System.Globalization.CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "ویرایش مشتری";
            if (person != null)
            {
                this.SetValues(person);
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
        private PersonModel GetValuesCreate()
        {
            List<string> inputparams = new List<string>();
            if (this.TextBoxFirstName.EditValue == null)
            {
                inputparams.Add("نام");
            }
            if (inputparams.Count != 0)
            {
                throw new ValidateException(inputparams.ToArray());
            }
            return new PersonModel(personGroup: "مشتری", name: this.TextBoxFirstName.Text, mobileNumber: this.TextBoxPhoneNumber.Text, address: TextBoxAddress.Text);
        }

        private PersonModel GetValuesUpdate()
        {

            return new PersonModel(personGroup: "مشتری", id: Convert.ToInt32(this.TextBoxId.Text, this.cultureInfo), name: this.TextBoxFirstName.Text, mobileNumber: this.TextBoxPhoneNumber.Text, address: TextBoxAddress.Text);
        }

        /// <summary>
        /// fill fields to edit customer .
        /// </summary>
        /// <param name="customer">The customer.</param>
        private void SetValues(PersonModel customer)
        {
            if (customer != null)
            {
                this.TextBoxId.Text = customer.Id.ToString();
                this.TextBoxFirstName.Text = customer.Name;
                this.TextBoxPhoneNumber.Text = customer.MobileNumber;
                //  this.CheckBoxActive.Checked = customer.Active;
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
            PersonModel tmp = this.GetValuesCreate();
            this.unitOfWork.Person.Create(tmp);
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
                PersonModel tmp = this.GetValuesCreate();
                this.unitOfWork.Person.Create(tmp);
                this.Close();
            }
            catch (ValidateException ve)
            {
                MessageBox.Show(new Form { TopLevel = true }, ve.Message);
            }

        }


    }
}