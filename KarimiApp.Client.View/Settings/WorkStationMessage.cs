using KarimiApp.Model;
using KarimiApp.Workstation.Client.Repository;
using System;

namespace KarimiApp.Client.View.Settings
{

    public partial class WorkStationMessage : DevExpress.XtraEditors.XtraForm
    {
        private WorkStationUnitOfWork unitOfWork;
        private string IpAddress;
        public WorkStationMessage(string workStationIp)
        {
            this.unitOfWork = new WorkStationUnitOfWork();
            this.IpAddress = workStationIp;
            InitializeComponent();
        }

        private void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            WorkStationMessageModel message = new WorkStationMessageModel()
            {
                Beep=CheckboxBeep.Checked,
                CloseByKey=CheckBoxCloseByKey.Checked,
                Title=TextBoxTitle.Text,
                Duration =Convert.ToInt32(TextBoxDuration.Text),
                Ip=this.IpAddress,
                Message=TextBoxMessage.Text
            };
            unitOfWork.WorkstationPanel.SendMessage(message);
        }
    }
}