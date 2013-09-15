<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImageCarousel.ascx.cs"
    Inherits="MakeBeauty.BootStrapFramework.Controls.ImageCarousel" %>
<div id="myCarousel" class="carousel slide">
    <div class="carousel-inner">
        <% foreach (var image in Items)
           { %>
        <% if (image == SelectedItem)
           { %>
        <div class="item active">
            <% }
           else
           { %>
            <div class="item" align="middle">
                <% } %>
                <img src="<%= image %>" alt="" width="400" height="300" class="img-polaroid" >
                <div class="carousel-caption">
                    <h4>Прическа</h4>
                    <p>
                        Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi
                        porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                </div>
            </div>
            <%  } %>
        </div>
        <a class="left carousel-control" href="#myCarousel" data-slide="prev">&lsaquo;</a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">&rsaquo;</a>
    </div>
</>