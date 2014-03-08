<%@ Page Title="Bienvenido" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CallCenter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

         <h1><%: Title %>.</h1>
        <h2>Trabajo final de la asignatura ASP.NET con C#</h2>
        <p class="lead">Se ha desarrollado una aplicación tipo Call Center donde se muestran una serie de 
            averias de tipo informático, donde el usuario podrá escoger que tipo de averia sufre para que el departamento
            técnico se la pueda solucionar.
        </p>

</asp:Content>
