using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;
using KarimiApp.Model;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Edit
{
    public partial class InventoryTypeEdit : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;

        private CultureInfo cultureInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryTypeEdit"/> class.
        /// </summary>
        public InventoryTypeEdit()
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "دسته انبار جدید";
            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_Click;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryTypeEdit"/> class.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        public InventoryTypeEdit(InventoryGroupModel inventoryType)
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "ویرایش دسته انبار";
            if (inventoryType != null)
            {
                this.SetValues(inventoryType);
            }

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
                InventoryGroupModel tmp = this.GetValuesCreate();
                this.unitOfWork.InventoryGroup.Create(tmp);
                this.Close();
            }
            catch (ValidateException ve)
            {
                MessageBox.Show(new Form { TopLevel = true }, ve.Message);
                throw;
            }

        }

        /// <summary>
        /// Sets the values.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        private void SetValues(InventoryGroupModel inventoryType)
        {
            this.TextBoxId.Text = inventoryType.Id.ToString(this.cultureInfo);
            this.TextBoxTitle.Text = inventoryType.Title;
            this.TextBoxDescription.Text = inventoryType.Description;
            this.CheckBoxActive.Checked = inventoryType.Active;
        }

        private void ButtonSubmitUpdate_Click(object sender, EventArgs e)
        {
            InventoryGroupModel tmp = this.GetValuesUpdate();
            this.unitOfWork.InventoryGroup.Update(tmp);
            this.Close();
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <returns>InventoryTypeModel.</returns>
        private InventoryGroupModel GetValuesUpdate()
        {
            return new InventoryGroupModel(Convert.ToInt32(this.TextBoxId.Text, this.cultureInfo), this.TextBoxTitle.Text, this.TextBoxDescription.Text, this.CheckBoxActive.Checked);
        }

        private InventoryGroupModel GetValuesCreate()
        {
            if (this.TextBoxTitle.EditValue == null)
            {
                throw new ValidateException(new string[] { "عنوان" });
            }

            return new InventoryGroupModel(this.TextBoxTitle.Text, this.TextBoxDescription.Text, this.CheckBoxActive.Checked);
        }
    }
}