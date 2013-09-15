// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TextBoxExtensions.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the TextBoxExtensions type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BootStrapFramework.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    using System.Web.Routing;

    public static class TextBoxExtensions
    {
        public static MvcHtmlString BootStrapTextBoxFor<TModel, TProperty>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TProperty>> expression)
        {
            return html.BootStrapTextBoxFor(expression, new Dictionary<string, object>());
        }

        public static MvcHtmlString BootStrapTextBoxFor<TModel, TProperty>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TProperty>> expression,
            object attributes)
        {
            return html.BootStrapTextBoxFor(expression, new RouteValueDictionary(attributes));
        }

        public static MvcHtmlString BootStrapTextBoxFor<TModel, TProperty>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TProperty>> expression,
            IDictionary<string, object> attributes)
        {
            var metaData = ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            attributes.Add("placeholder", metaData.DisplayName);

            return html.TextBoxFor(expression, attributes);
        }
    }
}