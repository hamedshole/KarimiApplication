// <copyright file="ModelFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using KarimiApp.Client.View.CustomControls;
using KarimiApp.Model;
using Newtonsoft.Json;
using KarimiApp.Client.View.Settings;

namespace KarimiApp.Client.View.Util
{
    public class ModelFactory
    {

        /// <summary>
        /// extract ribboncontrol from user's settings.
        /// </summary>
        /// <param name="userSettings"></param>
        /// <returns></returns>
        public RibbonControl ImportUserRibbon(string cashierRibbon)
        {
            CustomToolbarModel customToolbar = JsonConvert.DeserializeObject<CustomToolbarModel>(cashierRibbon);
            return this.ImportRibbon(customToolbar);
        }

        public RibbonControl ImportUserRibbonCustomize(string cashierRibbon)
        {
            CustomToolbarModel customToolbar = JsonConvert.DeserializeObject<CustomToolbarModel>(cashierRibbon);
            //  return this.ImportRibbonCustomize(userSettings.CashierRibbonValue);
            return this.ImportRibbonCustomize(customToolbar);
        }

        public RibbonControl ImportRibbonCustomize(CustomToolbarModel customToolbar)
        {
            RibbonControl ribbon = new RibbonControl();
            foreach (RibbonPageModel page in customToolbar.Pages)
            {
                ribbon.Pages.Add(this.ImportCustomRibbonPageCustomize(page));
            }

            return ribbon;
        }

        private CustomRibbonPage ImportCustomRibbonPageCustomize(RibbonPageModel page)
        {
            CustomRibbonPage customRibbonPage = new CustomRibbonPage();
            customRibbonPage.Text = page.Caption;
            foreach (RibbonPageGroupModel group in page.Groups)
            {
                customRibbonPage.Groups.Add(this.ImportCustomRibbonPageGroupCustomize(group));
            }

            return customRibbonPage;
        }

        private CustomRibbonPageGroup ImportCustomRibbonPageGroupCustomize(RibbonPageGroupModel group)
        {
            CustomRibbonPageGroup ribbonPageGroup = new CustomRibbonPageGroup();
            if (group.Image == null)
            {
                ribbonPageGroup.ImageOptions.Image = null;
            }
            else
            {
                ribbonPageGroup.ImagePath = group.Image;
                ribbonPageGroup.ImageOptions.Image = Image.FromFile(group.Image);
            }

            ribbonPageGroup.ImagePath = group.Image;
            ribbonPageGroup.Text = group.Caption;
            ribbonPageGroup.CaptionButtonClick += RibbonPageGroup_CaptionButtonClick_Customize;
            foreach (RibbonBarButtonModel item in group.Items)
            {
                ribbonPageGroup.ItemLinks.Add(this.ImportRibbonBarButtonItemCustomize(item));
            }
            return ribbonPageGroup;
        }

        private void RibbonPageGroup_CaptionButtonClick_Customize(object sender, RibbonPageGroupEventArgs e)
        {

               (Application.OpenForms["CustomizeToolbar"] as CustomizeToolbar).Tmp_CaptionButtonClick(sender, e);
         // ((CashierMain)Application.OpenForms["CashierMain"]).AccessToToolbar().Tmp_CaptionButtonClick(sender,e);
            //  (((((Application.OpenForms["CashierMain"]) as CashierMain).Controls["AdminPage"]) as AdminPage).Controls["CustomizeToolbar"] as CustomizeToolbar).Tmp_CaptionButtonClick(sender,e);
        }

        private CustomBarButtonItem ImportRibbonBarButtonItemCustomize(RibbonBarButtonModel item)
        {
            CustomBarButtonItem barButton = new CustomBarButtonItem();
            barButton.ItemClick += BarButton_ItemClick_Customize;
            barButton.Caption = item.Caption;
            if (item.Image == null)
            {
                barButton.ImageOptions.Image = null;
            }
            else
            {
                barButton.ImagePath = item.Image;
                barButton.ImageOptions.Image = Image.FromFile(item.Image);
            }

            barButton.RibbonStyle = (RibbonItemStyles)item.Style;
            barButton.Hint = item.Hint;
            barButton.Function = item.Function;
            return barButton;
        }

        private void BarButton_ItemClick_Customize(object sender, ItemClickEventArgs e)
        {
            CustomizeToolbar ct = Application.OpenForms["CustomizeToolbar"] as CustomizeToolbar;
            ct.Item_Customize_Click(sender, e);
          // ((CashierMain)Application.OpenForms["CashierMain"]).AccessToToolbar().Item_Customize_Click(sender, e);
        }

        /// <summary>
        /// get customtoolbarmodel and convert it to ribbon control.
        /// </summary>
        /// <param name="customToolbar"></param>
        /// <returns></returns>
        public RibbonControl ImportRibbon(CustomToolbarModel customToolbar)
        {
            RibbonControl ribbon = new RibbonControl();
            foreach (RibbonPageModel page in customToolbar.Pages)
            {
                ribbon.Pages.Add(this.ImportCustomRibbonPage(page));
            }

            return ribbon;
        }

        /// <summary>
        /// get ribbon page model and convert it to customribbon pagew
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        private CustomRibbonPage ImportCustomRibbonPage(RibbonPageModel page)
        {
            CustomRibbonPage customRibbonPage = new CustomRibbonPage();
            customRibbonPage.Text = page.Caption;
            foreach (RibbonPageGroupModel group in page.Groups)
            {
                customRibbonPage.Groups.Add(this.ImportCustomRibbonPageGroup(group));
            }

            return customRibbonPage;
        }

        private CustomRibbonPageGroup ImportCustomRibbonPageGroup(RibbonPageGroupModel group)
        {
            CustomRibbonPageGroup ribbonPageGroup = new CustomRibbonPageGroup();
            if (group.Image == null)
            {
                ribbonPageGroup.ImageOptions.Image = null;
            }
            else
            {
                ribbonPageGroup.ImagePath = group.Image;
                ribbonPageGroup.ImageOptions.Image = Image.FromFile(group.Image);
            }
           
            ribbonPageGroup.ImagePath = group.Image;
            ribbonPageGroup.Text = group.Caption;
            foreach (RibbonBarButtonModel item in group.Items)
            {
                ribbonPageGroup.ItemLinks.Add(this.ImportRibbonBarButtonItem(item));
            }
            return ribbonPageGroup;
        }

        private CustomBarButtonItem ImportRibbonBarButtonItem(RibbonBarButtonModel item)
        {
            CustomBarButtonItem barButton = new CustomBarButtonItem();
            barButton.ItemClick += BarButton_ItemClick;
            barButton.Caption = item.Caption;
            if (item.Image == null)
            {
                barButton.ImageOptions.Image = null;
            }
            else
            {
                barButton.ImagePath = item.Image;
                barButton.ImageOptions.Image = Image.FromFile(item.Image);
            }

            barButton.RibbonStyle = (RibbonItemStyles)item.Style;
            barButton.Hint = item.Hint;
            barButton.Function = item.Function;
            return barButton;
        }

        private void BarButton_ItemClick(object sender, ItemClickEventArgs e)
        {

            e.Item.ItemClickFireMode = BarItemEventFireMode.Immediate;
            CustomBarButtonItem item = e.Item as CustomBarButtonItem;
            if (item.Function.FunctionType == FunctionType.User)
            {
                (Application.OpenForms["CashierMain"] as CashierMain).SetUser(JsonConvert.DeserializeObject<UserModel>( item.Function.Value.ToString()));
            }
            else if (item.Function.FunctionType == FunctionType.Customer)
            {
                (Application.OpenForms["CashierMain"] as CashierMain).SetCustomer(JsonConvert.DeserializeObject<PersonModel>( item.Function.Value.ToString()));
            }
            else if (item.Function.FunctionType == FunctionType.Product)
            {
                (Application.OpenForms["CashierMain"] as CashierMain).AddItem(JsonConvert.DeserializeObject<ItemModel>(item.Function.Value.ToString()));
            }
            else if (item.Function.FunctionType == FunctionType.PredefineValue)
            {
               // (Application.OpenForms["CashierMain"]as CashierMain).AddText()
            }
            else if (item.Function.FunctionType == FunctionType.PageShortcut)
            {
                object form = new object();
                string type = item.Function.Value as string;
                var x = Type.GetType(type);
                if (x.FullName[19] == 'L')
                {
                   // Permission permission = ((CashierMain)Application.OpenForms["CashierMain"]).logged.Permissions.Find(y => y.Name == x.Name.Replace("List", ""));
                    if (Application.OpenForms[x.Name] == null)
                    {
                        
                       // form = Activator.CreateInstance(x,permission);
                    }
                    else
                    {
                        form = Application.OpenForms[x.Name];
                    }
                }
                else if(x.FullName[19] == 'E')
                {
                    if (Application.OpenForms[x.Name] == null)
                    {

                        form = Activator.CreateInstance(x);
                    }
                    else
                    {
                        form = Application.OpenForms[x.Name];
                    }
                }
                (form as Form).Show();
            }
            else if (item.Function.FunctionType == FunctionType.PaymentShortcut)
            {
                string typeMethod = item.Function.Value.ToString();
               
                ((CashierMain)Application.OpenForms["CashierMain"]).DoTransaction(new PaymentMethodModel (typeMethod), e.Item);
                
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            ((sender as Timer).Tag as CustomBarButtonItem).Enabled = true;
        }


        /// <summary>
        /// Get Ribbon control and convert it to CustomToolbarModel to save it as string.
        /// </summary>
        /// <param name="ribbon"></param>
        /// <returns></returns>
        private CustomToolbarModel ExportRibbonControl(RibbonControl ribbon)
        {
            CustomToolbarModel toolbarTmp = new CustomToolbarModel();
            toolbarTmp.Pages = new List<RibbonPageModel>();
            toolbarTmp.Caption = ribbon.Name;
            foreach (var page in ribbon.Pages)
            {
               // System.Windows.Forms.MessageBox.Show(page.GetType().ToString());
                toolbarTmp.Pages.Add(this.ExportRibbonPage(page as RibbonPage));
            }
            return toolbarTmp;
        }

        public string ExportRibbonToolbar(RibbonControl ribbon)
        {
            return JsonConvert.SerializeObject(this.ExportRibbonControl(ribbon));
        }

        /// <summary>
        /// get customRibbonPage from RibbonControl's pages collection and convert it to RibbonPageModel to save it as string.
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        private RibbonPageModel ExportRibbonPage(RibbonPage page)
        {
            RibbonPageModel ribbonPage = new RibbonPageModel();
            ribbonPage.Groups = new List<RibbonPageGroupModel>();
            ribbonPage.Caption = page.Text;
            foreach (CustomRibbonPageGroup group in page.Groups)
            {
                ribbonPage.Groups.Add(this.ExportRibbonPageGroup(group));
            }
            return ribbonPage;
        }

        /// <summary>
        /// get customRibbonPageGroup from ribbonPage's ribbonpagegroup collection and convert it to RibbonPageGroupModel to save it as string.
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        private RibbonPageGroupModel ExportRibbonPageGroup(CustomRibbonPageGroup group)
        {
            RibbonPageGroupModel ribbonPageGroup = new RibbonPageGroupModel();
            ribbonPageGroup.Items = new List<RibbonBarButtonModel>();
            ribbonPageGroup.Caption = group.Text;
            ribbonPageGroup.Image = group.ImagePath;
            foreach (BarButtonItemLink itemLink in group.ItemLinks)
            {
                ribbonPageGroup.Items.Add(this.ExportRibbonItem(itemLink));
            }
            return ribbonPageGroup;
        }
        /// <summary>
        /// get itemLink from ribbonpagegroup itemlink collection.use item in item link and convert it to ribbon bar button model to save it as string.
        /// </summary>
        /// <param name="itemLink"></param>
        /// <returns></returns>
        private RibbonBarButtonModel ExportRibbonItem(BarButtonItemLink itemLink)
        {
            RibbonBarButtonModel ribbonBarButton = new RibbonBarButtonModel();
            CustomBarButtonItem customBarButton = itemLink.Item as CustomBarButtonItem;
            ribbonBarButton.Caption = customBarButton.Caption;
            ribbonBarButton.Hint = customBarButton.Hint;
            ribbonBarButton.Style = (int)customBarButton.RibbonStyle;
            ribbonBarButton.Image = customBarButton.ImagePath;
            ribbonBarButton.Function = customBarButton.Function;
            return ribbonBarButton;
        }
    }
}
