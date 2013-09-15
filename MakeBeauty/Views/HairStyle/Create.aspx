<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MakeBeauty.ViewModels.HairStyleViewModel>" %>

<%@ Import Namespace="BootStrapFramework.Extensions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Создание прически
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <% if (Request.IsAuthenticated) { %>
    <h2>
        <%= Html.DisplayTextFor(hairStyle => hairStyle.Name) %>
    </h2>
    <% using (Html.BeginForm())
       {%>
    <fieldset>
        <div class="row-fluid">
            <div class="span12">
                <%= Html.Partial("Controls/HairStyleEditor", Model) %>
            </div>  
        </div>
        <div class="row-fluid">
            <div class="span4">
                <%= Html.BootStrapSubmitButton("Создать", ButtonStyle.Success, ButtonSize.Small) %>
            </div>
            <div class="span4 offset4">
                <%= Html.BootStrapActionLink("Вернуться в галерею", "Index", ButtonStyle.Info, ButtonSize.Small, new { @width="100%"}) %>
            </div>
        </div>
    </fieldset>
    <% } %>
    <% } %>
</asp:Content>
