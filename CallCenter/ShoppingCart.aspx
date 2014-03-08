<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="CallCenter.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="ShoppingCartTitle" runat="server" class="ContentHead">
        <h1>Averias</h1>
        <p>Se comunicarán al servicio técnico las siguientes averias, actualizaciones o mantenimiento para su equipo</p>
    </div>
    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="CallCenter.Models.CartItem" SelectMethod="GetShoppingCartItems" 
        CssClass="table table-striped table-bordered" >   
        <Columns>
        <asp:BoundField DataField="AveriaID" HeaderText="ID" SortExpression="AveriaID" />        
        <asp:BoundField DataField="Averia.AveriaNombre" HeaderText="Nombre" /> 
        <asp:BoundField DataField="Averia.Descripcion" HeaderText="Descripcion de la averia" />           
        <asp:BoundField DataField="Averia.UnitPrecio" HeaderText="Precio de la repación" DataFormatString="{0:c}"/>     
           
       
    
        </Columns>    
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server"></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong> 
    </div>
    <br />

        <table> 
    <tr>

      <td>
        <asp:ImageButton ID="CheckoutBtn" runat="server" AlternateText="Comunicar al departamento Técnico" OnClick="CheckoutBtn_Click" />
        
      </td>
    </tr>
    </table>

</asp:Content>
