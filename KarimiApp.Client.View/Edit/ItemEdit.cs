using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Edit
{
    public partial class ItemEdit : DevExpress.XtraEditors.XtraForm
    {
        private CultureInfo cultureInfo;
        private UnitOfWork unitOfWork;
        private bool update = true;


        /// <summary>
        /// Initializes a new instance of the <see cref="ItemEdit"/> class.
        /// </summary>
        public ItemEdit()
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "کالای جدید";
            this.LoadFormData();
            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_Click;
            this.TextBOxBuyPrice.LostFocus += TextBOxBuyPrice_LostFocus;
        }

        private void TextBOxBuyPrice_LostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.TextBOxBuyPrice.Text))
            {
                long buyprice = Convert.ToInt64(this.TextBOxBuyPrice.Text);
                this.TextBoxSellPrice.Text = (buyprice + ((buyprice * 40) / 100)).ToString();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemEdit"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        public ItemEdit(ItemModel item)
        {
            this.cultureInfo = new CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.LoadFormData();
            this.Text = "ویرایش کالا";
            if (item != null)
            {
                this.SetValues(item);
            }

            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitUpdate_Click;
            this.ButtonSubmitClear.Click += this.ButtonSubmitClearUpdate_Click;
        }

        /// <summary>
        /// Loads the form data.
        /// </summary>
        private async void LoadFormData()
        {
            this.unitOfWork.Department.List(this.ComboBoxDepartment);
            this.unitOfWork.ItemCategory.List(this.ComboBoxItemCategory);
        }

        private void ButtonSubmitCreate_Click(object sender, EventArgs e)
        {
            try
            {
                this.unitOfWork.Item.Create(this.GetValuesCreate());
                this.Close();
            }
            catch (ValidateException ve)
            {
                MessageBox.Show(new Form { TopLevel=true},ve.Message);
            }
           
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmitClearUpdate_Click(object sender, EventArgs e)
        {

            if (this.update)
            {

                this.unitOfWork.Item.Update(this.GetValuesUpdate());
            }
            else
            {

                this.unitOfWork.Item.Create(this.GetValuesCreate());
            }
        }

        private void ButtonSubmitUpdate_Click(object sender, EventArgs e)
        {
            this.unitOfWork.Item.Update(this.GetValuesUpdate());
            this.Close();
        }

        /// <summary>
        /// Gets the values create.
        /// </summary>
        /// <returns>InventoryItemModel.</returns>
        private ItemModel GetValuesCreate()
        {
            List<string> inputparameters = new List<string>();
            if (this.TextBoxBarcode.EditValue == null)
            {
                inputparameters.Add("بارکد");
            }
            if (this.TextBoxName.EditValue == null)
            {
                inputparameters.Add("نام");
            }
            if (this.ComboBoxDepartment.EditValue == null)
            {
                inputparameters.Add("غرفه");
            }
            if (this.ComboBoxItemCategory.EditValue == null)
            {
                inputparameters.Add("دسته کالا");
            }
            if (this.TextBOxBuyPrice.EditValue == null)
            {
                inputparameters.Add("قیمت خرید");
            }
            if (this.TextBoxSellPrice.EditValue == null)
            {
                inputparameters.Add("قیمت فروش");
            }
            if (inputparameters.Count != 0)
            {
                throw new ValidateException(inputparameters.ToArray());
            }
            return new ItemModel(barcode: this.TextBoxBarcode.Text, department: ComboBoxDepartment.Text, category: this.ComboBoxItemCategory.Text, name: this.TextBoxName.Text, weighed: this.CheckBoxWeighed.Checked, sellPrice: long.Parse(this.TextBoxSellPrice.Text, this.cultureInfo), buyPrice: long.Parse(TextBOxBuyPrice.Text), active: true);
        }

        /// <summary>
        /// Gets the values update.
        /// </summary>
        /// <returns>InventoryItemModel.</returns>
        private ItemModel GetValuesUpdate()
        {
            return new ItemModel(id: Convert.ToInt32(TextBoxId.Text, this.cultureInfo), code: 0, barcode: this.TextBoxBarcode.Text, department: ComboBoxDepartment.Text, category: this.ComboBoxItemCategory.Text, name: this.TextBoxName.Text, weighed: this.CheckBoxWeighed.Checked, sellPrice: long.Parse(this.TextBoxSellPrice.Text, this.cultureInfo), buyPrice: long.Parse(TextBOxBuyPrice.Text), active: true,plumemory:TextBoxMemory.Text.ToInt());
        }

        /// <summary>
        /// Sets the values.
        /// </summary>
        /// <param name="item">The item.</param>
        private void SetValues(ItemModel item)
        {
            this.TextBoxMemory.Text = item.Memory.ToString();
            this.TextBoxId.Text = item.Id.ToString(this.cultureInfo);
            this.TextBoxBarcode.Text = item.Barcode;
            this.TextBOxBuyPrice.Text = item.BuyPrice.ToString();
            this.TextBoxName.Text = item.Name;
            this.ComboBoxDepartment.Text = item.Department;
            this.ComboBoxItemCategory.Text = item.Category;
            this.CheckBoxWeighed.Checked = item.Weighed;
            this.TextBoxSellPrice.Text = item.SellPrice.ToString(this.cultureInfo);
        }

        private void ButtonDepartmentRefresh_Click(object sender, EventArgs e)
        {
            this.unitOfWork.Department.List(this.ComboBoxDepartment);
        }

        private void ButtonItemCategoryRefresh_Click(object sender, EventArgs e)
        {
            this.unitOfWork.ItemCategory.List(this.ComboBoxItemCategory);
        }

        private void ButtonDepartmentNew_Click(object sender, EventArgs e)
        {
            DepartmentEdit departmentEdit = new DepartmentEdit();
            departmentEdit.Show();
        }

        private void ButtonItemCategoryNew_Click(object sender, EventArgs e)
        {
            ItemCategoryEdit itemCategoryEdit = new ItemCategoryEdit();
            itemCategoryEdit.Show();
        }
    }
}
