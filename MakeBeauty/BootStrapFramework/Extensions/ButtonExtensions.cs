namespace BootStrapFramework.Extensions
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Xml.Serialization;

    public static class ButtonExtensions
    {
        public static MvcHtmlString BootStrapSubmitButton(
            this HtmlHelper html,
            string text,
            ButtonStyle type,
            ButtonSize size)
        {
            return html.BootStrapSubmitButton(text, type, size, new { });
        }


        public static MvcHtmlString BootStrapSubmitButton(
            this HtmlHelper html,
            string text,
            ButtonStyle type,
            ButtonSize size,
            object routeValues)
        {
            var buttonClass = "btn " + type.GetAttribute<XmlEnumAttribute>().Name + " "
                            + size.GetAttribute<XmlEnumAttribute>().Name;

            var builder = new TagBuilder("input");

            builder.Attributes.Add("type", "submit");

            builder.Attributes.Add("class", buttonClass);

            builder.Attributes.Add("value", text);

            builder.MergeAttributes(new RouteValueDictionary(routeValues));

            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}