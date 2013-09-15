<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MakeBeauty.ViewModels.HairStyleViewModel>" %>
<%@ Import Namespace="BootStrapFramework.Extensions" %>
<div class="row-fluid">
    <div class="span6">
        <div>
            <%= Html.LabelFor(hairStyle => hairStyle.Name) %>
        </div>
        <div>
            <%= Html.TextBoxFor(hairStyle => hairStyle.Name)%>
        </div>
        <div>
            <%= Html.LabelFor(hairStyle => hairStyle.SmallImage) %>
        </div>
        <div>
            <%= Html.DropDownListFor(hairStyle => hairStyle.SmallImage, hairStyle => hairStyle.AllImages) %>
        </div>
        <div>
            <%= Html.LabelFor(hairStyle => hairStyle.Description) %>
        </div>
        <div>
            <%= Html.TextBoxFor(hairStyle => hairStyle.Description)%>
        </div>
        <div>
            <%= Html.LabelFor(hairStyle => hairStyle.Cost) %>
        </div>
        <div>
            <%= Html.TextBoxFor(hairStyle => hairStyle.Cost)%>(руб.)
        </div>
        <div>
            <%= Html.LabelFor(hairStyle => hairStyle.Time) %>
        </div>
        <div>
            <%= Html.TextBoxFor(hairStyle => hairStyle.Time)%>
        </div>
    </div>
    <div class="span6">
        <%= Html.BootStrapImageFor(hairStyle => hairStyle.SmallImage, ImageType.Polaroid, new { width = "100%" } ) %>
    </div>
</div>
