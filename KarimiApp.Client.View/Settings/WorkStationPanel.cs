using DevExpress.Utils.Extensions;
using KarimiApp.Client.Repository;
using KarimiApp.Model;
using KarimiApp.Workstation.Client.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KarimiApp.Client.View.Settings
{
    public partial class WorkStationPanel : DevExpress.XtraEditors.XtraForm
    {
        //private int[] hardkeys = new int[70];
        private HardwareKeyModel[] keys=new  HardwareKeyModel[70];
        private UnitOfWork unitOfWork;
        private WorkStationUnitOfWork workStationUnitOfWork;
        int rowmemory = 1;
        private WorkstationModel workStation;
        List<ItemModel> plusDataSource;
        List<HardwareKeyModel> hardwareKeys;
        public WorkStationPanel(WorkstationModel workStation)
        {
            this.workStation = workStation;
            workStationUnitOfWork = new WorkStationUnitOfWork();
            hardwareKeys = new List<HardwareKeyModel>();
            plusDataSource = new List<ItemModel>();
            unitOfWork = new UnitOfWork();
           
            this.hardwareKeys = this.unitOfWork.HardKey.List(new HardwareKeyModel(workStation.Title));
            InitializeComponent();
            unitOfWork.Department.List(ComboBoxDepartment);
            DepartmentModel workstationDepartment = this.unitOfWork.Department.Get(this.workStation.Department);
            this.ComboBoxDepartment.Text = workstationDepartment.Title;
         
            this.TextBoxWorkStationName.Text = workStation.Title;
            this.unitOfWork.Item.FilterByDepartment(GridControlItem, this.ComboBoxDepartment.Text);
            this.ComboBoxDepartment.SelectedValueChanged += ComboBoxDepartment_SelectedValueChanged;
            this.TextBoxSearchItemName.TextChanged += TextBoxSearchItemName_TextChanged;
            long totalReceiptAmount = workStationUnitOfWork.WorkstationPanel.TotalReceiptAmount(workStation.Title);
            LabelTotal.Text = totalReceiptAmount.ToString("#,#");
            long totalReceiptAmountForDate = workStationUnitOfWork.WorkstationPanel.TotalReceiptAmountForDate(new ReceiptModel(workStation.Title, DateTime.Now));
            LabelTotalToday.Text = totalReceiptAmountForDate.ToString("#,#");
            int totalReceiptCount = this.workStationUnitOfWork.WorkstationPanel.TotalReceiptCount(workStation.Title);
            LabelTotalCount.Text = totalReceiptCount.ToString();
            int totalReceiptCountForDate = this.workStationUnitOfWork.WorkstationPanel.TotalReceiptCountForDate(new ReceiptModel(workStation.Title, DateTime.Now));
            LabelTotalCountToday.Text = totalReceiptCountForDate.ToString();
            this.GridControlItem.MouseDown += GridControlItem_MouseDown;
            this.GroupBoxsDragDrops();
            this.CheckBoxShift.CheckedChanged += CheckBoxShift_CheckedChanged;
            this.LoadHardwareKeys();
        }

        private void GridControlItem_MouseDown(object sender, MouseEventArgs e)
        {
            ItemModel item = this.GridViewItem.GetFocusedRow() as ItemModel;
            this.GridControlItem.DoDragDrop(item, DragDropEffects.Copy);
        }

        private void LoadHardwareKeys()
        {
            if (this.CheckBoxShift.Checked)
            {
                int i = 36;
                foreach (GroupBox item in FlowLayoutPanelKeyPanel.Controls)
                {
                    item.Text = i.ToString();
                    HardwareKeyModel tmpHardKey = this.hardwareKeys.Find(x => x.Key == i);
                    if (tmpHardKey != null)
                    {
                        this.SetGroupBoxValue(item, tmpHardKey.Item);
                        //this.SetGroupBoxValue(item, this.plusDataSource.Find(x => x.Memory == tmpHardKey.Plu.Memory));
                    }
                    else if (tmpHardKey == null)
                    {
                        this.SetGroupBoxNull(item);
                    }
                    //int memory = this.hardwareKeys.Find(x => x.Key == i).Plu.Memory;
                    // PluModel p = this.plusDataSource.Find(x => x.Memory == memory);

                    i++;
                }
            }
            if (!this.CheckBoxShift.Checked)
            {
                int i = 1;
                foreach (GroupBox item in FlowLayoutPanelKeyPanel.Controls)
                {
                    item.Text = i.ToString();
                    HardwareKeyModel tmpHardKey = this.hardwareKeys.Find(x => x.Key == i);
                    if (tmpHardKey != null)
                    {
                        this.SetGroupBoxValue(item, tmpHardKey.Item);
                        //  this.SetGroupBoxValue(item, this.plusDataSource.Find(x => x.Memory == tmpHardKey.Plu.Memory));
                        // this.SetGroupBoxValue(item, this.plusDataSource.Find();
                    }
                    else if (tmpHardKey == null)
                    {
                        this.SetGroupBoxNull(item);
                    }

                    i++;
                }
            }
        }

        private void CheckBoxShift_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxShift.Checked)
            {
                int i = 36;
                foreach (GroupBox item in FlowLayoutPanelKeyPanel.Controls)
                {
                    item.Text = i.ToString();
                    HardwareKeyModel tmpHardKey = this.hardwareKeys.Find(x => x.Key == i);
                    if (tmpHardKey != null)
                    {
                        this.SetGroupBoxValue(item, tmpHardKey.Item);
                    }
                    else if (tmpHardKey == null)
                    {
                        this.SetGroupBoxNull(item);
                    }
                    //int memory = this.hardwareKeys.Find(x => x.Key == i).Plu.Memory;
                    // PluModel p = this.plusDataSource.Find(x => x.Memory == memory);

                    i++;
                }
            }
            if (!this.CheckBoxShift.Checked)
            {
                int i = 1;
                foreach (GroupBox item in FlowLayoutPanelKeyPanel.Controls)
                {
                    item.Text = i.ToString();
                    HardwareKeyModel tmpHardKey = this.hardwareKeys.Find(x => x.Key == i);
                    if (tmpHardKey != null)
                    {
                        this.SetGroupBoxValue(item, tmpHardKey.Item);
                    }
                    else if (tmpHardKey == null)
                    {
                        this.SetGroupBoxNull(item);
                    }

                    i++;
                }
            }
        }

        private void GroupBoxsDragDrops()
        {
            this.SetDragDropMethods(this.groupBox1);
            this.SetDragDropMethods(this.groupBox2);
            this.SetDragDropMethods(this.groupBox3);
            this.SetDragDropMethods(this.groupBox4);
            this.SetDragDropMethods(this.groupBox5);
            this.SetDragDropMethods(this.groupBox6);
            this.SetDragDropMethods(this.groupBox7);
            this.SetDragDropMethods(this.groupBox8);
            this.SetDragDropMethods(this.groupBox9);
            this.SetDragDropMethods(this.groupBox10);
            this.SetDragDropMethods(this.groupBox11);
            this.SetDragDropMethods(this.groupBox12);
            this.SetDragDropMethods(this.groupBox13);
            this.SetDragDropMethods(this.groupBox14);
            this.SetDragDropMethods(this.groupBox15);
            this.SetDragDropMethods(this.groupBox16);
            this.SetDragDropMethods(this.groupBox17);
            this.SetDragDropMethods(this.groupBox18);
            this.SetDragDropMethods(this.groupBox19);
            this.SetDragDropMethods(this.groupBox20);
            this.SetDragDropMethods(this.groupBox21);
            this.SetDragDropMethods(this.groupBox22);
            this.SetDragDropMethods(this.groupBox23);
            this.SetDragDropMethods(this.groupBox24);
            this.SetDragDropMethods(this.groupBox25);
            this.SetDragDropMethods(this.groupBox26);
            this.SetDragDropMethods(this.groupBox27);
            this.SetDragDropMethods(this.groupBox28);
            this.SetDragDropMethods(this.groupBox29);
            this.SetDragDropMethods(this.groupBox30);
            this.SetDragDropMethods(this.groupBox31);
            this.SetDragDropMethods(this.groupBox32);
            this.SetDragDropMethods(this.groupBox33);
            this.SetDragDropMethods(this.groupBox34);
            this.SetDragDropMethods(this.groupBox35);
        }
        private void SetDragDropMethods(GroupBox groupBox)
        {
            groupBox.AllowDrop = true;
            groupBox.DragDrop += this.GroupBox1_DragDrop;
            groupBox.DragEnter += this.GroupBox1_DragEnter;
        }
        private void GroupBox1_DragDrop(object sender, DragEventArgs e)
        {
            ItemModel item = e.Data.GetData(typeof(ItemModel)) as ItemModel;
            ////string p = e.Data.GetData(DataFormats.Text).ToString();
            GroupBox gb = (sender as GroupBox);
            this.SetKeyPanelGroupBoxValue(gb, item);
            //(gb.Controls[0] as Label).Text = p.Item.Name;
            //(gb.Controls[1] as Label).Text = string.Format("حافظه : {0}", p.Memory);
        }

        private void GroupBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void TextBoxSearchItemName_TextChanged(object sender, EventArgs e)
        {
            this.unitOfWork.Item.SearchFilterByDepartment(grid: GridControlItem, item: new ItemModel(department: this.ComboBoxDepartment.Text, text: this.TextBoxSearchItemName.Text));
        }

        private void ComboBoxDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            this.unitOfWork.Item.SearchFilterByDepartment(grid: GridControlItem, item: new ItemModel(department: this.ComboBoxDepartment.Text, text: this.TextBoxSearchItemName.Text));
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetKeyPanelGroupBoxValue(GroupBox groupBox, ItemModel item)
        {
            SetGroupBoxValue(groupBox, item);
            HardwareKeyModel hardwareKey = new HardwareKeyModel(item:item, key: groupBox.Text.ToInt(),workstation:this.workStation.Title);
            // this.hardkeys.(groupBox.Text.ToInt(), plu.Item.Id);
            //////////// this.keys[groupBox.ToInt()-1]=new HardwareKeyModel { Workstation=this.workStation.Title,Plu}
            // this.hardkeys[Convert.ToInt32(groupBox.Text)-1] = plu.Memory;
            this.keys[groupBox.Text.ToInt()-1] = hardwareKey;
            this.hardwareKeys.Add(hardwareKey);
        }

        private void SetGroupBoxValue(GroupBox groupBox, ItemModel item)
        {
            (groupBox.Controls[1] as Label).Text = item.Name;
            (groupBox.Controls[0] as Label).Text = item.Memory.ToString();
        }
        private void SetGroupBoxNull(GroupBox groupBox)
        {
            (groupBox.Controls[1] as Label).Text = "";
            (groupBox.Controls[0] as Label).Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   foreach (var item in this.hardwareKeys)
            //   {
            //       MessageBox.Show(string.Format("{0}   {1}", item.Key, item.Plu.Memory));
            //   }
            foreach (var item in this.plusDataSource)
            {
                MessageBox.Show(item.Weighed.ToString());
            }

        }

        private void ButtonSendPlu_Click(object sender, EventArgs e)
        {
            this.workStationUnitOfWork.WorkstationPanel.SendPlu(new WorkstationPluModel(this.workStation.IpAddress, new List<ItemModel>()));
        }

        private void ButtonSendHardKey_Click(object sender, EventArgs e)
        {
            //if (this.hardwareKeys.Count < 70)
            //{
            //    for (int i = this.hardwareKeys.Count; i < 71; i++)
            //    {
            //        this.hardwareKeys.Add(new HardwareKeyModel(key: 0, memory: 0));
            //    }
            //}
            foreach (var item in this.hardwareKeys)
            {
                this.keys[item.Key-1] = item;
            }
          
            this.workStationUnitOfWork.WorkstationPanel.SendHardKey(new WorkstationHardKeyModel(ipAddress: this.workStation.IpAddress, hardKeys: this.keys,workstation:this.workStation.Title));
          //  this.workStationUnitOfWork.WorkstationPanel.SendHardKey(new WorkstationHardKeyModel(this.workStation.IpAddress, this.hardwareKeys) { HardKeyString=JsonConvert.SerializeObject(this.hardkeys)});
        }

        private void ButtonSendMessage_Click(object sender, EventArgs e)
        {
            WorkStationMessage workStationMessage = new WorkStationMessage(this.workStation.IpAddress);
            workStationMessage.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<ItemModel> items = new List<ItemModel>();
            for (int i = 0; i < this.GridViewItem.RowCount; i++)
            {
                items.Add(GridViewItem.GetRow(i) as ItemModel);
            }
            this.plusDataSource.AddRange(items);
            if ((this.gridControl1.DataSource as List<ItemModel>) == null)
            {
                this.gridControl1.DataSource = items;
            }
            else
            {
                (this.gridControl1.DataSource as List<ItemModel>).AddRange(items);
            }
            this.gridControl1.RefreshDataSource();
        }
    }
}