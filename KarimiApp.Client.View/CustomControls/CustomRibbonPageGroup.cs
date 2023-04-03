// <copyright file="CusstomRibbonPageGroup.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace KarimiApp.Client.View.CustomControls
{
    using DevExpress.XtraBars.Ribbon;
    using System.Windows.Forms;

    /// <summary>
    /// Class CusstomRibbonPageGroup.
    /// Implements the <see cref="DevExpress.XtraBars.Ribbon.RibbonPageGroup" />
    /// </summary>
    /// <seealso cref="DevExpress.XtraBars.Ribbon.RibbonPageGroup" />
    public class CustomRibbonPageGroup : RibbonPageGroup
    {
        private string localImagePath;
        public string ImagePath { get; set; }
        // private CashierMain mainPage=new CashierMain();
        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        /// <value>The image path.</value>
        /// prop        
        // public string ImagePath
        // //{
        ////     get
        ////     {
        //  //       return this.localImagePath;
        //  //   }
        //     set
        //     {
        //        // if(value!=null)
        //         //    this.ImagePath = value.Replace(Application.ExecutablePath.Replace("WindowsClient.exe", ""), "");
        //     }
        // }
    }
}
