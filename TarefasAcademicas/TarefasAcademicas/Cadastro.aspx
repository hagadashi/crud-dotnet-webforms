﻿<%@ Page Title="Cadastrar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="TarefasAcademicas.Cadastro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1>Cadastro de Tarefas</h1>
        <div class="campo">
            <asp:Label ID="lblTitulo" runat="server" Text="Título:"></asp:Label>
            <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
        </div>
        <div class="campo">
            <asp:Label ID="lblDescricao" runat="server" Text="Descrição:"></asp:Label>
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
        </div>
        <div class="campo">
            <asp:Label ID="lblTipo" runat="server" Text="Tipo:"></asp:Label>
            <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
        </div>
        <div class="campo">
            <asp:Label ID="lblDataEntrega" runat="server" Text="Data limite:"></asp:Label>
            <asp:TextBox TextMode="Date" ID="dtDataEntrega" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                ControlToValidate="dtDataEntrega" runat="server"
                ErrorMessage="Insirá uma data válida"
                ValidationExpression="(19|20)[0-9]{2}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[01])">
            </asp:RegularExpressionValidator>
        </div>
        <div class="campo">
            <asp:Label ID="lblNota" runat="server" Text="Nota:"></asp:Label>
            <asp:TextBox TextMode="number" ID="txtNota" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                ControlToValidate="txtNota" runat="server"
                ErrorMessage="Somente Numeros"
                ValidationExpression="\d+">
            </asp:RegularExpressionValidator>
        </div>
        <div class="campo">
            <asp:Label ID="lblEntregue" runat="server" Text="Entregue:"></asp:Label>
            <asp:CheckBox ID="chkEntregue" runat="server" />
        </div>
        <div class="campo">
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Width="80px" OnClick="btnSalvar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="80px" OnClick="btnCancelar_Click" />
        </div>
    </div>
</asp:Content>