using KarimiApp.Client.Repository;
using KarimiApp.Exceptions;
using KarimiApp.Model;
using System;
using System.Collections.Generic;

namespace KarimiApp.Client.View.Edit
{
    public partial class PosInfoEdit : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        public PosInfoEdit()
        {
            this.unitOfWork = new UnitOfWork();
            InitializeComponent();
            this.Text = "درگاه جدید";
            this.ButtonSubmit.Click += ButtonSubmit_Click;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                this.unitOfWork.PosInfo.Create(this.getValuesCreate());
                this.Close();
            }
            catch (ValidateException ve)
            {
                System.Windows.Forms.MessageBox.Show(ve.Message);
            }
          
        }

        private PosInfoModel getValuesCreate()
        {
            List<string> inputparameters = new List<string>();
            if (this.TextBoxTitle.EditValue == null)
            {
                inputparameters.Add("عنوان");
            }
            if (this.TextBoxCom.EditValue == null)
            {
                inputparameters.Add("com شماره");
            }
            if (inputparameters.Count != 0)
            {
                throw new ValidateException(inputparameters.ToArray());
            }
            return new PosInfoModel
            (
                com : Convert.ToInt32(this.TextBoxCom.Text),
                title:  TextBoxTitle.Text
            );
        }

       

        public PosInfoEdit(PosInfoModel posInfo)
        {
            this.unitOfWork = new UnitOfWork();
            InitializeComponent();
            this.Text = "ویرایش درگاه";
            this.SetValues(posInfo);
            this.ButtonSubmit.Click += ButtonSubmit_Click1;
        }

        private void ButtonSubmit_Click1(object sender, EventArgs e)
        {
            this.unitOfWork.PosInfo.Update(this.GetValuesUpdate());
            this.Close();
        }

        private PosInfoModel GetValuesUpdate()
        {
            return new PosInfoModel
            (
                id: Convert.ToInt32(TextBoxId.Text),
               com: Convert.ToInt32(TextBoxCom.Text),
                title: TextBoxTitle.Text
          );
        }

        private void SetValues(PosInfoModel posInfo)
        {
            this.TextBoxId.Text = posInfo.Id.ToString();
            this.TextBoxTitle.Text = posInfo.Title;
            this.TextBoxCom.Text = posInfo.Com.ToString();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}