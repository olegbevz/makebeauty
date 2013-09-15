<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
    <% ViewData["Silverlight"] = true; %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Список заказов</h2>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SilverlightPlaceHolder" runat="server">
    <% if (Request.IsAuthenticated) { %>
        <form id="form1" runat="server" style="height:100%">
        <div id="silverlightControlHost">
            <object data="data:application/x-silverlight-2," type="application/x-silverlight-2" width="100%" height="100%">
		      <param name="source" value="ClientBin/MakeBeauty.Silverlight.xap"/>
		      <param name="onError" value="onSilverlightError" />
		      <param name="background" value="white" />
		      <param name="minRuntimeVersion" value="4.0.50826.0" />
		      <param name="autoUpgrade" value="true" />
		      <a href="http://go.microsoft.com/fwlink/?LinkID=149156&v=4.0.50826.0" style="text-decoration:none">
 			      <img src="http://go.microsoft.com/fwlink/?LinkId=161376" alt="Get Microsoft Silverlight" style="border-style:none"/>
		      </a>
	        </object><iframe id="_sl_historyFrame" style="visibility:hidden;height:0px;width:0px;border:0px"></iframe></div>
        </form>
    <% } %>
</asp:Content>
