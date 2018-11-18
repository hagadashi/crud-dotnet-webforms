<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="TarefasAcademicas.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro de Tarefas </title>
    <style>
        .container {
            width: 450px;
            margin: 0 auto;
        }

            .container h1 {
                text-align: center;
            }

        .campo {
            padding: 10px;
        }

            .campo input[type="text"] {
                float: right;
                width: 350px;
            }

            .campo input[type="submit"] {
                float: right;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
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
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="80px" />
            </div>
        </div>
    </form>
</body>
</html>