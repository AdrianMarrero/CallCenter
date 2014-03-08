<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CallCenter.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h3>Explicación del ejercicio</h3>
    <p>Se ha desarrollado la aplicación Call Center tal como se pedia como trabajo final de la asignatura de ASP.NET</p>
   
     <ul>
        <li><p>Lenguaje utilizado C#</p></li>
        <li><p>Diseño interfaz web: Bootstrap</p></li>
        <li><p>Manejo de datos: Entity Framework Code First</p></li>
    </ul>
       
    <p>La aplicación maneja datos tal y como se pedia, se ha aprovechado Entity Framework por ser más actual, con lo que se ha podido practicar con ello de un modo práctico</p>
    <p>Se muestran una serie de posibles averias o acciones de mantenimiento a nivel informático, donde el usuario podrá elegir la que necesite. Se le irá informando de las acciones que desea comunicar al departamento técnico
        antes de enviar el informe al mismo. Una vez queremos enviar nuestro informe al departamento técnico se pedira logearnos con un usuario previamente registrado.
        El flujo de la aplicación termina una vez ha llegado el informe al departamento técnico. Todo ello se irá guardando en sesión por si queremos añadir nuevas averias o incidencias.
    </p>
    <p>El departamento técnico guardará un historial de todas las incidencias comunicadas.</p>
    
</asp:Content>
