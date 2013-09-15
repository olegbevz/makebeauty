<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MakeBeauty.ViewModels.HairStyleViewModel>" %>
<%@ Import Namespace="BootStrapFramework.Extensions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% if (Request.IsAuthenticated) { %>
    <h2>
        <%= Html.DisplayTextFor(hairStyle => hairStyle.Name) %>
    </h2>
    <% using (Html.BeginForm()) { %>
        <fieldset>
            <%= Html.Partial("Controls/HairStyleEditor", Model) %>
            <div class="row-fluid">
                <div class="span3">
                    <%= Html.BootStrapSubmitButton(
                            "Сохранить изменения", 
                            ButtonStyle.Success, 
                            ButtonSize.Small) %>
                </div>
                <div class="span3 offset6">
                    <%= Html.BootStrapActionLink(
                           "Вернуться в галерею",
                           "Index",
                           ButtonStyle.Info,
                           ButtonSize.Small) %>
                </div>
            </div>
        </fieldset>
    <% } %>
    <% } %>
</asp:Content>
