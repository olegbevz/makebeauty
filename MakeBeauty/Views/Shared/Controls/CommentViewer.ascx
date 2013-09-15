<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MakeBeauty.Data.Entities.Comment>" %>
<%@ Import Namespace="BootStrapFramework.Extensions" %>
<% using (Html.BeginForm())
   { %>
<div class="row-fluid">
    <div class="span12">
        <fieldset>
            <div class="row-fluid">
                <div class="span9">
                    <h3>
                        <strong>
                            <%= Html.DisplayTextFor(comment => comment.author)%>
                        </strong>
                    </h3>
                </div>
                <div class="span1">
                    <%= Html.Label("Дата: ") %>
                </div>
                <div class="span2">
                    <%= Html.DisplayTextFor(comment => comment.date) %>
                </div>
            </div>
            <div class="row-fluid">
                <div class="span12">
                    <%= Html.DisplayTextFor(comment => comment.message)%>
                </div>
            </div>
            <% if (Request.IsAuthenticated) { %>
            <div class="row-fluid">
                <div class="span2 offset10">
                    <%= Html.BootStrapActionLink(
                           "Удалить",
                           "DeleteComment",
                           ButtonStyle.Danger,
                           ButtonSize.Mini,
                           new { Model.id }) %>
                </div>
            </div>
            <% } %>
        </fieldset>
    </div>
</div>
<% }
%>
