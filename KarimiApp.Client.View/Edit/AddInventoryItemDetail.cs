using DevExpress.XtraEditors;
using KarimiApp.Client.Repository;
using KarimiApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Edit
{
    public partial class AddInventoryItemDetail : DevExpress.XtraEditors.XtraForm
    {
        private UnitOfWork unitOfWork;
        private ItemModel selectedItem;
        public AddInventoryItemDetail()
        {
            this.unitOfWork = new UnitOfWork();
            this.selectedItem = new ItemModel();
            InitializeComponent();
            this.TextBoxSearch.KeyDown += TextBoxSearch_KeyDown;
            this.TextBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            this.listBoxControl1.Click += ListBoxControl1_Click;
            this.listBoxControl1.KeyDown += ListBoxControl1_KeyDown;
            this.gridView1.RowCellStyle += GridView1_RowCellStyle;
            //this.comboBoxEdit1.Properties.Items.AddRange(this.names);
        }

        private void ListBoxControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ListItemSelect();
            }
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.listBoxControl1.Focus();
            }
        }

       

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "colIo")
            {
                if (e.CellValue == "خرید")
                {
                    e.Appearance.BackColor = Color.GreenYellow;
                }
                else if (e.CellValue == "فروش")
                {
                    e.Appearance.BackColor = Color.MistyRose;
                }
            }
        }

        private void ListBoxControl1_Click(object sender, EventArgs e)
        {
            ListItemSelect();
        }

        private void ListItemSelect()
        {
            this.selectedItem = this.listBoxControl1.SelectedItem as ItemModel;
            this.TextBoxSearch.Text = this.selectedItem.Name;
            this.FillItemInfos();
            this.listBoxControl1.Visible = false;
            this.unitOfWork.InventoryManagement.GetItemLog(item: this.selectedItem, grid: this.gridControl1);
        }

        private void FillItemInfos()
        {
            this.TextBoxName.Text = this.selectedItem.Name;
            this.TextBoxCategory.Text = this.selectedItem.Category;
            this.TextBoxDepartment.Text = this.selectedItem.Department;
            this.TextBoxBarcode.Text = this.selectedItem.Barcode;
            if (this.selectedItem.Weighed)
            {
                this.TextBoxWeighed.Text = "وزنی";
            }
            else
            {
                this.TextBoxWeighed.Text = "تعدادی";
            }
            this.TextBoxBuyPrice.Text = this.selectedItem.BuyPrice.ToString("#,#")+"ریال";
            this.TextBoxSellPrice.Text = this.selectedItem.SellPrice.ToString("#,#") + "ریال";
            this.TextBoxStock.Text = this.selectedItem.Stock.ToString();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.TextBoxSearch.Text))
            {
                List<ItemModel> items = this.unitOfWork.Item.Search(this.TextBoxSearch.Text);
                this.listBoxControl1.DataSource = items;
                this.listBoxControl1.Visible = true;
            }
            else
            {
                this.listBoxControl1.Visible = false;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddInventoryItem addInventoryItem = new AddInventoryItem(this.selectedItem);
            addInventoryItem.Show();
            addInventoryItem.simpleButton1.Click += SimpleButton1_Click;
            addInventoryItem.simpleButton1.Tag = addInventoryItem;
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            AddInventoryItem addpage= (sender as SimpleButton).Tag as AddInventoryItem;
            InventoryLogModel itemlog = addpage.GetInventoryLog();
            this.unitOfWork.InventoryManagement.AddItem(itemlog);
            addpage.Close();
            this.RefreshItemData();
        }

        private void RefreshItemData()
        {
            this.TextBoxBuyPrice.Text=string.Empty;
            this.TextBoxSellPrice.Text = string.Empty;
            this.TextBoxName.Text = string.Empty;
            this.TextBoxCategory.Text = string.Empty;
            this.TextBoxDepartment.Text = string.Empty;
            this.TextBoxStock.Text = string.Empty;
            this.TextBoxSearch.Text = string.Empty;
            this.gridControl1.DataSource = null;
        }
    }
}