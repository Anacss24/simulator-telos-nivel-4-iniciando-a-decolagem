<%@ Page Title="" Language="C#" MasterPageFile="~/Seguro.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SimuladorSeguros.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="CSS/Home.css" rel="stylesheet"  />
    <div ID="container_home">
    <h3>Proteja o que é mais importante para você com os nossos planos de seguros personalizados.
        Escolha a segurança e tranquilidade que você e sua família merecem!</h3>
   <label>Nome:</label> <asp:TextBox ID="TextBoxNome" runat="server" CssClass="label"></asp:TextBox><br />
   <label>Data de Nascimento:</label> <asp:TextBox ID="TextBoxDNASC" runat="server" CssClass="label" TextMode="Date"></asp:TextBox><br />
   <label>CPF:</label><asp:TextBox ID="TextBoxCPF" runat="server" CssClass="label"></asp:TextBox><br />
    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="label">
        <asp:ListItem Value="seguroVida" Text="Seguro de Vida"> </asp:ListItem>
        <asp:ListItem Value="seguroMorteAcidental" Text="Seguro de Morte Acidental"></asp:ListItem>
        <asp:ListItem Value="seguroAcidentesPessoais" Text="Seguro Contra Acidentes Pessoais"></asp:ListItem>
        <asp:ListItem Value="seguroSaude" Text="Seguro de Saúde"></asp:ListItem>
        <asp:ListItem Value="seguroAutomovel" Text="Seguro de Automóvel"></asp:ListItem>
        <asp:ListItem Value="seguroResidencial" Text="Seguro Residencial"></asp:ListItem>
        <asp:ListItem Value="seguroPatrimonial" Text="Seguro Patrimonial"></asp:ListItem>
        <asp:ListItem Value="seguroEmpresarial" Text="Seguro Empresarial"></asp:ListItem>
    </asp:DropDownList><br/>
    <asp:Button runat="server" Text="Calcular" OnClick="Unnamed1_Click" CssClass="botao" />
    </div>
</asp:Content>
