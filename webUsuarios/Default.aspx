<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webUsuarios._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <div class="jumbotron">
        <h1>Usuarios</h1>
        
            <div>
            <label for="txtNombre">Nombre:</label>
            <asp:TextBox  class="form-control" ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <div>
            <label for="ddlSexo">Sexo:</label>
            <asp:DropDownList  class="form-control" ID="ddlSexo" runat="server">
                <asp:ListItem Text="Seleccionar" Value="" />
                <asp:ListItem Text="Masculino" Value="M" />
                <asp:ListItem Text="Femenino" Value="F" />
            </asp:DropDownList>
        </div>
        <div>
            <label for="txtFechaNacimiento">Fecha de Nacimiento:</label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </div>
           <br />
           <br /> 
           <div>
               <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>
           </div>
        <div>
            <asp:Button class="btn btn-primary btn-lg" ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
           <h3> <a runat="server" href="~/About">Consultar Usuarios</a></h3>
        </div>
    </div>
   
       
     
</asp:Content>
