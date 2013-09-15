<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MakeBeauty.ViewModels.CommentViewModel>" %>
<%@ Import Namespace="BootStrapFramework.Extensions" %>
<% using (Html.BeginForm())
   { %>
<div class="row-fluid">
    <div class="span12">
    </div>
    <fieldset>
        <div>
            <%= Html.BootStrapTextBoxFor(comment => comment.Author) %>
            <%= Html.ValidationMessageFor(comment => comment.Author) %>
        </div>
        <div>
            <%= Html.BootStrapTextAreaFor(comment => comment.Message) %>
            <%= Html.ValidationMessageFor(comment => comment.Message) %>
        </div>
        <div>
            <%= Html.BootStrapSubmitButton("Написать комментарий", ButtonStyle.Primary, ButtonSize.Small, new { @name = "CreateComment" })%>
        </div>
    </fieldset>
</div>
<% }
%>
