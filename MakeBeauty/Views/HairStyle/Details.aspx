<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MakeBeauty.ViewModels.HairStyleViewModel>" %>

<%@ Import Namespace="MakeBeauty.ViewModels" %>
<%@ Import Namespace="BootStrapFramework.Extensions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Присмотр прически
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
              <h2>
        <%= Html.DisplayTextFor(hairStyle => hairStyle.Name) %>
    </h2>
    <% using (Html.BeginForm())
       {%>
    <fieldset>
        <div class="row-fluid">
            <div class="span6">
                <div>
                    <%= Html.LabelFor(hairStyle => hairStyle.Description)%>
                </div>
                <div>
                    <%= Html.DisplayTextFor(hairStyle => hairStyle.Description)%>
                </div>
                <div>
                    <%= Html.LabelFor(hairStyle => hairStyle.Cost) %>
                </div>
                <div>
                    <%= Html.DisplayTextFor(hairStyle => hairStyle.Cost)%>
                    руб.
                </div>
                <div>
                    <%= Html.LabelFor(hairStyle => hairStyle.Time) %>:
                </div>
                <div>
                    <%= Html.DisplayTextFor(hairStyle => hairStyle.Time)%>
                </div>
            </div>
            <div class="span6">
                <%= Html.BootStrapImageFor(hairStyle => hairStyle.SmallImage, ImageType.Polaroid, new { width = "100%" })%>
            </div>
        </div>
        <div class="row-fluid">
            <div class="span12">
                <%= Html.ImageCarouselFor(hairStyle => hairStyle.BigImages) %>
            </div>
        </div>
        <div class="row-fluid">
            <div class="span6">
                <%= Html.BootStrapActionLink("Вернуться в галерею", "Index", ButtonStyle.Primary, ButtonSize.Small)%>
            </div>
        </div>
    </fieldset>
            <% } %>
            <%  foreach (var comment in Model.Comments)
                { %>
            <%= Html.Partial("Controls/CommentViewer", comment) %>
            <%  } %>
            <%= Html.Partial("Controls/CommentEditor", new CommentViewModel())%>
</asp:Content>
