using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Edit
{
    public partial class DepartmentEdit : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        private bool update = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentEdit"/> class.
        /// </summary>
        public DepartmentEdit()
        {
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.unitOfWork.Inventory.List(this.ComboBoxInventory);
            this.Text = "غرفه جدید";
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_CLick;
            this.ButtonSubmitClear.Click += this.ButtonSubmitClearCreate_Click;
            this.ButtonCancel.Click += this.ButtonCancel_Click;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentEdit"/> class.
        /// </summary>
        /// <param name="department">The department.</param>
        public DepartmentEdit(DepartmentModel department)
        {
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.Text = "ویرایش غرفه";
            this.unitOfWork.Inventory.List(this.ComboBoxInventory);
            this.SetValues(department);
            this.ButtonSubmit.Click += this.ButtonSubmitUpdate_CLick;
            this.ButtonSubmitClear.Click += this.ButtonSubmitClearUpdate_Click;
            this.ButtonCancel.Click += this.ButtonCancel_Click;
        }

        private void ButtonSubmitClearUpdate_Click(object sender, EventArgs e)
        {
            DepartmentModel tmp;
            if (this.update)
            {
                tmp = this.GetValuesUpdate();
                this.unitOfWork.Department.Update(tmp);
            }
            else
            {
                tmp = this.GetValuesUpdate();
                this.unitOfWork.Department.Create(tmp);
            }

            this.ClearFields();
        }

        private void ButtonSubmitUpdate_CLick(object sender, EventArgs e)
        {
            DepartmentModel tmp = this.GetValuesUpdate();
            this.unitOfWork.Department.Update(tmp);
            this.Close();
        }

        private void ButtonSubmitClearCreate_Click(object sender, EventArgs e)
        {
            DepartmentModel tmp = this.GetValuesCreate();
            this.unitOfWork.Department.Create(tmp);
            this.ClearFields();
        }

        private void ClearFields()
        {
            this.TextBoxName.Text = string.Empty;
            this.TextBoxDescription.Text = string.Empty;
            this.CheckBoxActive.Checked = false;
        }

        private void ButtonSubmitCreate_CLick(object sender, EventArgs e)
        {
            try
            {
                DepartmentModel tmp = this.GetValuesCreate();
                this.unitOfWork.Department.Create(tmp);
                this.Close();
            }
            catch (ValidateException ve)
            {
                MessageBox.Show(new Form { TopLevel = true }, ve.Message);
            }

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetValues(DepartmentModel department)
        {
            if (department != null)
            {
                this.TextBoxId.Text = department.Id.ToString();
                this.TextBoxName.Text = department.Title;
                this.TextBoxDescription.Text = department.Description;
                this.CheckBoxActive.Checked = department.Active;
            }
        }

        /// <summary>
        /// Gets the values create.
        /// </summary>
        /// <returns>DepartmentModel.</returns>
        private DepartmentModel GetValuesCreate()
        {
            List<string> inputparameters = new List<string>();
            if (this.TextBoxName.ErrorText == null)
            {
                inputparameters.Add("عنوان غرفه");
            }
            if (string.IsNullOrEmpty(this.ComboBoxInventory.Text))
            {
                inputparameters.Add("عنوان انبار پیش فرض");
            }
            if (inputparameters.Count != 0)
            {
                throw new ValidateException(inputparameters.ToArray());
            }

            return new DepartmentModel(title: this.TextBoxName.Text, description: this.TextBoxDescription.Text, active: this.CheckBoxActive.Checked, defaultInventory: ComboBoxInventory.Text);
        }

        /// <summary>
        /// Gets the values update.
        /// </summary>
        /// <returns>DepartmentModel.</returns>
        private DepartmentModel GetValuesUpdate()
        {
            return new DepartmentModel(id: Convert.ToInt32(this.TextBoxId.Text), title: this.TextBoxName.Text, description: this.TextBoxDescription.Text, active: this.CheckBoxActive.Checked, defaultInventory: ComboBoxInventory.Text);
        }

        private void ButtonInventoryNew_Click(object sender, EventArgs e)
        {
            InventoryEdit inventoryEdit = new InventoryEdit();
            inventoryEdit.Show();
        }

        private void ButtonInventoryRefresh_Click(object sender, EventArgs e)
        {
            this.unitOfWork.Inventory.List(this.ComboBoxInventory);
        }
    }
}
