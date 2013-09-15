// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImageCarousel.ascx.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ImageCarousel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.BootStrapFramework.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class ImageCarousel : UserControl
    {
        public IEnumerable<string> Items { get; set; }

        public int SelectedIndex { get; set; }

        public string SelectedItem
        {
            get
            {
                return Items.ElementAt(SelectedIndex);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SelectedIndex = 0;
        }
    }
}