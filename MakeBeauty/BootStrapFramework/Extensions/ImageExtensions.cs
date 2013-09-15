// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImageExtensions.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ImageType type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BootStrapFramework.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Text;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Xml;

    public enum ImageType
    {
        Rounded,

        Circle,

        Polaroid
    }

    public static class ImageExtensions
    {
        public static MvcHtmlString BootStrapImageFor<TModel, TValue>(
           this HtmlHelper<TModel> html,
           Expression<Func<TModel, TValue>> expression, 
            ImageType type)
        {
            var metaData = ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            if (metaData.Model != null)
            {
                return BootStrapImage(html, metaData.Model.ToString(), type);
            }

            return MvcHtmlString.Empty;
        }

        public static MvcHtmlString BootStrapImageFor<TModel, TValue>(
           this HtmlHelper<TModel> html,
           Expression<Func<TModel, TValue>> expression, ImageType type,
           object attributes)
        {
            var metaData = ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            if (metaData.Model != null)
            {
                return BootStrapImage(html, metaData.Model.ToString(), type, attributes);
            }

            return MvcHtmlString.Empty;
        }

        public static MvcHtmlString BootStrapImageFor<TModel, TValue>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TValue>> expression, ImageType type,
            IDictionary<string, object> attributes)
        {
            var metaData = ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            return BootStrapImage(html, metaData.Model.ToString(), type, attributes);
        }

        public static MvcHtmlString BootStrapImage<TModel, TValue>(
            this HtmlHelper<TModel> html,
            TValue source, ImageType type,
            object attributes)
        {
            return html.BootStrapImage(source, type, new RouteValueDictionary(attributes));
        }

        public static MvcHtmlString BootStrapImage<TModel, TValue>(
            this HtmlHelper<TModel> htmlHelper,
            TValue source, ImageType type,
            IDictionary<string, object> attributes)
        {
            var builder = new System.Web.Mvc.TagBuilder("img");

            builder.Attributes.Add("src", source.ToString());

            switch (type)
            {
                case ImageType.Rounded:
                    builder.Attributes.Add("class", "img-rounded");
                    break;
                case ImageType.Circle:
                    builder.Attributes.Add("class", "img-circle");
                    break;
                case ImageType.Polaroid:
                    builder.Attributes.Add("class", "img-polaroid");
                    break;
            }

            builder.MergeAttributes(attributes);

            return MvcHtmlString.Create(builder.ToString(TagRenderMode.Normal));
        }

        public static MvcHtmlString BootStrapImage<TModel, TValue>(
            this HtmlHelper<TModel> htmlHelper,
            TValue source,
            ImageType type)
        {
            return BootStrapImage(htmlHelper, source, type, new Dictionary<string, object>());
        }
    }
}