using KarimiApp.Client.Repository;
using KarimiApp.Model;
using System;

namespace KarimiApp.Client.View.Edit
{
    public partial class WorkStationEdit : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        private System.Globalization.CultureInfo cultureInfo;
        private bool update = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkStationEdit"/> class.
        /// </summary>
        public WorkStationEdit()
        {
            this.cultureInfo = new System.Globalization.CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.unitOfWork.Department.List(this.ComboBoxDepartment);
            this.Text ="دستگاه جدید";
            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitCreate_CLick;
            this.ButtonSubmitClear.Click += this.ButtonSubmitClearCreate_Click;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkStationEdit"/> class.
        /// </summary>
        /// <param name="workStation">The work station.</param>
        public WorkStationEdit(WorkstationModel workStation)
        {
            this.cultureInfo = new System.Globalization.CultureInfo("fa-IR");
            this.unitOfWork = new UnitOfWork();
            this.InitializeComponent();
            this.unitOfWork.Department.List(this.ComboBoxDepartment);
            this.Text = "ویرایش دستگاه";
            if (workStation != null)
            {
                this.SetValues(workStation);
            }

            this.ButtonCancel.Click += this.ButtonCancel_Click;
            this.ButtonSubmit.Click += this.ButtonSubmitUpdate_CLick;
            this.ButtonSubmitClear.Click += this.ButtonSubmitClearUpdate_Click;
        }

        private void ButtonSubmitClearCreate_Click(object sender, EventArgs e)
        {
            WorkstationModel tmp = this.GetValuesCreate();
            this.unitOfWork.Workstation.Create(tmp);
            this.ClearFields();
        }

        private void ButtonSubmitCreate_CLick(object sender, EventArgs e)
        {
            WorkstationModel tmp = this.GetValuesCreate();
            this.unitOfWork.Workstation.Create(tmp);
        }

        private void ButtonSubmitClearUpdate_Click(object sender, EventArgs e)
        {
            if (this.update)
            {
                WorkstationModel tmp = this.GetValuesUpdate();
                this.unitOfWork.Workstation.Update(tmp);
                this.ClearFields();
                this.update = false;
            }
            else
            {
                WorkstationModel tmp = this.GetValuesCreate();
                this.unitOfWork.Workstation.Create(tmp);
                this.ClearFields();
            }
        }

        /// <summary>
        /// Gets the values update.
        /// </summary>
        /// <returns>WorkStationModel.</returns>
        private WorkstationModel GetValuesUpdate()
        {
            return new WorkstationModel(id: Convert.ToInt32(this.TextBoxId.Text, this.cultureInfo), department: this.ComboBoxDepartment.Text, title: this.TextBoxTitle.Text, ipAddress: this.TextBoxIpAddress.Text, portNumber:Convert.ToInt32( this.TextBoxPort.Text));
        }

        /// <summary>
        /// Gets the values create.
        /// </summary>
        /// <returns>WorkStationModel.</returns>
        private WorkstationModel GetValuesCreate()
        {
            return new WorkstationModel(title: this.TextBoxTitle.Text, department: this.ComboBoxDepartment.Text, ipAddress: this.TextBoxIpAddress.Text, portNumber:Convert.ToInt32( this.TextBoxPort.Text));
        }

        /// <summary>
        /// Clears the fields.
        /// </summary>
        private void ClearFields()
        {
            this.TextBoxTitle.Text = string.Empty;
            this.TextBoxIpAddress.Text = string.Empty;
            this.TextBoxPort.Text = string.Empty;
            this.TextBoxId.Text = string.Empty;
        }

        private void ButtonSubmitUpdate_CLick(object sender, EventArgs e)
        {
            WorkstationModel tmp = this.GetValuesUpdate();
            this.unitOfWork.Workstation.Update(tmp);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sets the values.
        /// </summary>
        /// <param name="workStation">The work station.</param>
        private void SetValues(WorkstationModel workStation)
        {
            this.TextBoxId.Text = workStation.Id.ToString(this.cultureInfo);
            this.ComboBoxDepartment.Text = workStation.Department;
            this.TextBoxTitle.Text = workStation.Title;
            this.TextBoxIpAddress.Text = workStation.IpAddress;
            this.TextBoxPort.Text = workStation.PortNumber.ToString();
        }

        private void ButtonDepartmentRefresh_Click(object sender, EventArgs e)
        {
            this.unitOfWork.Department.List(this.ComboBoxDepartment);
        }
    }
}