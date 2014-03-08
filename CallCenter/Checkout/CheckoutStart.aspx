<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckoutStart.aspx.cs" Inherits="CallCenter.Checkout.CheckoutStart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Departamento Técnico</h1>
   <div id="ShoppingCartTitle" runat="server" class="ContentHead">
       <h3>Averias comunicadas al departamento tecnico</h3></div>
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

    <br />

</asp:Content>
