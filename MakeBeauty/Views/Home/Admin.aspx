<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<%@ Import Namespace="BootStrapFramework.Extensions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Режим администратора
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <% using (Html.BeginForm())
       {%>
    <div class="row-fluid">
        <div class="span12">
            <input id="computer-code" name="computer-code" type="hidden" value="" />
            <script type="text/javascript">
                document.getElementById('computer-code').value = computerCode();
            </script>
        </div>
    </div>
    <div class="row-fluid">
        <div class="span2 offset6">
            <%= Html.BootStrapSubmitButton("Войти", ButtonStyle.Success, ButtonSize.Small) %>
        </div>
    </div>
      <% } %>
</asp:Content>

