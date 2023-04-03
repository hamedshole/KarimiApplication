using System;
using System.Globalization;
using System.Windows.Forms;
using KarimiApp.Model;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.List;
using System.Collections.Generic;
using KarimiApp.Exceptions;

namespace KarimiApp.Client.View.Edit
{
    public partial class InventoryEdit : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        private UserList userlist;
        private InventoryTypeList inventoryType;
        private bool update = true;
        private CultureInfo cultureInfo;
        private InventoryModel inventoryTemp;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryEdit"/> class.
        /// </summary>
        public InventoryEdit()
        {
            this.cultureInfo = new System.Globalization.CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();

            this.InitializeComponent();
            this.LoadFormData();
            this.Text = " انبار جدید";
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_Click;
            this.ButtonSubmitClear.Click += this.ButtonSubmitClearCreate_Click;
            this.ButtonCancel.Click += this.ButtonCancel_Click;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryEdit"/> class.
        /// </summary>
        /// <param name="inventory">The inventory.</param>
        public InventoryEdit(InventoryModel inventory)
        {
            this.unitOfWork = new UnitOfWork();
            this.cultureInfo = new System.Globalization.CultureInfo("fa-IR");
            this.InitializeComponent();
            this.LoadFormData();
            this.Text = "ویرایش انبار";
            if (inventory != null)
            {
                this.SetValues(inventory);
            }

            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitUpdate_CLick;
            this.ButtonSubmitClear.Click += this.ButtonSubmitClearUpdate_Click;
        }

        private void LoadFormData()
        {
            this.unitOfWork.User.List(this.ComboBoxKeeper);
            this.unitOfWork.InventoryGroup.List(this.ComboBoxInventoryType);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSubmitCreate_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryModel tmp = this.GetValuesCreate();
                this.unitOfWork.Inventory.Create(tmp);
                this.Close();
            }
            catch (ValidateException ve)
            {

                MessageBox.Show(new Form { TopLevel=true},ve.Message);
            }
            
        }

        private void ButtonSubmitClearUpdate_Click(object sender, EventArgs e)
        {
            InventoryModel tmp;
            if (this.update)
            {
                tmp = this.GetValuesUpdate();
                this.unitOfWork.Inventory.Update(tmp);
                this.ClearFields();
                this.update = false;
            }
            else
            {
                tmp = this.GetValuesCreate();
                this.unitOfWork.Inventory.Create(tmp);
            }
        }

        /// <summary>
        /// Sets the values.
        /// </summary>
        /// <param name="inventory">The inventory.</param>
        private void SetValues(InventoryModel inventory)
        {
            this.inventoryTemp = inventory;
            this.TextBoxId.Text = this.inventoryTemp.Id.ToString(this.cultureInfo);
            this.TextBoxTitle.Text = this.inventoryTemp.Title;
            this.ComboBoxInventoryType.Text = this.inventoryTemp.Group;
            this.ComboBoxKeeper.Text = this.inventoryTemp.Keeper;
            this.TextBoxDescription.Text = this.inventoryTemp.Description;
            this.CheckBoxActive.Checked = this.inventoryTemp.Active;
        }

        private void ButtonSubmitClearCreate_Click(object sender, EventArgs e)
        {
            InventoryModel tmp = this.GetValuesCreate();
            this.unitOfWork.Inventory.Create(tmp);
            this.ClearFields();
        }

        private void ClearFields()
        {
            this.TextBoxTitle.Text = string.Empty;
            this.TextBoxDescription.Text = string.Empty;
            this.CheckBoxActive.Checked = false;
            this.ComboBoxInventoryType.SelectedText = string.Empty;
            this.ComboBoxKeeper.SelectedText = string.Empty;
        }

        private InventoryModel GetValuesCreate()
        {
            List<string> inputparameters = new List<string>();
            if (this.TextBoxTitle.EditValue == null)
            {
                inputparameters.Add("عنوان انبار");
            }
            if (this.ComboBoxInventoryType.Text == null)
            {
                inputparameters.Add("نوع انبار");
            }
            if (this.ComboBoxKeeper.Text == null)
            {
                inputparameters.Add("مسئول انبار");
            }
            if (inputparameters.Count != 0)
            {
                throw new ValidateException(inputparameters.ToArray());
            }
            return new InventoryModel(title: this.TextBoxTitle.Text, description: this.TextBoxDescription.Text, keeper: this.ComboBoxKeeper.Text, group: this.ComboBoxInventoryType.Text, active: this.CheckBoxActive.Checked);
        }

        private InventoryModel GetValuesUpdate()
        {
            return new InventoryModel(id: Convert.ToInt32(this.TextBoxId.Text, this.cultureInfo), title: this.TextBoxTitle.Text, description: this.TextBoxDescription.Text, keeper: this.ComboBoxKeeper.Text, group: this.ComboBoxInventoryType.Text, active: this.CheckBoxActive.Checked);
        }

        private void ButtonSubmitUpdate_CLick(object sender, EventArgs e)
        {
            InventoryModel tmp = this.GetValuesUpdate();
            this.unitOfWork.Inventory.Update(tmp);
            this.Close();
        }

        private void ButtonInventoryType_Click(object sender, EventArgs e)
        {
            InventoryTypeEdit inventoryType = new InventoryTypeEdit();
            inventoryType.Show();
        }

        private void GridViewInventoryType_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                this.ComboBoxInventoryType.Text = ((sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRow(e.RowHandle) as InventoryGroupModel).Title;
                this.inventoryType.Dispose();
            }
        }

        private void ButtonKeeper_Click(object sender, EventArgs e)
        {
            UserEdit userEdit = new UserEdit();
            userEdit.Show();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.ComboBoxInventoryType.Properties.Items.Clear();
            this.unitOfWork.InventoryGroup.List(this.ComboBoxInventoryType);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.ComboBoxKeeper.Properties.Items.Clear();
            this.unitOfWork.User.List(this.ComboBoxKeeper);
        }
    }
}