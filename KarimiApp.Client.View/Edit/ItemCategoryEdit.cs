using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;
using KarimiApp.Model;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Edit
{
    public partial class ItemCategoryEdit : DevExpress.XtraEditors.XtraForm
    {
        private CultureInfo cultureInfo;
        private UnitOfWork unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemCategoryEdit"/> class.
        /// </summary>
        public ItemCategoryEdit()
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "دسته کالای جدید";
            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_Click;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemCategoryEdit"/> class.
        /// </summary>
        /// <param name="category">The category.</param>
        public ItemCategoryEdit(ItemCategoryModel category)
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "ویرایش دسته کالا";
            if (category != null)
            {
                this.SetValues(category);
            }

            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitUpdate_Click;
        }

        private void ButtonSubmitUpdate_Click(object sender, EventArgs e)
        {
            this.unitOfWork.ItemCategory.Update(this.GetValuesUpdate());
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetValues(ItemCategoryModel category)
        {
            this.TextBoxId.Text = category.Id.ToString(this.cultureInfo);
            this.TextBoxTitle.Text = category.Title;
            this.TextBoxDescription.Text = category.Description;
            this.CheckBoxActive.Checked = category.Active;
        }

        private ItemCategoryModel GetValuesUpdate()
        {
            return new ItemCategoryModel(Convert.ToInt32(this.TextBoxId.Text, this.cultureInfo), this.TextBoxTitle.Text, this.TextBoxDescription.Text, this.CheckBoxActive.Checked);
        }

        private ItemCategoryModel GetValuesCreate()
        {
            if (this.TextBoxTitle.EditValue == null)
            {
                throw new ValidateException(new string[] { "عنوان" });
            }
            return new ItemCategoryModel(this.TextBoxTitle.Text, this.TextBoxDescription.Text, this.CheckBoxActive.Checked);
        }

        private void ButtonSubmitCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.unitOfWork.ItemCategory.Create(this.GetValuesCreate());
                this.Close();
            }
            catch (ValidateException ve)
            {
                MessageBox.Show(new Form { TopLevel = true }, ve.Message);
            }
            
        }
    }
}