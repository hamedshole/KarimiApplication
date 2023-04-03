using DevExpress.XtraEditors;
using KarimiApp.Client.Repository;
using KarimiApp.Model;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarimiApp.Client.View
{
    public partial class LoginPage : XtraForm
    {
        private UnitOfWork unitOfWork;
        public LoginPage()
        {
            unitOfWork = new UnitOfWork();
            InitializeComponent();
        }


        private  void ButtonLogin_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        public async Task<UserModel> LoginValue()
        {
            UserModel loggedUser;
            //try
            //{
            loggedUser =await unitOfWork.Authentication.Login(TextBoxUsername.Text, TextBoxPassword.Text);
            return loggedUser;
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //    return new UserModel();
            //}
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            View.Settings.ClientFirstConfig firstConfig = new Settings.ClientFirstConfig();
            firstConfig.Show();
        }
    }
}