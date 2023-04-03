using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KarimiApp.Model;

namespace KarimiApp.Client.View.Edit
{
    public partial class AddInventoryItem : DevExpress.XtraEditors.XtraForm
    {
        public AddInventoryItem(ItemModel item)
        {
           
            InitializeComponent();
            this.TextBoxItemCode.Text = item.Id.ToString();
            this.TextBoxItemName.Text = item.Name;
        }

        public InventoryLogModel GetInventoryLog()
        {
            return new InventoryLogModel
            {
                Item = this.TextBoxItemCode.Text,
                Amount = Convert.ToDecimal(this.TextBoxAmount.Text),
                BuyPrice = Convert.ToInt64(this.TextBoxBuyPrice.Text),
                SellPrice = Convert.ToInt64(this.TextBoxSellPrice.Text)
            };
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
