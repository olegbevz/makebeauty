<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MakeBeauty.HardwareInfo.Hardware>" %>
<%@ Import Namespace="BootStrapFramework.Extensions" %>
<%@ Import Namespace="MakeBeauty.Identification" %>
<div class="row-fluid">
    <div class="span12">
        <div>
            <%= Html.Label("Computer hardware") %>
        </div>
        <div>
            <%= Html.Label("Processor") %>
        </div>
        <div>
            <%= Html.Label("id: ") %>
            <%= Html.DisplayTextFor(hardware => hardware.Processor.Id) %>
        </div>
        <div>
            <%= Html.Label("name: ") %>
            <%= Html.DisplayTextFor(hardware => hardware.Processor.Name) %>
        </div>
        <div>
            <%= Html.Label("number of cores:") %>
            <%= Html.DisplayTextFor(hardware => hardware.Processor.NumberOfCores) %>
        </div>
        <div>
            <%= Html.Label("socket destignation: ") %>
            <%= Html.DisplayTextFor(hardware => hardware.Processor.SocketDesignation) %>
        </div>
        <div>
            <%= Html.Label("MotherBoard") %>
        </div>
         <div>
            <%= Html.Label("product: ") %>
            <%= Html.DisplayTextFor(hardware => hardware.MotherBoard.Product) %>
        </div>
        <div>
            <%= Html.Label("BIOS") %>
        </div>
         <div>
            <%= Html.Label("manufacturer: ") %>
            <%= Html.DisplayTextFor(hardware => hardware.BIOS.Manufacturer) %>
        </div>
         <div>
            <%= Html.Label("name: ") %>
            <%= Html.DisplayTextFor(hardware => hardware.BIOS.Name) %>
        </div>
         <div>
            <%= Html.Label("version: ") %>
            <%= Html.DisplayTextFor(hardware => hardware.BIOS.Version) %>
        </div>
    </div>
</div>
