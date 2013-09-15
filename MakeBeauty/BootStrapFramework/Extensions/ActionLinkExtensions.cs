namespace BootStrapFramework.Extensions
{
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Xml.Serialization;

    using global::BootStrapFramework.Extensions;

    public static class ActionLinkExtensions
    {
        public static MvcHtmlString BootStrapActionLink(
             this HtmlHelper htmlHelper,
             string linkText,
             string actionName,
             ButtonStyle type,
             ButtonSize size)
        {
            return htmlHelper.BootStrapActionLink(linkText, actionName, type, size, new RouteValueDictionary());
        }

        public static MvcHtmlString BootStrapActionLink(
            this HtmlHelper htmlHelper,
            string linkText,
            string actionName,
            ButtonStyle type,
            ButtonSize size,
            object routeValues)
        {
            var actionClass = "btn " + type.GetAttribute<XmlEnumAttribute>().Name + " "
                              + size.GetAttribute<XmlEnumAttribute>().Name;

            return htmlHelper.ActionLink(linkText, actionName, routeValues, new { @class = actionClass });
        }

        public static MvcHtmlString BootStrapActionLink(
             this HtmlHelper htmlHelper,
             string linkText,
             string actionName,
             string controllerName,
             ButtonStyle type,
             ButtonSize size,
             object routeValues)
        {
            var actionClass = "btn " + type.GetAttribute<XmlEnumAttribute>().Name + " "
                              + size.GetAttribute<XmlEnumAttribute>().Name;

            return htmlHelper.ActionLink(linkText, actionName, controllerName, routeValues, new { @class = actionClass });
        }
    }
}