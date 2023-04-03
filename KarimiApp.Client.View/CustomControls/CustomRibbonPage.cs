// <copyright file="CustomRibbonPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace KarimiApp.Client.View.CustomControls
{
    using DevExpress.XtraBars.Ribbon;

    /// <summary>
    /// Class CustomRibbonPage.
    /// Implements the <see cref="DevExpress.XtraBars.Ribbon.RibbonPage" />
    /// </summary>
    /// <seealso cref="DevExpress.XtraBars.Ribbon.RibbonPage" />
    public class CustomRibbonPage : RibbonPage
    {
        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        /// <value>The image path.</value>
        public string ImagePath { get; set; }

        public CustomRibbonPage(string name):base(name)
        {
        }

        public CustomRibbonPage()
        {
        }
    }

}
