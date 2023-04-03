using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.CustomControls;
using KarimiApp.Client.View.Edit;
using KarimiApp.Client.View.List;
using KarimiApp.Client.View.Settings;
using KarimiApp.Model;
using KarimiApp.ReportPrintRepository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ModelFactory = KarimiApp.Client.View.Util.ModelFactory;

namespace KarimiApp.Client.View
{
    public partial class CashierMain : DevExpress.XtraEditors.XtraForm
    {
        private PrintUnit printUnit;
        private List<DiscountModel> discounts;
        private SettingsModel settings;
        public UserModel logged;
        public UserRoleModel loggedUserRole;
        private UnitOfWork unitOfWork;
        ModelFactory factory;
        private AdminPage admin;
        private string barcodetextbox = "";
        private Util.PosUnit PosUnit;
        private Timer barcodeTimer;
        private List<TransactionEntryModel>[] gridControlMemory;
        private List<int> receipts = new List<int>();

        public CashierMain(UserModel loggedUser)
        {
            discounts = new List<DiscountModel>();
            gridControlMemory = new List<TransactionEntryModel>[11];
            gridControlMemory[1] = new List<TransactionEntryModel>();
            gridControlMemory[2] = new List<TransactionEntryModel>();
            gridControlMemory[3] = new List<TransactionEntryModel>();
            gridControlMemory[4] = new List<TransactionEntryModel>();
            gridControlMemory[5] = new List<TransactionEntryModel>();
            gridControlMemory[6] = new List<TransactionEntryModel>();
            gridControlMemory[7] = new List<TransactionEntryModel>();
            gridControlMemory[8] = new List<TransactionEntryModel>();
            gridControlMemory[9] = new List<TransactionEntryModel>();
            gridControlMemory[10] = new List<TransactionEntryModel>();
            this.printUnit = new PrintUnit();
            this.settings = JsonConvert.DeserializeObject<SettingsModel>(System.IO.File.ReadAllText("Settings/settings.hshk"));
            this.PosUnit = new Util.PosUnit();
            unitOfWork = new UnitOfWork();
            //gridSource = new List<TransactionEntryModel>();
            logged = new UserModel();
            this.logged = loggedUser;
            this.loggedUserRole = this.unitOfWork.UserRole.Get(this.logged.Role);
            factory = new ModelFactory();
            InitializeComponent();
            this.barEditItem6.EditValue = null;
            this.textBox1.TextChanged += TextBox1_TextChanged;
            // this.textBox1.Leave += TextBox1_Leave;
            discounts = this.unitOfWork.Discount.List();
            foreach (var item in discounts)
            {
                this.repositoryItemComboBox5.Items.Add(item.Title);
            }
            this.repositoryItemComboBox5.SelectedIndexChanged += RepositoryItemComboBox4_SelectedIndexChanged;

            this.TextBoxLastTransactionValue.Caption = this.unitOfWork.Transaction.LastValue().ToString("#,#");
            this.LoadCustomerMemory();
            this.ribbon.ShowToolbarCustomizeItem = false;
            admin = new AdminPage();
            admin.Dock = DockStyle.Fill;
            admin.TopLevel = false;
            this.ribbon.ApplicationButtonDropDownControl = admin;
            UserRoleModel loggedUserRole = this.unitOfWork.UserRole.Get(this.logged.Role);
            if (loggedUserRole.Title != "مدیرکل")
            {
                this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            }
            FillRibbon();
            GridControlTransactionEntry.BackColor = Color.Transparent;
            GridViewTransactionEntry.Appearance.Row.Options.UseBackColor = true;
            GridViewTransactionEntry.Appearance.Row.BackColor = Color.Transparent;
            GridViewTransactionEntry.Appearance.Empty.Options.UseBackColor = true;
            GridViewTransactionEntry.Appearance.Empty.BackColor = Color.Transparent;
            if (System.IO.File.Exists(this.settings.CustomCashierGirdBg))
            {
                this.GridControlTransactionEntry.BackgroundImage = Image.FromFile(this.settings.DefaultCashierGridBg);
                this.GridControlTransactionEntry.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                // MessageBox.Show("تصویر انتخابی برای پس زمینه وجود ندارد.از تصویر پیش فرض استفاده میشود");
                this.GridControlTransactionEntry.BackgroundImage = Image.FromFile(this.settings.DefaultCashierGridBg);
                this.GridControlTransactionEntry.BackgroundImageLayout = ImageLayout.Stretch;
            }
            GridViewTransactionEntry.RowCountChanged += GridViewTransactionEntry_RowCountChanged;
            ButtonLoggedUser.Caption = loggedUser.Name + " " + loggedUserRole.Title;
            TextBoxDate.Caption = DateTime.Now.ToLongDateString();
            this.GridControlTransactionEntry.DataSource = this.gridControlMemory[this.barEditItem1.EditValue.ToInt()];
            this.ribbonPageGroup1.ItemLinks.Add(new CustomBarButtonItem());
            this.GridControlTransactionEntry.DataSource = this.gridControlMemory[this.barEditItem1.EditValue.ToInt()];
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            this.barEditItem5_EditValueChanged_1(sender, e);
            this.textBox1.Clear();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.barcodeTimer == null)
            {
                this.barcodeTimer = new Timer();
               // this.barcodeTimer = new Timer();
                this.barcodeTimer.Interval = 500;
                this.barcodeTimer.Enabled = true;
                this.barcodeTimer.Tick += TextEditChangeTimer;
            }
            else if (this.barcodeTimer.Enabled == false)
            {
                this.barcodeTimer = new Timer();
                // this.barcodeTimer = new Timer();
                this.barcodeTimer.Interval = 500;
                this.barcodeTimer.Enabled = true;
                this.barcodeTimer.Tick += TextEditChangeTimer;
            }
            //Timer timer = new Timer();
            //timer.Interval = 500;
            //timer.Enabled = true;
            //timer.Tick += TextEditChangeTimer;


        }

        private void TextEditChangeTimer(object sender, EventArgs e)
        {
            this.barcodeTimer.Enabled = false;
            this.barEditItem5_EditValueChanged_1(sender, e);

            this.textBox1.Clear();
        }

        private void RepositoryItemComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            long totalvalue = long.Parse(this.TextBoxTotalCost.EditValue.ToString().Replace(",", "").Trim());
            ComboBoxEdit editor = sender as ComboBoxEdit;
            this.TextBoxTotalCost.EditValue = (totalvalue - (totalvalue * this.discounts[editor.SelectedIndex].Percent.ToInt() / 100)).ToString("#,#");
        }

        private void LoadCustomerMemory()
        {
            this.repositoryItemComboBox2.SelectedValueChanged += RepositoryItemComboBox2_SelectedValueChanged;
        }

        private void RepositoryItemComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            this.GridControlTransactionEntry.DataSource = this.gridControlMemory[this.barEditItem1.EditValue.ToInt()];
        }

        private void GridViewTransactionEntry_RowCountChanged(object sender, EventArgs e)
        {

            GridResults();

        }

        private void GridResults()
        {
            decimal amount = 0;
            decimal totalprice = 0;

            foreach (var item in this.GridViewTransactionEntry.DataSource as List<TransactionEntryModel>)
            {

                amount = amount + item.Amount;
                totalprice = totalprice + (item.Amount * item.SellPrice);

            }
            TextBoxTotalCount.EditValue = amount.ToString();
            TextBoxTotalCost.EditValue = totalprice.Round().ToString("#,#");
            if (!CheckBoxCredit.Checked)
            {
                TextBoxPaid.EditValue = TextBoxTotalCost.EditValue.ToString();
            }
            if (!string.IsNullOrEmpty(TextBoxTotalCost.EditValue.ToString()))
            {
                long d = long.Parse(TextBoxTotalCost.EditValue.ToString().Replace(",", "").Trim());
            }
        }



        public void RefreshDataSource()
        {
            this.GridControlTransactionEntry.RefreshDataSource();
        }
        private void ButtonCustomerSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridControlTransactionEntry.Visible = false;
            CustomerList customerList = new CustomerList();
            customerList.Show();
            customerList.Dock = DockStyle.Fill;
            customerList.BringToFront();
            customerList.GridViewCustomer.Tag = customerList;
            customerList.GridViewCustomer.RowClick += GridViewCustomer_RowClick;
            //PanelControlMainFrame.Controls.Add(customerList);
            panel4.Controls.Add(customerList);
            customerList.Show();
        }
        private void ResetCustomer()
        {
            TextBoxCustomerName.Text = "مشتری متفرقه";
            TextBoxCustomerCode.Text = "01";
            TextBoxCustomerBalance.Text = "0000";
        }

        private void GridViewCustomer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            PersonModel customer = (sender as GridView).GetRow(e.RowHandle) as PersonModel;
            TextBoxCustomerName.Text = customer.Name;
            TextBoxCustomerCode.Text = customer.Code.ToString();
            TextBoxCustomerBalance.Text = customer.Balance.ToString();
            label3.Visible = false;
            GridControlTransactionEntry.Visible = true;
            ((sender as GridView).Tag as CustomerList).Dispose();


        }

        public void SetPage(Form form)
        {
            // GridControlTransactionEntry.Visible = false;
            foreach (var item in this.PanelControlMainFrame.Controls)
            {
                ((System.Windows.Forms.Control)item).Visible = false;
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            PanelControlMainFrame.Controls.Add(form);
        }

        private void ButtonBatchClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // WindowsClient.View.Edit.BatchClose batchClose = new Edit.BatchClose();
            Batch batch = new Settings.Batch();
            batch.Show();
            // this.SetPage(batchClose);
            //  batchClose.ShowInFrame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TextBoxTime.Caption = DateTime.Now.ToLongTimeString();
        }

        private void FillRibbon()
        {
            RibbonControl userRibbon = new RibbonControl();
            if (string.IsNullOrEmpty(this.loggedUserRole.CashierRibbon))
            {
                MessageBox.Show("برای نقش شما نوار میانبر تعریف نشده و از میانبرهای پیش فرض استفاده میشود.جهت شخصی سازی با مدیریت تماس بگیرید");
                this.loggedUserRole.CashierRibbon = this.settings.DefaultRibbon;
                userRibbon = factory.ImportUserRibbon(this.settings.DefaultRibbon);
            }
            else
            {
                userRibbon = factory.ImportUserRibbon(this.loggedUserRole.CashierRibbon);
            }


            this.ribbon.Pages.Clear();
            this.ribbon.Pages.AddRange(userRibbon.Pages.ToArray());
            // this.backstageUserControl1.SetRibbonPages(userRibbon.Pages.ToArray());
        }

        internal void SetUser(UserModel userModel)
        {
            TextBoxCustomerName.Text = userModel.Name;
        }
        internal void SetCustomer(PersonModel customerModel)
        {
            TextBoxCustomerName.Text = customerModel.Name;
        }

        internal void AddItem(ItemModel inventoryItemModel)
        {

            TransactionEntryModel tmp = (GridViewTransactionEntry.DataSource as List<TransactionEntryModel>).Find(x => x.Item == inventoryItemModel.Name);
            if (tmp != null)
            {
                tmp.Amount++;
                tmp.ChangeTransactionType(TransactionTypeSwitch.Caption.Trim());
            }


            else
            {
                TransactionEntryModel transactionEntry = new TransactionEntryModel(itemId: inventoryItemModel.Id, item: inventoryItemModel.Name, transactionType: TransactionTypeSwitch.Caption, sellprice: inventoryItemModel.SellPrice, amount: 1);
                (this.GridViewTransactionEntry.DataSource as List<TransactionEntryModel>).Add(transactionEntry);
            }
            GridResults();
            this.RefreshDataSource();
        }

        internal void AddText()
        {
            throw new NotImplementedException();
        }

        private void barToggleSwitchItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == "    فروش")
            {
                e.Item.Caption = "    خرید";
            }
            else if (e.Item.Caption == "    خرید")
            {
                e.Item.Caption = "    فروش";
            }
        }

        private void barStaticItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            List<TransactionEntryModel> transactions = this.GridViewTransactionEntry.DataSource as List<TransactionEntryModel>;
            foreach (var item in transactions)
            {
                MessageBox.Show(item.TransactionType);
            }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            string x = @"C:\Windows\System32\osk.exe";
            Process.Start(x);
        }

        internal void DoTransaction(PaymentMethodModel paymentTypeModel, BarItem item)
        {
            if (this.GridViewTransactionEntry.RowCount != 0)
            {
                List<TransactionEntryModel> transactionEntries = this.GridViewTransactionEntry.DataSource as List<TransactionEntryModel>;
                List<TransactionEntryModel> entryModels = new List<TransactionEntryModel>();
                entryModels = this.GridControlTransactionEntry.DataSource as List<TransactionEntryModel>;
                TransactionModel cashierTransaction = new TransactionModel(description: "",
                    transactionType: "تراکنش اصلی",
                    io: true,
                    batchRegister: System.Environment.MachineName,
                    batchUser: this.logged.Name,
                    paymentMethod: paymentTypeModel.Title,
                    person: TextBoxCustomerName.Text,
                    totalValue: long.Parse(this.TextBoxTotalCost.EditValue.ToString().Replace(",", "").Trim()),
                    credit: CheckBoxCredit.Checked,
                    paidValue: long.Parse(this.TextBoxPaid.EditValue.ToString().Replace(",", "").Trim()));
                cashierTransaction.SetEntries(entryModels);
                cashierTransaction.Receipts = this.receipts;
                //  TransactionModel cashierTransaction = new TransactionModel(transactionType: new TransactionTypeModel(TextBoxTransactionType.Text), batch: new BatchModel(new RegisterModel(System.Environment.MachineName), logged), paymentMethod: new PaymentMethodModel(paymentTypeModel.Title), person: new PersonModel(long.Parse(TextBoxCustomerCode.Text)), total: Convert.ToDecimal(this.TextBoxTotalCost.EditValue.ToString()), credit: CheckBoxCredit.Checked, items: entryModels, paid: Convert.ToDecimal(TextBoxPaid.EditValue.ToString()));
                string value = "";
                if (this.CheckBoxCredit.Checked)
                {
                    value = TextBoxPaid.EditValue.ToString();
                }
                else
                {
                    value = TextBoxTotalCost.EditValue.ToString();
                }
                item.Enabled = false;
                Timer btnTimer = new Timer();
                //btnTimer.Interval = 5000;
                //btnTimer.Enabled = true;
                //btnTimer.Tag = item;
                //btnTimer.Tick += BtnTimer_Tick;
                //if (this.barEditItem6 == null || string.IsNullOrEmpty(this.barEditItem6.EditValue.ToString()))
               // System.IO.File.WriteAllText("d://transaction.txt", JsonConvert.SerializeObject(cashierTransaction));
                if (this.barEditItem6.EditValue == null || this.barEditItem6.EditValue.ToString() == "")
                {
                    this.PosUnit.Payment(cashierTransaction, this.barEditItem1.EditValue.ToString());
                    this.barEditItem6.EditValue = null;
                }
                else
                {
                    this.PosUnit.Payment(cashierTransaction, this.barEditItem1.EditValue.ToString(), this.TextBoxTotalCost.EditValue.ToString().Replace(",", "").Trim().ToInt());
                    this.barEditItem6.EditValue = null;
                }
                item.Enabled = true;

                // if (cashierTransaction.PaymentMethod != "نقد")
                // {
                //     bool payResult = this.PosUnit.Payment(cashierTransaction);
                //     if (payResult)
                //     {
                //         unitOfWork.Transaction.Insert(cashierTransaction);
                //         this.printUnit.Transaction.Print(cashierTransaction);
                //     }
                //     else
                //     {
                //         MessageBox.Show("خطا در تراکنش");
                //     }
                // }
                // else
                // {
                //     unitOfWork.Transaction.Insert(cashierTransaction);
                //     this.printUnit.Transaction.Print(cashierTransaction);
                // }

                // ResetTransaction();
            }
        }

        private void BtnTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show(((sender as Timer).Tag as BarItem).Caption);
            ((sender as Timer).Tag as BarItem).Enabled = true;
            (sender as Timer).Dispose();
        }

        public void ResetTransaction(string gridMemoryComboValue)
        {
            RefreshGridSource(gridMemoryComboValue);
            this.ResetCustomer();
            SetLastTransaction();
            this.FactorNumberFocus();
            this.barEditItem6.EditValue = string.Empty;
            this.receipts = new List<int>();
        }

        private void SetLastTransaction()
        {
            this.TextBoxLastTransactionValue.Caption = this.unitOfWork.Transaction.LastValue().ToString("#,#");
        }

        private void RefreshGridSource(string gridMemoryComboValue)
        {
            if (this.barEditItem1.EditValue.ToString() == gridMemoryComboValue)
            {
                this.gridControlMemory[gridMemoryComboValue.ToInt()].Clear();
                this.GridControlTransactionEntry.DataSource = new List<TransactionEntryModel>();
                TextBoxTotalCost.EditValue = string.Empty;
                TextBoxTotalCount.EditValue = string.Empty;
                FactorNumberFocus();
                this.ResetCreditCheckout();
            }
            else
            {
                this.gridControlMemory[gridMemoryComboValue.ToInt()].Clear();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridControlTransactionEntry.Visible = false;
            UserList userList = new UserList();
            userList.Dock = DockStyle.Fill;
            userList.BringToFront();
            userList.GridViewUser.Tag = userList;
            userList.GridViewUser.RowClick += GridViewUser_RowClick;
            PanelControlMainFrame.Controls.Add(userList);
            userList.Show();
        }

        private void GridViewUser_RowClick(object sender, RowClickEventArgs e)
        {
            UserModel user = (sender as GridView).GetRow(e.RowHandle) as UserModel;
            TextBoxCustomerName.Text = user.Name;
            TextBoxCustomerCode.Text = user.Code.ToString();
            //TextBoxCustomerBalance.Text = user.Balance.ToString();
            label3.Visible = true;
            GridControlTransactionEntry.Visible = true;
            ((sender as GridView).Tag as UserList).Dispose();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PayoutTransaction payment = new PayoutTransaction();
            payment.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BatchList batchList = new BatchList();
            batchList.Show();
        }



        //private void TextBoxFactorNumber_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (!(string.IsNullOrEmpty(this.factornumber.EditValue.ToString()) && string.IsNullOrWhiteSpace(this.factornumber.EditValue.ToString())))
        //    {
        //        try
        //        {
        //            // List<TransactionEntryModel> tmpEntries = new List<TransactionEntryModel>();
        //            List<TransactionEntryModel> tmpEntries = this.gridControlMemory[Convert.ToInt32(this.barEditItem1.EditValue)];
        //            ReceiptModel receipt = this.unitOfWork.Receipt.Get(factornumber.EditValue.ToString());
        //            if (receipt.Scanned == true)
        //            {

        //                System.Windows.Forms.DialogResult dialogResult = XtraMessageBox.Show(icon: MessageBoxIcon.Warning, caption: "فاکتور تکراری", text: "این فیش قبلا اسکن شده است.مجددا افزوده شود؟", buttons: MessageBoxButtons.YesNo);
        //                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
        //                {

        //                    this.AddTransactionItem(receipt: receipt, gridDataSource: tmpEntries);
        //                }

        //                if (dialogResult == System.Windows.Forms.DialogResult.No)
        //                {

        //                    FactorNumberFocus();
        //                }
        //            }
        //            else
        //            {
        //                this.AddTransactionItem(receipt: receipt, gridDataSource: tmpEntries);
        //            }
        //        }

        //        catch
        //        {

        //            MessageBox.Show("کالا یا فاکتوری با این بارکد ثبت نشده است");
        //            TextBoxFactorNumber.EditValue = string.Empty;
        //            this.FactorNumberFocus();
        //        }
        //    }

        //}

        private void Timer_Tick1(object sender, EventArgs e)
        {
            barEditItem3.Links[0].Focus();
        }

        private void FactorNumberFocus(int interval = 300)
        {
            this.textBox1.Clear();
            Timer timer = new Timer();
            timer.Interval = interval;
            timer.Enabled = true;
            timer.Tick += Timer_Tick;

            //  (TextBoxFactorNumber.Links[0] as DevExpress.XtraBars.BarEditItemLink).ShowEditor();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            //  this.barEditItem5.Links[0].Focus();
            (sender as Timer).Dispose();
        }

        private void AddTransactionItem(ReceiptModel receipt, List<TransactionEntryModel> gridDataSource)
        {
            //if (receipt.Barcode == null)
            //{
            //    ReceiptEntryModel item = this.unitOfWork.Item.GetByBarcode(this.barEditItem5.EditValue.ToString());

            //    ///////////
            //    if ((this.GridControlTransactionEntry.DataSource as List<TransactionEntryModel>).Count == 0)
            //    {
            //        gridDataSource.Add(item.ToTransaction());
            //        this.gridControlMemory[this.barEditItem1.EditValue.ToInt()] = gridDataSource;
            //        this.GridControlTransactionEntry.DataSource = this.gridControlMemory[this.barEditItem1.EditValue.ToInt()];
            //        this.GridControlTransactionEntry.RefreshDataSource();
            //    }
            //    else
            //    {
            //        // gridDataSource.Add(item.ToTransaction());
            //        this.gridControlMemory[this.barEditItem1.EditValue.ToInt()].AddRange(new List<TransactionEntryModel> { item.ToTransaction() });
            //        this.GridControlTransactionEntry.DataSource = this.gridControlMemory[this.barEditItem1.EditValue.ToInt()];
            //        this.GridControlTransactionEntry.RefreshDataSource();
            //    }
            //    this.barEditItem5.EditValue = string.Empty;
            //    this.FactorNumberFocus();
            //    ///////////
            //}
            // else
            //  {
            if (receipt != null)
            {
                gridDataSource = receipt.Entries.ToTransaction();
                if ((this.GridControlTransactionEntry.DataSource as List<TransactionEntryModel>).Count == 0)
                {
                    this.gridControlMemory[this.barEditItem1.EditValue.ToInt()] = gridDataSource;
                    this.GridControlTransactionEntry.DataSource = this.gridControlMemory[this.barEditItem1.EditValue.ToInt()];
                    this.GridControlTransactionEntry.RefreshDataSource();
                }
                else
                {
                    this.gridControlMemory[this.barEditItem1.EditValue.ToInt()].AddRange(gridDataSource);
                    this.GridControlTransactionEntry.DataSource = this.gridControlMemory[this.barEditItem1.EditValue.ToInt()];
                    this.GridControlTransactionEntry.RefreshDataSource();
                }
                this.textBox1.Clear();
                this.FactorNumberFocus();
            }
            //  }
            //if ((this.GridControlTransactionEntry.DataSource as List<TransactionEntryModel>).Count == 0)
            //{
            //    this.gridControlMemory[this.barEditItem1.EditValue.ToInt()] = gridDataSource;
            //    this.GridControlTransactionEntry.DataSource = this.gridControlMemory[this.barEditItem1.EditValue.ToInt()];
            //    this.GridControlTransactionEntry.RefreshDataSource();
            //}
            //else
            //{
            //    this.gridControlMemory[this.barEditItem1.EditValue.ToInt()].AddRange(gridDataSource);
            //    this.GridControlTransactionEntry.DataSource = this.gridControlMemory[this.barEditItem1.EditValue.ToInt()];
            //    this.GridControlTransactionEntry.RefreshDataSource();
            //}
            //this.TextBoxFactorNumber.EditValue = string.Empty;
            //this.FactorNumberFocus();
        }

        private void barToggleSwitchItem1_CheckedChanged_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckBoxCredit.Checked == true)
            {
                TextBoxPaid.Enabled = true;
                TextBoxPaid.EditValue = 0;
                // TextBoxPaid.EditValue = TextBoxTotalCost.EditValue;
            }
            else
            {
                TextBoxPaid.Enabled = false;
                TextBoxPaid.EditValue = 0;
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PaymentEdit payment = new PaymentEdit();
            payment.Show();
        }
        private void ResetCreditCheckout()
        {
            this.CheckBoxCredit.Checked = false;
            this.TextBoxPaid.EditValue = string.Empty;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.RefreshGridSource(this.barEditItem1.EditValue.ToString());
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            View.List.WorkstationReceiptList workstationReceipt = new WorkstationReceiptList();
            workstationReceipt.Show();
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            View.Edit.PersonEdit person = new PersonEdit();
            person.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.ResetCustomer();
        }

        public void SetResultMessage(string message)
        {
            // MessageBox.Show(message);
            this.label4.Text = message;
        }

        private void barEditItem5_EditValueChanged_1(object sender, EventArgs e)
        {

            //if (!(string.IsNullOrEmpty(this.barEditItem5.EditValue.ToString()) && string.IsNullOrWhiteSpace(this.barEditItem5.EditValue.ToString())))
            if (!(string.IsNullOrEmpty(this.textBox1.Text) && string.IsNullOrWhiteSpace(this.textBox1.Text)))
            {
                try
                {
                    // List<TransactionEntryModel> tmpEntries = new List<TransactionEntryModel>();
                    List<TransactionEntryModel> tmpEntries = this.gridControlMemory[Convert.ToInt32(this.barEditItem1.EditValue)];
                    // ReceiptModel receipt = this.unitOfWork.Receipt.Get(barEditItem5.EditValue.ToString());
                    ReceiptModel receipt = this.unitOfWork.Receipt.Get(textBox1.Text);
                    this.receipts.Add(receipt.Id);
                    if (receipt != null && receipt.Scanned == true)
                    {

                        System.Windows.Forms.DialogResult dialogResult = XtraMessageBox.Show(icon: MessageBoxIcon.Warning, caption: "فاکتور تکراری", text: "این فیش قبلا اسکن شده است.مجددا افزوده شود؟", buttons: MessageBoxButtons.YesNo);
                        if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                        {

                            this.AddTransactionItem(receipt: receipt, gridDataSource: tmpEntries);
                        }

                        if (dialogResult == System.Windows.Forms.DialogResult.No)
                        {

                            FactorNumberFocus();
                        }
                    }
                    else
                    {
                        this.AddTransactionItem(receipt: receipt, gridDataSource: tmpEntries);
                    }
                }

                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                    this.textBox1.Clear();
                    this.FactorNumberFocus();
                }
            }

        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            View.List.PayoutTransactionList payoutTransaction = new PayoutTransactionList();
            XtraForm form = new XtraForm();
            form.Size = new Size(800, 500);
            payoutTransaction.Dock = DockStyle.Fill;
            form.Controls.Add(payoutTransaction);
            payoutTransaction.Show();
            form.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}