// <copyright file="BarButtonItem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace KarimiApp.Client.View.CustomControls
{
    using DevExpress.XtraBars;
    using KarimiApp.Model;

    /// <summary>
    /// Class CustomBarButtonItem.
    /// Implements the <see cref="DevExpress.XtraBars.BarButtonItem" />.
    /// </summary>
    /// <seealso cref="DevExpress.XtraBars.BarButtonItem" />
    public class CustomBarButtonItem : BarButtonItem
    {
        private string localImagePath;
        public string ImagePath { get; set; }
        // private CashierMain mainPage=new CashierMain();
        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        /// <value>The image path.</value>
        //public string ImagePath {
        //    get
        //    {
        //        return this.localImagePath;
        //    }
        //    set
        //    { 
        //      //  this.ImagePath= value.Replace(Application.ExecutablePath.Replace("WindowsClient.exe", ""), "");
        //    }
        //}

        public FunctionModel Function { get; set; }

        public CustomBarButtonItem()
        {
           // this.ItemClick += CustomBarButtonItem_ItemClick;
        }

        //private void CustomBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //   CashierMain mainpage = (CashierMain)Application.OpenForms["CashierMain"];
        //    if (Function.FunctionType == FunctionType.Customer)
        //    {
        //        CustomerModel customer = (Function.Value as CustomerModel);
        //        mainpage.TextBoxCustomerName.Text = customer.FirstName + " " + customer.LastName;
        //    }

        //    else if (Function.FunctionType == FunctionType.User)
        //    {
        //        UserModel user = (Function.Value as UserModel);
        //        mainpage.TextBoxCustomerName.Text = user.FirstName + " " + user.LastName;
        //    }

        //    else if (Function.FunctionType == FunctionType.Product)
        //    {
        //        InventoryItemModel item = (Function.Value as InventoryItemModel);
        //        mainpage.gridSource.Add(new TransactionEntryModel { Item=item,Quantity=1});
        //        mainpage.RefreshDataSource();
        //    }

        //    else if (Function.FunctionType == FunctionType.PredefineValue)
        //    {
        //        string s = Function.Value as string;
        //    }

        //    else if (Function.FunctionType == FunctionType.WebLink)
        //    {
        //        string link = Function.Value as string;
        //    }

        //    else if (Function.FunctionType == FunctionType.PageShortcut)
        //    {
        //        Form page = Function.Value as Form;
        //    }

        //    else if (Function.FunctionType == FunctionType.ActionShortcut)
        //    {
        //        string s = Function.Value as string;
        //        mainpage.GetType().GetMethod(s);
        //    }
            
        //}

        
    }
}
