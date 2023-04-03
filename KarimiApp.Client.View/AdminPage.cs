using DevExpress.XtraEditors;
using KarimiApp.Client.View.Edit;
using KarimiApp.Client.View.List;
using KarimiApp.Client.View.Settings.AdminPanelControls;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace KarimiApp.Client.View
{
    public partial class AdminPage : XtraForm
    {
        private Uri baseAddress;

        public AdminPage()
        {
            this.baseAddress = new Uri("https://localhost:44346/");
            
            InitializeComponent();
            //label1.Text = DateTime.Now.ToLongDateString();
           // label2.Text = DateTime.Now.ToLongTimeString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            try
            {
               HttpResponseMessage response = await client.GetAsync("https://localhost:44311/api/values");
                
                //response.EnsureSuccessStatusCode();
                //  Exceptions.ExceptionResponse responseBody = await response.Content.ReadAsAsync<Exceptions.ExceptionResponse>();
                //MessageBox.Show(response.StatusCode.ToString());
                MessageBox.Show(await response.Content.ReadAsStringAsync(),response.ReasonPhrase);
                //MessageBox.Show(response.ReasonPhrase);
               // MessageBox.Show(responseBody.ExceptionMessage);
                // throw new Exceptions.UserNotFoundException();
                // Above three lines can be replaced with new helper method below 
                // string responseBody = await client.GetStringAsync(uri);

                //Console.WriteLine(responseBody);
            }
            catch ( Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }

        private void navigationPane1_Click(object sender, EventArgs e)
        {

        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccordionControlInventory_Click(object sender, EventArgs e)
        {
          InventoryList inventory = new InventoryList();
            AddToInventoryPanel(inventory);
        }

        private void AddToInventoryPanel(XtraUserControl usercontrol)
        {
            this.PanelInventory.Controls.Clear();
            usercontrol.Dock = DockStyle.Fill;
            this.PanelInventory.Controls.Add(usercontrol);
        }
        private void AddToUserPanel(XtraUserControl usercontrol)
        {
            this.PanelUserManagement.Controls.Clear();
            usercontrol.Dock = DockStyle.Fill;
            this.PanelUserManagement.Controls.Add(usercontrol);
        }
        private void AddToCustomerPanel(XtraUserControl usercontrol)
        {
            this.panel1.Controls.Clear();
            usercontrol.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(usercontrol);
        }
        private void AddToAccountingPanel(XtraUserControl usercontrol)
        {
            this.PanelAccounting.Controls.Clear();
            usercontrol.Dock = DockStyle.Fill;
            this.PanelAccounting.Controls.Add(usercontrol);
        }
        private void AddToSettingsPanel(XtraUserControl usercontrol)
        {
            this.PanelSettings.Controls.Clear();
            usercontrol.Dock = DockStyle.Fill;
            this.PanelSettings.Controls.Add(usercontrol);
        }

        private void AccordionControlInventoryNew_Click(object sender, EventArgs e)
        {
            InventoryEdit inventory = new InventoryEdit();
            inventory.Show();
            inventory.Focus();
        }

        private void AccordionControlInventoryCategory_Click(object sender, EventArgs e)
        {
           InventoryTypeList inventoryType = new InventoryTypeList();
            this.AddToInventoryPanel(inventoryType);
        }

        private void AccordionControlInventoryCategoryNew_Click(object sender, EventArgs e)
        {
          InventoryTypeEdit inventoryType = new InventoryTypeEdit();
            inventoryType.Show();
        }

        private void AccordionControlDepartment_Click(object sender, EventArgs e)
        {
            DepartmentList departmentList = new DepartmentList();
            this.AddToInventoryPanel(departmentList);
        }

        private void AccordionControlDepartmentNew_Click(object sender, EventArgs e)
        {
            DepartmentEdit departmentEdit = new DepartmentEdit();
            departmentEdit.Show();
        }

        private void AccordionControlItem_Click(object sender, EventArgs e)
        {
            ItemList itemList = new ItemList();
            this.AddToInventoryPanel(itemList);
        }

        private void AccordionControlItemNew_Click(object sender, EventArgs e)
        {
            ItemEdit itemEdit = new ItemEdit();
            itemEdit.Show();
        }

        private void AccordionControlItemCategory_Click(object sender, EventArgs e)
        {
          ItemCategoryList itemCategoryList = new ItemCategoryList();
            this.AddToInventoryPanel(itemCategoryList);
        }

        private void AccordionControlItemCategoryNew_Click(object sender, EventArgs e)
        {
           ItemCategoryEdit itemCategoryEdit = new ItemCategoryEdit();
            itemCategoryEdit.Show();
        }

        private void AccordionControlWorkStation_Click(object sender, EventArgs e)
        {
            WorkStationList workStationList = new WorkStationList();
            this.AddToInventoryPanel(workStationList);
        }

        private void AccordionControlWorkStationNew_Click(object sender, EventArgs e)
        {
           WorkStationEdit workStationEdit = new WorkStationEdit();
            workStationEdit.Show();
        }

        private void AccordionControlPaymentTypeList_Click(object sender, EventArgs e)
        {
           PaymentTypeList paymentTypeList = new PaymentTypeList();
            this.AddToAccountingPanel(paymentTypeList);
        }

        private void accordionControlPaymentTypeNew_Click(object sender, EventArgs e)
        {
          PaymentTypeEdit paymentTypeEdit = new PaymentTypeEdit();
            paymentTypeEdit.Show();
        }

        private void AccordionControlUserList_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            this.AddToUserPanel(userList);
        }

        private void AccordionControlUserNew_Click(object sender, EventArgs e)
        {
           UserEdit userEdit = new UserEdit();
            userEdit.Show();
        }

        private void AccordionControlUserRoleNew_Click(object sender, EventArgs e)
        {
           UserRoleEdit userRoleEdit = new UserRoleEdit();
            userRoleEdit.Show();
        }

        private void AccordionControlUserRoleList_Click(object sender, EventArgs e)
        {
           UserRoleList userRole = new UserRoleList();
            this.AddToUserPanel(userRole);
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
           // stireport
        }

        private void AccordionControlToolbar_Click(object sender, EventArgs e)
        {
          //  View.Settings.CustomizeToolbar customizeToolbar = new View.Settings.CustomizeToolbar();
          //  customizeToolbar.FillRibbon(((CashierMain)Application.OpenForms["CashierMain"]).UserSettings);
        //    MessageBox.Show(customizeToolbar.Name);
         //   this.AddToSettingsPanel(customizeToolbar);
        }

        private void accordionControlElement26_Click(object sender, EventArgs e)
        {
            PayoutTransaction payOut = new PayoutTransaction();
            payOut.Show();
        }

        private void accordionControlPayoutTransaction_Click(object sender, EventArgs e)
        {
            View.List.PayoutTransactionList payoutList = new PayoutTransactionList();
            this.AddToAccountingPanel(payoutList);
        }

        private void accordionControlPaymentMethodList_Click(object sender, EventArgs e)
        {
            View.List.PaymentMethodList paymentMethodList = new PaymentMethodList();
            this.AddToAccountingPanel(paymentMethodList);
        }

        private void accordionControlPersonList_Click(object sender, EventArgs e)
        {
            View.List.CustomerList customerList = new CustomerList();
            this.AddToCustomerPanel(customerList);
        }

        private void accordionControlPictureSelector_Click(object sender, EventArgs e)
        {
            PictureSelector pictureSelector = new PictureSelector();
            this.AddToSettingsPanel(pictureSelector);
        }

        private void accordionControlPaymentMethodEdit_Click(object sender, EventArgs e)
        {
            PaymentMethodEdit paymentMethodEdit = new PaymentMethodEdit();
            paymentMethodEdit.Show();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            RegisterEdit registerEdit = new RegisterEdit();
            registerEdit.Show();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            RegisterList registerList = new RegisterList();
            this.AddToUserPanel(registerList);
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            PosInfoList posInfoList = new PosInfoList();
            this.AddToAccountingPanel(posInfoList);
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            PersonEdit personEdit = new PersonEdit();
            personEdit.Show();
        }

        private void accordionControlPersonCredits_Click(object sender, EventArgs e)
        {
            View.List.PersonCreditsList personCredits = new PersonCreditsList();
            this.AddToAccountingPanel(personCredits);
        }

        private void accordionControlElement28_Click(object sender, EventArgs e)
        {
            View.Edit.AddInventoryItemDetail addInventoryItem = new AddInventoryItemDetail();
            addInventoryItem.Show();
        }
    }
}
