<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MakeBeauty.ViewModels.TaskViewModel>" %>
<%@ Import Namespace="BootStrapFramework.Extensions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Оформление заявки на прическу
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Оформление заявки на прическу</h2>
    <% using (Html.BeginForm())
       {%>
    <fieldset>
        <div class="row-fluid">
            <div class="span6">
                <div>
                    <%= Html.LabelFor(task => task.Client) %>
                </div>
                <div>
                    <%= Html.TextBoxFor(task => task.Client) %>
                </div>
                <div>
                    <%= Html.ValidationMessageFor(task => task.Client) %>
                </div>
                <div>
                    <%= Html.LabelFor(task => task.Phone) %>
                </div>
                <div>
                    <%= Html.TextBoxFor(task => task.Phone) %>
                </div>
                <div>
                    <%= Html.ValidationMessageFor(task => task.Phone) %>
                </div>
                <div>
                    <%= Html.LabelFor(task => task.Date) %>
                </div>
                <div>
                    <%= Html.TextBoxFor(task => task.Date) %>
                </div>
                <div>
                    <%= Html.ValidationMessageFor(task => task.Date)%>
                </div>
                <div>
                    <%= Html.LabelFor(task => task.HairStyleId) %>
                </div>
                <div>
                    <%= Html.DropDownListFor(task => task.SelectedHairStyleItem, task => task.HairStyles, new { onchange = "OnHairStyleChanged(this);" })%>
                    <script type="text/javascript">
                        function OnHairStyleChanged(dropdown) {
                            document.getElementById("HairStyleImage").src = dropdown.value.split(";")[1];
                        }

                    </script>
                </div>
            </div>
            <div class="span6">
                <%= Html.BootStrapImageFor(task => task.HairStyleImage, ImageType.Polaroid, new { ID="HairStyleImage", width="100%"}) %>
            </div>
        </div>
        <div class="row-fluid">
            <div class="span12">
                <%= Html.LabelFor(task => task.Description) %>
            </div>
        </div>
        <div class="row-fluid">
           <div class="span11">
                <%= Html.TextAreaFor(task => task.Description, new { style = "width: 100%" })%>
            </div>
        </div>
        <div class="row-fluid"> 
                <div class="span4">
                    <%= Html.BootStrapSubmitButton("Оформить заказ", ButtonStyle.Success, ButtonSize.Small)%>
                </div>
                <div class="span4 offset4">
                    <%= Html.BootStrapActionLink("Вернуться в галерею", "Index", "HairStyle", ButtonStyle.Info, ButtonSize.Small, null)%>
                </div>
            </div>
    </fieldset>
    <% } %>
</asp:Content>
