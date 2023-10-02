<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="webUsuarios.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <h2>
            Consulta de usuarios
        </h2>
    </div>
    <br />
    <label>Consular usuario por id</label>
    <br />
    <input runat="server" id="txtIdUsuario" type="text" />
    <br />
    <asp:Button class="btn btn-primary btn-lg" runat="server" ID="btnConsultar" Text="Consultar usuario" OnClick="btnConsultar_Click" Height="43px" Width="185px"/>
    <asp:Button class="btn btn-secundary btn-lg" ID="btnListar" runat="server"  Text="Listar Usuarios" Height="43px" Width="185px" OnClick="btnListar_Click" />
    <asp:Button class="btn btn-danger btn-lg" ID="btnEliminar" runat="server" OnClick="Eliminar_Click" Text="Eliminar" />
    <br />
     <br />
    <asp:GridView ID="GridView1" runat="server" Width="430px" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="156px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="sexo" HeaderText="sexo" />
            <asp:BoundField DataField="fechanacimiento" HeaderText="fecha Nac" DataFormatString="DD:MM:AAAA" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
     <br /> <br />
</asp:Content>
