<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Aulas.aspx.cs" Inherits="ABM_Entity.Aulas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView runat="server" ID="grid_aulas"></asp:GridView>
    <hr />
    <asp:GridView runat="server" ID="grid_alumnos"></asp:GridView>
    <hr />
    <h3>Lista obtenida por la vista VIEW_ALUMNOS ordenado por apellido</h3>
    <asp:GridView runat="server" ID="grid_alumnos_view"></asp:GridView>
</asp:Content>
