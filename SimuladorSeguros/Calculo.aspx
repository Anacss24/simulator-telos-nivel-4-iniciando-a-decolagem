<%@ Page Title="" Language="C#" MasterPageFile="~/Seguro.Master" AutoEventWireup="true" CodeBehind="Calculo.aspx.cs" Inherits="SimuladorSeguros.Calculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/StyleSheet1.css" rel="stylesheet"  />
    <a href="Home.aspx">Voltar para Home</a>
    <div ID="container_titulo">
       <asp:Label ID="titulo" runat="server" CssClass="titulo"></asp:Label>
    </div>
    <asp:Label ID="LabelDtNasc" runat="server" ></asp:Label> <br />
    <asp:Label ID="LabelCpf" runat="server" ></asp:Label> <br />
    
    <asp:Label ID="lblMensagem" runat="server" ></asp:Label> <br />
     <div ID="container_preco">
           <asp:Label ID="LabelPreco" runat="server" CssClass="preco"></asp:Label>  
     </div>
    

    
</asp:Content>
