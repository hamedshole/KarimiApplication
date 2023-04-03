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

namespace KarimiApp.Client.View.List
{
    public partial class PersonCredits : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        public PersonCredits()
        {
            
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            

        }
    }
}