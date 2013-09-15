using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootStrapFramework.Extensions
{
    using System.IO;
    using System.Linq.Expressions;
    using System.Text;
    using System.Web.Mvc;
    using System.Web.UI;

    using MakeBeauty.BootStrapFramework.Controls;

    public static class ImageCarouselExtensions
    {
        public static MvcHtmlString ImageCarouselFor<TModel, TProperty>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TProperty>> expression)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            var control = new ViewPage().LoadControl("~/BootStrapFramework/Controls/ImageCarousel.ascx") as ImageCarousel;

            if (control != null)
            {
                control.Items = metadata.Model as IEnumerable<string>;

                var controlString = RenderControl(control);

                return MvcHtmlString.Create(controlString);
            }

            return MvcHtmlString.Empty;
        }

        public static string RenderControl(Control ctrl)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter tw = new StringWriter(sb);
            HtmlTextWriter hw = new HtmlTextWriter(tw);

            ctrl.RenderControl(hw);
            return sb.ToString();
        }

    }
}