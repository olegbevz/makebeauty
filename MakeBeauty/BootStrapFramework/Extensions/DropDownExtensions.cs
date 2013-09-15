namespace BootStrapFramework.Extensions
{
    using System.Linq.Expressions;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System;
    using System.Collections.Generic;

    public static class DropDownExtensions
    {
        public static MvcHtmlString DropDownListFor<TModel, TProperty>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TProperty>> valueExpression,
            Expression<Func<TModel, IEnumerable<SelectListItem>>> valuesExpression)
        {
            return html.DropDownListFor(
                valueExpression, 
                valuesExpression, 
                new Dictionary<string, object>());
        }

        public static MvcHtmlString DropDownListFor<TModel, TProperty>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TProperty>> valueExpression,
            Expression<Func<TModel, IEnumerable<SelectListItem>>> valuesExpression,
            object attributes)
        {
            return html.DropDownListFor(
                valueExpression,
                valuesExpression,
                new RouteValueDictionary(attributes));
        }

        public static MvcHtmlString DropDownListFor<TModel, TProperty>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TProperty>> valueExpression,
            Expression<Func<TModel, IEnumerable<SelectListItem>>> valuesExpression,
            IDictionary<string, object> attributes)
        {
            var metaData = ModelMetadata.FromLambdaExpression(valuesExpression, html.ViewData);

            var items = metaData.Model as IEnumerable<SelectListItem>;

            if (items != null)
            {
                return html.DropDownListFor(valueExpression, items, attributes);
            }

            return MvcHtmlString.Empty;
        }
    }
}