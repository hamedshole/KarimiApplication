using System;
using System.Globalization;
using KarimiApp.Model;
using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;

namespace KarimiApp.Client.View.Edit
{
    public partial class PaymentTypeEdit : DevExpress.XtraEditors.XtraForm
    {
        private CultureInfo cultureInfo;
        private UnitOfWork repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTypeEdit"/> class.
        /// </summary>
        public PaymentTypeEdit()
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.repository = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "نوع پرداخت جدید";
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_Click;
            this.ButtonCancel.Click += this.ButtonCancel_Click;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTypeEdit"/> class.
        /// </summary>
        /// <param name="paymentType">Type of the payment.</param>
        public PaymentTypeEdit(PaymentTypeModel paymentType)
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.repository = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "ویرایش روش پرداخت";
            if (paymentType != null)
            {
                this.SetValues(paymentType);
            }

            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitUpdate_Click;
        }

        private void ButtonSubmitUpdate_Click(object sender, EventArgs e)
        {
            PaymentTypeModel tmp = this.GetValuesUodate();
            this.repository.PaymentType.Update(tmp);
            this.Close();
        }

        private PaymentTypeModel GetValuesCreate()
        {
            if (this.TextBoxTitle.EditValue == null)
            {
                throw new ValidateException(new string[] { "عنوان" });
            }
            return new PaymentTypeModel(this.TextBoxTitle.Text, this.CheckBoxActive.Checked);
        }

        private PaymentTypeModel GetValuesUodate()
        {
            return new PaymentTypeModel(Convert.ToInt32(this.TextBoxId.Text, this.cultureInfo), this.TextBoxTitle.Text, this.CheckBoxActive.Checked);
        }

        private void SetValues(PaymentTypeModel paymentType)
        {
            this.TextBoxTitle.Text = paymentType.Title;
            this.TextBoxId.Text = paymentType.Id.ToString(this.cultureInfo);
            this.CheckBoxActive.Checked = paymentType.Active;
        }

        private void ButtonSubmitCreate_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentTypeModel tmp = this.GetValuesCreate();
                this.repository.PaymentType.Create(tmp);
                this.Close();
            }
            catch (ValidateException ve)
            {
                System.Windows.Forms.MessageBox.Show(ve.Message);
            }
          
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
