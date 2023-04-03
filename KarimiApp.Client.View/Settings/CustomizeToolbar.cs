using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using KarimiApp.Client.Repository;
using KarimiApp.Client.View.CustomControls;
using KarimiApp.Client.View.Edit;
using KarimiApp.Client.View.List;
using KarimiApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ModelFactory = KarimiApp.Client.View.Util.ModelFactory;

namespace KarimiApp.Client.View.Settings
{
    public partial class CustomizeToolbar : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<int, int> styles;
        private Dictionary<int, int> rstyles;
        private CustomBarButtonItem selectedItem;
        private UnitOfWork unitOfWork;
        private ModelFactory factory;
        private CustomRibbonPageGroup selectedGroup;
        private RibbonBarButtonModel BarButtonTmp;
        private ImageSelector hh;
        CustomBarButtonItem tmp;
        private UserRoleEdit userRoleEdit;
        public CustomizeToolbar(UserRoleEdit userr)
        {
            
            this.userRoleEdit = userr;
            selectedItem = new CustomBarButtonItem();
            factory = new ModelFactory();
            styles = new Dictionary<int, int>();
            styles.Add(0, 1);
            styles.Add(1, 2);
            styles.Add(2, 4);
            rstyles = new Dictionary<int, int>();
            rstyles.Add(1, 0);
            rstyles.Add(2, 1);
            rstyles.Add(4, 2);
            InitializeComponent();
            SetButtonTags();
            SetPaymentPageValues();
            this.ComboBoxButtonStyle.SelectedIndex = 0;
            this.ribbonControl1.SelectedPageChanged += RibbonControl1_SelectedPageChanged;
            BarButtonTmp = new RibbonBarButtonModel();
            ComboBoxButtonStyle.SelectedValueChanged += ComboBoxButtonStyle_SelectedValueChanged;
            ribbonControl1.Click += RibbonControl1_Click;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerAsync();
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

        }

        private void SetPaymentPageValues()
        {
            unitOfWork = new UnitOfWork();
            unitOfWork.PaymentMethod.List(this.ComboBoxPaymentType);
        }

        private void SetButtonTags()
        {
            this.ButtonNewItemCategory.Tag = typeof(ItemCategoryEdit);
            this.ButtonNewInventory.Tag = typeof(InventoryEdit);
            this.ButtonItemCategories.Tag = typeof(ItemCategoryList);
            this.ButtonNewWorkStation.Tag = typeof(WorkStationEdit);
            this.ButtonNewCustomer.Tag = typeof(PersonEdit);
            this.ButtonInventories.Tag = typeof(InventoryList);
            this.ButtonNewItem.Tag = typeof(ItemEdit);
            this.ButtonWorkStations.Tag = typeof(WorkStationList);
            this.ButtonCustomers.Tag = typeof(CustomerList);
            this.ButtonItems.Tag = typeof(ItemList);
            this.ButtonDepartments.Tag = typeof(DepartmentList);
            this.ButtonNewUser.Tag = typeof(UserEdit);
            this.ButtonUsers.Tag = typeof(UserList);
        }

        private void RibbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            this.TextBoxEditPageName.Text = this.ribbonControl1.SelectedPage.Text;
        }

        public void FillRibbon(string cashierRibbon)
        {
            RibbonControl userRibbon = new RibbonControl();
            if (string.IsNullOrEmpty(cashierRibbon))
            {
                cashierRibbon = JsonConvert.DeserializeObject<SettingsModel>(File.ReadAllText("Settings/settings.hshk")).DefaultRibbon;
            }
            else
            {
                userRibbon = factory.ImportUserRibbonCustomize(cashierRibbon);
                this.ribbonControl1.Pages.Clear();
                this.ribbonControl1.Pages.AddRange(userRibbon.Pages.ToArray());
            }

        }

        private void ComboBoxButtonStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ComboBoxButtonStyle.SelectedIndex == 0)
            {
                BarButtonTmp.Style = (int)RibbonItemStyles.Large;
            }
            else if (ComboBoxButtonStyle.SelectedIndex == 1)
            {
                BarButtonTmp.Style = (int)RibbonItemStyles.SmallWithoutText;
            }
            else if (ComboBoxButtonStyle.SelectedIndex == 2)
            {
                BarButtonTmp.Style = (int)RibbonItemStyles.SmallWithText;
            }
        }

        private void DefaultTabsAndButtons()
        {
            ButtonNewButton.Text = "افزودن";
            ButtonDeleteButton.Text = "حذف";
            ButtonDeleteButton.Visible = false;
            this.XtraTabPageControl.SelectedTabPage = PageTabs;
            this.PageCustomization.PageVisible = false;
            this.PageFunctions.PageVisible = false;
            this.PagePaymentSelection.PageVisible = false;
            TextBoxPageName.Text = string.Empty;
            TextBoxTextValue.Text = string.Empty;
            TextBoxGroupCaption.Text = string.Empty;
        }
        private void RibbonControl1_Click(object sender, EventArgs e)
        {
            //  e.
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ButtonButtonImage.Enabled = true;
        }

        internal void SetSelectedGroup(CustomRibbonPageGroup customRibbonPageGroup)
        {
            this.selectedGroup = customRibbonPageGroup;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            hh = new ImageSelector();
            // hh.Show();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            var form = ShowInForm(userList);
            userList.GridViewUser.Tag = form;
            userList.GridViewUser.RowClick += GridViewUser_RowClick;
        }

        private XtraForm ShowInForm(XtraUserControl userControl)
        {
            XtraForm form = new XtraForm();
            form.AutoSize = true;
            form.Size = new Size(850, 350);
            userControl.Dock = DockStyle.Fill;
            form.Controls.Add(userControl);
            form.Show();
            return form;
        }

        private void GridViewUser_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridViewGetter<UserModel>(sender, e, ButtonNewButtonUser_Click);
            //UserModel adduser = (sender as GridView).GetRow(e.RowHandle) as UserModel;
            //PageCustomization.PageVisible = true;
            //XtraTabPageControl.SelectedTabPage = PageCustomization;
            //TextBoxCaption.Text = adduser.FirstName + " " + adduser.LastName;
            //this.ButtonNewButton.Tag = adduser;
            //this.ButtonNewButton.Click += ButtonNewButtonUser_Click;
            //this.ButtonNewButton.Text = "اعمال";
            //((UserList)Application.OpenForms["UserList"]).Close();
        }

        public void GridViewGetter<T>(object sender, RowClickEventArgs e, EventHandler newButtonEvent) where T : class, new()
        {
            if (e.Clicks == 2)
            {
                GridView grid = sender as GridView;
                T adduser = grid.GetRow(e.RowHandle) as T;
                PageCustomization.PageVisible = true;
                XtraTabPageControl.SelectedTabPage = PageCustomization;
                this.ButtonNewButton.Tag = adduser;
                this.ButtonNewButton.Click += newButtonEvent;
                this.ButtonNewButton.Text = "اعمال";
                if (adduser.GetType() == typeof(UserModel))

                {
                    TextBoxCaption.Text = (adduser as UserModel).Name ;
                }
                else if (adduser.GetType() == typeof(PersonModel))
                {
                    TextBoxCaption.Text = (adduser as PersonModel).Name ;
                }
                else if (adduser.GetType() == typeof(ItemModel))
                {
                    TextBoxCaption.Text = (adduser as ItemModel).Name;
                }
            (grid.Tag as XtraForm).Dispose();
            }
        }

        private void ButtonNewButtonUser_Click(object sender, EventArgs e)
        {
            UserModel adduser = (sender as Button).Tag as UserModel;
            CustomBarButtonItem userbuttonItem = ExtractObject(adduser, FunctionType.User);
            MessageBox.Show(userbuttonItem.ImagePath);
            userbuttonItem.ItemClick += this.Item_Customize_Click;
            this.selectedGroup.ItemLinks.Add(userbuttonItem);
            MessageBox.Show(((CustomBarButtonItem)(this.selectedGroup.ItemLinks[0].Item)).ImagePath);
            this.DefaultTabsAndButtons();
            ReturnToDefaultTab();
            MessageBox.Show(adduser.Name);
            this.ButtonNewButton.Click -= ButtonNewButtonUser_Click;

        }

        private void ReturnToDefaultTab()
        {
            this.XtraTabPageControl.SelectedTabPage = PageTabs;
            PageCustomization.PageVisible = false;
        }

        private CustomBarButtonItem ExtractObject(object obj, FunctionType functionType)
        {
            CustomBarButtonItem userbuttonItem = new CustomBarButtonItem();
            userbuttonItem.Caption = TextBoxCaption.Text;
            userbuttonItem.RibbonStyle = (RibbonItemStyles)styles[ComboBoxButtonStyle.SelectedIndex];
            userbuttonItem.ImageOptions.Image = PictureBoxButtonImage.Image;
            userbuttonItem.ImagePath = PictureBoxButtonImage.ImageLocation;
            userbuttonItem.Function = new FunctionModel() { Caption = userbuttonItem.Caption, Value = obj, FunctionType = functionType };
            return userbuttonItem;
        }

        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();
            var form = this.ShowInForm(customerList);
            customerList.GridViewCustomer.Tag = form;
            customerList.GridViewCustomer.RowClick += GridViewCustomer_RowClick;
        }

        private void GridViewCustomer_RowClick(object sender, RowClickEventArgs e)
        {
            GridViewGetter<PersonModel>(sender, e, ButtonNewButtonCustomer_Click);
            //CustomerModel addcustomer = (sender as GridView).GetRow(e.RowHandle) as CustomerModel;
            //PageCustomization.PageVisible = true;
            //XtraTabPageControl.SelectedTabPage = PageCustomization;
            //TextBoxCaption.Text = addcustomer.FirstName + " " + addcustomer.LastName;
            //this.ButtonNewButton.Tag = addcustomer;
            //this.ButtonNewButton.Click += ButtonNewButtonCustomer_Click;
            //((CustomerList)Application.OpenForms["CustomerList"]).Close();
        }

        private void ButtonNewButtonCustomer_Click(object sender, EventArgs e)
        {
            PersonModel addcustomer = (sender as Button).Tag as PersonModel;
            CustomBarButtonItem customerrbuttonItem = ExtractObject(addcustomer, FunctionType.Customer);
            customerrbuttonItem.ItemClick += Item_Customize_Click;
            this.selectedGroup.ItemLinks.Add(customerrbuttonItem);
            ReturnToDefaultTab();
            this.ButtonNewButton.Click -= ButtonNewButtonCustomer_Click;
        }


        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            ItemList itemList = new ItemList();
            var form = this.ShowInForm(itemList);
            itemList.GridViewItem.Tag = form;
            itemList.GridViewItem.RowClick += GridViewItem_RowClick;
        }

        private void GridViewItem_RowClick(object sender, RowClickEventArgs e)
        {
            GridViewGetter<ItemModel>(sender, e, ButtonNewButtonItem_Click);
            //InventoryItemModel additem = (sender as GridView).GetRow(e.RowHandle) as InventoryItemModel;
            //PageCustomization.PageVisible = true;
            //XtraTabPageControl.SelectedTabPage = PageCustomization;
            //TextBoxCaption.Text = additem.Name;
            //this.ButtonNewButton.Tag = additem;
            //this.ButtonNewButton.Click += ButtonNewButtonItem_Click;
            //((ItemList)Application.OpenForms["ItemList"]).Close();
        }

        private void ButtonNewButtonItem_Click(object sender, EventArgs e)
        {
            ItemModel addItem = (sender as Button).Tag as ItemModel;
            CustomBarButtonItem itembuttonItem = ExtractItem(addItem);
            itembuttonItem.ItemClick += Item_Customize_Click;
            this.selectedGroup.ItemLinks.Add(itembuttonItem);
            this.XtraTabPageControl.SelectedTabPage = PageTabs;
            PageCustomization.PageVisible = false;
            this.ButtonNewButton.Click -= ButtonNewButtonItem_Click;
        }

        private CustomBarButtonItem ExtractItem(ItemModel addItem)
        {
            CustomBarButtonItem itembuttonItem = new CustomBarButtonItem();
            itembuttonItem.Caption = TextBoxCaption.Text;
            itembuttonItem.ImageOptions.Image = PictureBoxButtonImage.Image;
            itembuttonItem.ImagePath = PictureBoxButtonImage.ImageLocation;
            //string root = Environment.CurrentDirectory;
           // string s = PictureBoxButtonImage.ImageLocation;
           // s.Replace(root,"").Trim();
            //itembuttonItem.ImagePath = s;
            itembuttonItem.RibbonStyle = (RibbonItemStyles)styles[ComboBoxButtonStyle.SelectedIndex];
            itembuttonItem.Function = new FunctionModel() { Caption = itembuttonItem.Caption, Value = addItem, FunctionType = FunctionType.Product };
            return itembuttonItem;
        }

        private CustomBarButtonItem ExtractShortcut(string typename)
        {
            CustomBarButtonItem shortcutitem = new CustomBarButtonItem();
            shortcutitem.Caption = TextBoxCaption.Text;
            shortcutitem.ImageOptions.Image = PictureBoxButtonImage.Image;
            shortcutitem.ImagePath = PictureBoxButtonImage.ImageLocation;
            shortcutitem.RibbonStyle = (RibbonItemStyles)styles[ComboBoxButtonStyle.SelectedIndex];
            shortcutitem.Function = new FunctionModel() { Caption = shortcutitem.Caption, Value = typename, FunctionType = FunctionType.PageShortcut };
            return shortcutitem;
        }

        private void ButtonAddGroup_Click(object sender, EventArgs e)
        {
            CustomRibbonPageGroup tmp = new CustomRibbonPageGroup()
            {
                Text = TextBoxGroupCaption.Text,
            };
            tmp.CaptionButtonClick += Tmp_CaptionButtonClick;
            tmp.ImageOptions.Image = PictureBoxButtonImage.Image;
            tmp.ImagePath = PictureBoxButtonImage.ImageLocation;
            this.ribbonControl1.SelectedPage.Groups.Add(tmp);
            this.DefaultTabsAndButtons();
        }

        public void Tmp_CaptionButtonClick(object sender, RibbonPageGroupEventArgs e)
        {
            selectedGroup = new CustomRibbonPageGroup();
            this.selectedGroup = (sender as CustomRibbonPageGroup);
            this.TextBoxEditGroupName.Text = this.selectedGroup.Text;
        }

        private void ButtonButtonImage_Click(object sender, EventArgs e)
        {
            hh.Show();
            hh.ButtonSelectImage.Click += ButtonSelectImage_Click; ;
        }

        private void ButtonSelectImage_Click(object sender, EventArgs e)
        {
            string path = hh.GetImage();
            PictureBoxButtonImage.Image = Image.FromFile(path);
            PictureBoxButtonImage.ImageLocation = path;
            PictureBoxButtonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            hh.Hide();
        }

        private void ButtonAddPage_Click(object sender, EventArgs e)
        {
            this.ribbonControl1.Pages.Add(new CustomRibbonPage(TextBoxPageName.Text));
            this.DefaultTabsAndButtons();
            // MessageBox.Show((this.ribbonControl1.Pages[0] as CustomRibbonPage).ToString());
        }

        public void Item_Customize_Click(object sender, ItemClickEventArgs e)
        {
            PageCustomization.PageVisible = true;
            XtraTabPageControl.SelectedTabPage = PageCustomization;
            CustomBarButtonItem tmp = e.Item as CustomBarButtonItem;
            TextBoxCaption.Text = tmp.Caption;
            PictureBoxButtonImage.Image = tmp.ImageOptions.Image;
            ComboBoxButtonStyle.Text = ComboBoxButtonStyle.Properties.Items[rstyles[(int)tmp.RibbonStyle]].ToString();
            ButtonDeleteButton.Visible = true;
            ButtonDeleteButton.Tag = tmp;
            //   ButtonNewButton.Click += ButtonNewButton_Click;
            ButtonDeleteButton.Click += ButtonDeleteButton_Click;
            ButtonNewButton.Text = "تغییر";
            ButtonNewButton.Tag = tmp;

        }

        private void ButtonDeleteButton_Click(object sender, EventArgs e)
        {
            (((sender as Button).Tag) as CustomBarButtonItem).Dispose();
            // this.ButtonNewButton.Click -= ButtonNewButton_Click;
            this.DefaultTabsAndButtons();
        }

        private void ButtonAddValue_Click(object sender, EventArgs e)
        {
            PageCustomization.PageVisible = true;
            XtraTabPageControl.SelectedTabPage = PageCustomization;
            this.ButtonNewButton.Click += ButtonNewButtonText_Click;
            TextValueVisible(true);
        }

        private void TextValueVisible(bool state)
        {
            this.label2.Visible = state;
            this.TextBoxTextValue.Visible = state;
        }

        private void ButtonNewButtonText_Click(object sender, EventArgs e)
        {
            CustomBarButtonItem buttonTextButton = ExtractObject(TextBoxTextValue.Text, FunctionType.PredefineValue);
            buttonTextButton.ItemClick += Item_Customize_Click;
            TextValueVisible(false);
            this.selectedGroup.ItemLinks.Add(buttonTextButton);
            this.DefaultTabsAndButtons();
            this.ButtonNewButton.Click -= ButtonNewButtonText_Click;
        }

        private void ButtonSaveRibbon_Click(object sender, EventArgs e)
        {
            this.userRoleEdit.SetToolbar(factory.ExportRibbonToolbar(this.ribbonControl1));
            this.Close();
            // UserSettingsModel userSettings = new UserSettingsModel(((CashierMain)Application.OpenForms["CashierMain"]).logged.UserRole.Id, factory.ExportRibbonToolbar(this.ribbonControl1));
            // unitOfWork.Authentication.UserSettings.Insert(userSettings);
            //SaveFileDialog sfd = new SaveFileDialog();
            //  if (sfd.ShowDialog() == DialogResult.OK)
            //  {
            //    System.IO.File.WriteAllText(sfd.FileName, factory.ExportRibbonToolbar(this.ribbonControl1));
            // }
        }
        public byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                System.IO.File.WriteAllBytes("binary.txt", ms.ToArray());
                return ms.ToArray();

            }

        }
        private void ButtonPageShortcut_Click(object sender, EventArgs e)
        {
            PagePages.PageVisible = true;
            XtraTabPageControl.SelectedTabPage = PagePages;
            // PageButtonsHandler();
            //   PageButtonsHandler(PageButtonsClick);
        }

        private void PageButtonsHandler(System.EventHandler clickMethod)
        {
            ButtonUsers.Click += clickMethod;
            ButtonNewUser.Click += clickMethod;
            ButtonCustomers.Click += clickMethod;
            ButtonNewCustomer.Click += clickMethod;
            ButtonItems.Click += clickMethod;
            ButtonNewItem.Click += clickMethod;
            ButtonItemCategories.Click += clickMethod;
            ButtonNewItemCategory.Click += clickMethod;
            ButtonDepartments.Click += clickMethod;
            ButtonNewDepartment.Click += clickMethod;
            ButtonWorkStations.Click += clickMethod;
            ButtonNewWorkStation.Click += clickMethod;
            ButtonNewWorkStation.Click += clickMethod;
        }

        private void PageButtonsClick(object sender, EventArgs e)
        {
            string type = ((sender as SimpleButton).Tag as Type).FullName;
            // MessageBox.Show(type);
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void PageButtonsHandler()
        {
            ButtonUsers.Click += ButtonUsers_Click;
            ButtonNewUser.Click += ButtonNewUser_Click;
            ButtonCustomers.Click += ButtonCustomers_Click;
            ButtonNewCustomer.Click += ButtonNewCustomer_Click;
            ButtonItems.Click += ButtonItems_Click;
            ButtonNewItem.Click += ButtonNewItem_Click;
            ButtonItemCategories.Click += ButtonItemCategories_Click;
            ButtonNewItemCategory.Click += ButtonNewItemCategory_Click;
            ButtonDepartments.Click += ButtonDepartments_Click;
            ButtonNewDepartment.Click += ButtonNewDepartment_Click;
            ButtonWorkStations.Click += ButtonWorkStations_Click;
            ButtonNewWorkStation.Click += ButtonNewWorkStation_Click;
        }

        private void ButtonNewWorkStation_Click(object sender, EventArgs e)
        {
            string type = typeof(WorkStationEdit).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonNewButton_ClickPageShortcut(object sender, EventArgs e)
        {
            string type = (sender as Button).Tag as string;
            CustomBarButtonItem itembuttonItem = ExtractShortcut(type);
            itembuttonItem.ItemClick += Item_Customize_Click;
            MessageBox.Show("x");
            this.selectedGroup.ItemLinks.Add(itembuttonItem);
            this.XtraTabPageControl.SelectedTabPage = PageCustomization;
            PageCustomization.PageVisible = true;
            this.DefaultTabsAndButtons();
            this.ButtonNewButton.Click -= ButtonNewButton_ClickPageShortcut;
        }

        private void PagesTransformation(string title, XtraTabPage firstpage)
        {
            firstpage.PageVisible = false;
            PageCustomization.PageVisible = true;
            XtraTabPageControl.SelectedTabPage = PageCustomization;
            TextBoxCaption.Text = title;
        }

        private void ButtonWorkStations_Click(object sender, EventArgs e)
        {
            string type = typeof(WorkStationList).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonNewDepartment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            string type = typeof(DepartmentEdit).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonDepartments_Click(object sender, EventArgs e)
        {
            string type = typeof(DepartmentList).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonNewItemCategory_Click(object sender, EventArgs e)
        {
            string type = typeof(ItemCategoryEdit).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonItemCategories_Click(object sender, EventArgs e)
        {
            string type = typeof(ItemCategoryList).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonNewItem_Click(object sender, EventArgs e)
        {
            string type = typeof(ItemEdit).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonItems_Click(object sender, EventArgs e)
        {
            string type = typeof(ItemList).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonNewCustomer_Click(object sender, EventArgs e)
        {
            string type = typeof(CustomerList).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonCustomers_Click(object sender, EventArgs e)
        {
            string type = typeof(CustomerList).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonNewUser_Click(object sender, EventArgs e)
        {
            string type = typeof(UserEdit).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            string type = typeof(UserList).ToString();
            PagesTransformation((sender as SimpleButton).Text, PagePages);
            ButtonNewButton.Tag = type;
            ButtonNewButton.Click += ButtonNewButton_ClickPageShortcut;
        }

        private void ButtonDeleteGroup_Click(object sender, EventArgs e)
        {
            this.selectedGroup.Dispose();
        }

        private void ButtonDeletePage_Click(object sender, EventArgs e)
        {
            this.ribbonControl1.SelectedPage.Dispose();
        }

        private void ButtonRenamePage_Click(object sender, EventArgs e)
        {
            this.ribbonControl1.SelectedPage.Text = this.TextBoxEditPageName.Text;
        }

        private void ButtonRenameGroup_Click(object sender, EventArgs e)
        {
            this.selectedGroup.Text = this.TextBoxEditGroupName.Text;
        }

        private void ButtonAddFunction_Click(object sender, EventArgs e)
        {
            this.PageFunctions.PageVisible = true;
            this.XtraTabPageControl.SelectedTabPage = this.PageFunctions;

        }

        private void PaymentShortcut_Click(object sender, EventArgs e)
        {
            this.PagePaymentSelection.PageVisible = true;
            this.XtraTabPageControl.SelectedTabPage = this.PagePaymentSelection;
        }

        private void ButtonPaymentCancel_Click(object sender, EventArgs e)
        {
            this.DefaultTabsAndButtons();
        }

        private void ButtonPaymentSubmit_Click(object sender, EventArgs e)
        {
            this.PagesTransformation(ComboBoxPaymentType.Text, this.PagePaymentSelection);
            string typemethods = ComboBoxPaymentType.Text;
            ButtonNewButton.Tag = typemethods;
            this.ButtonNewButton.Click += ButtonNewButton_ClickPaymentShortcut;

        }

        private void ButtonNewButton_ClickPaymentShortcut(object sender, EventArgs e)
        {
            if (this.selectedGroup == null)
            {
                MessageBox.Show("گروهی انتخاب نشده است");
            }
            else
            {
                string typeMethod = (sender as Button).Tag as string;
                CustomBarButtonItem itembuttonItem = ExtractPaymentShortcut(typeMethod);
                itembuttonItem.ItemClick += Item_Customize_Click;
                this.selectedGroup.ItemLinks.Add(itembuttonItem);
                this.XtraTabPageControl.SelectedTabPage = PageCustomization;
                PageCustomization.PageVisible = true;
                this.DefaultTabsAndButtons();
                this.ButtonNewButton.Click -= ButtonNewButton_ClickPaymentShortcut;
            }
           
        }

        private CustomBarButtonItem ExtractPaymentShortcut(string type)
        {
            PictureBox pictureBox = new PictureBox();
            CustomBarButtonItem shortcutitem = new CustomBarButtonItem();
            shortcutitem.Caption = TextBoxCaption.Text;
            shortcutitem.ImageOptions.Image = PictureBoxButtonImage.Image;
            shortcutitem.ImagePath = PictureBoxButtonImage.ImageLocation;
            shortcutitem.RibbonStyle = (RibbonItemStyles)styles[ComboBoxButtonStyle.SelectedIndex];
            shortcutitem.Function = new FunctionModel() { Caption = shortcutitem.Caption, Value = type, FunctionType = FunctionType.PaymentShortcut };
            return shortcutitem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CustomToolbarModel tmp = JsonConvert.DeserializeObject<CustomToolbarModel>(System.IO.File.ReadAllText("rin=bbon.txt"));
            string s = this.factory.ExportRibbonToolbar(this.ribbonControl1);
            // MessageBox.Show(tmp.Pages.Count.ToString());
        }
    }
}
