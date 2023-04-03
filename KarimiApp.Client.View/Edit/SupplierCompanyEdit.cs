using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;
using KarimiApp.Model;
using System;

namespace KarimiApp.Client.View.Edit
{
    public partial class SupplierCompanyEdit : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork UnitOfWork;
        public SupplierCompanyEdit()
        {
            this.UnitOfWork = new UnitOfWork();
            InitializeComponent();
            this.ButtonSubmit.Click += ButtonSubmit_ClickCreate;
        }

        private void ButtonSubmit_ClickCreate(object sender, EventArgs e)
        {
            try
            {
                this.UnitOfWork.SupplierCompany.Create(this.GetCreateValues());
                this.Close();
            }
            catch (ValidateException ve)
            {
                System.Windows.Forms.MessageBox.Show(ve.Message);
            }
            
        }

        public SupplierCompanyEdit(SupplierCompanyModel supplierCompany)
        {
            this.UnitOfWork = new UnitOfWork();
            InitializeComponent();
            this.SetValues(supplierCompany);
            this.ButtonSubmit.Click += ButtonSubmit_ClickUpdate;
        }

        private void SetValues(SupplierCompanyModel supplierCompany)
        {
            this.TextBoxId.Text = supplierCompany.Id.ToString();
            this.TextBoxTitle.Text = supplierCompany.Name;
            this.CheckBoxActive.Checked = supplierCompany.Active;
        }

        private void ButtonSubmit_ClickUpdate(object sender, EventArgs e)
        {
            this.UnitOfWork.SupplierCompany.Update(this.GetUpdateValues());
            this.Close();
        }

        private SupplierCompanyModel GetUpdateValues()
        {
            return new SupplierCompanyModel(id:Convert.ToInt32(this.TextBoxId.Text),name: this.TextBoxTitle.Text, active: this.CheckBoxActive.Checked);
        }

        private SupplierCompanyModel GetCreateValues()
        {
            if (this.TextBoxTitle.EditValue == null)
            {
                throw new ValidateException(new string[] { "عنوان" });
            }
            return new SupplierCompanyModel(name: this.TextBoxTitle.Text, active: this.CheckBoxActive.Checked);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}