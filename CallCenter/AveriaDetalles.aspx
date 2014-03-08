<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AveriaDetalles.aspx.cs" Inherits="CallCenter.AveriaDetalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FormView ID="averiaDetalles" runat="server" ItemType="CallCenter.Models.Averia" SelectMethod ="GetAverias" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.AveriaNombre %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Catalog/Images/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.AveriaNombre %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Descripción:</b><br /><%#:Item.Descripcion %>
                        <br />
                        <span><b>Precio:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrecio) %></span>
                        <br />
                        <span><b>Número de Producto</b>&nbsp;<%#:Item.AveriaID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>


</asp:Content>
