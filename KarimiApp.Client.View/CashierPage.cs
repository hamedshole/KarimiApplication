using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KarimiApp.Client.Repository;
using KarimiApp.Model;

namespace KarimiApp.Client.View
{
    public partial class CashierPage : DevExpress.XtraEditors.XtraForm
    {
        public CashierPage()
        {
            InitializeComponent();
            this.listBoxControl1.Click += ListBoxControl1_Click;
            for (int i = 0; i < 12; i++)
            {
                this.flowLayoutPanel2.Controls.Add(new Button() { Size = new Size(150, 50), Text = "btn" + i.ToString() });
            }
        }

        private void ListBoxControl1_Click(object sender, EventArgs e)
        {
            PersonModel person = (sender as ListBoxControl).SelectedItem as PersonModel;
            this.textBox2.Text = person.Name;
            this.label4.Text = person.Balance.ToString("#,#");
            (sender as ListBoxControl).Visible = false;
            this.simpleButton2.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string tbtext = (sender as TextBox).Text;
            if (string.IsNullOrEmpty(tbtext))
                listBoxControl1.Visible = false;
            else
            {
                listBoxControl1.Visible = true;
                UnitOfWork unitOfWork = new UnitOfWork();
                List<PersonModel> people = unitOfWork.Person.Search((sender as TextBox).Text);
                listBoxControl1.DataSource = people;
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.simpleButton2.Visible = false;
            this.textBox2.Clear();
            this.label4.Text = "00000";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
    }
}