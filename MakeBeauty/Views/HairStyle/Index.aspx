<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MakeBeauty.ViewModels.Grid<MakeBeauty.Data.Entities.HairStyle>>" %>

<%@ Import Namespace="BootStrapFramework.Extensions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Галерея причесок
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Галерея причесок</h2>
    <% if (Request.IsAuthenticated)
       { %>
    <div class="row-fluid">
        <div class="span3 offset9">
            <%=
               Html.BootStrapActionLink(
                   "Создать прическу",
                   "Create",
                   ButtonStyle.Primary,
                   ButtonSize.Small,
                   new { @align = "right" }) %>
        </div>
    </div>
    <% } %>
    <% for (var row = 0; row < Model.Rows; row++)
       { %>
    <div class="row-fluid">
        <% for (var column = 0; column < Model.Columns; column++)
           {
               if (Model.Exist(row, column))
               {
                   var hairStyle = Model[row, column];%>
        <div class="span3">
            <fieldset style="height: 200px;">
                <div align="center">
                    <%=
                                        Html.BootStrapImage(
                                           hairStyle.small_image,
                                           ImageType.Polaroid,
                                           new { width = "100", height = "100" }) %>
                </div>
                <div align="center">
                    <%= Html.Label(hairStyle.name) %>
                </div>

                <div class="row-fluid">
                    <div class="span12 pagination-centered">
                        <div class="btn-group btn-group-vertical">
                            <%= Html.BootStrapActionLink(
                                           "Просмотр",
                                           "Details",
                                            ButtonStyle.Primary,
                                            ButtonSize.Mini,
                                            new { hairStyle.id }) %>
                            <%= Html.BootStrapActionLink(
                                           "Заказать", 
                                           "Create", 
                                           "Task", 
                                           ButtonStyle.Inverse, 
                                           ButtonSize.Mini, 
                                           new { })%>
                            <% if (Request.IsAuthenticated)
                               { %>
                            <%= Html.BootStrapActionLink(
                                                "Редактировать",
                                                "Edit",
                                                ButtonStyle.Success,
                                                ButtonSize.Mini,
                                                new { hairStyle.id }) %>
                            <%= Html.BootStrapActionLink(
                                                "Удалить",
                                                "Delete",
                                                ButtonStyle.Danger,
                                                ButtonSize.Mini,
                                                new { hairStyle.id }) %>
                            <% } %>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>
        <% }
               } %>
    </div>
    <% } %>
</asp:Content>
