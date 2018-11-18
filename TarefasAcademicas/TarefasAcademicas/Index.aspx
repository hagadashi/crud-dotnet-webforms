<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TarefasAcademicas.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Banner" runat="server" BackColor="#CCCCFF" BorderColor="#999999" BorderStyle="Outset" Font-Names="Calibri" Font-Size="Larger" ForeColor="Black" Height="96px">
            &nbsp;&nbsp; Olá, aluno!<br />
            <br />
            &nbsp; Seja bem-vindo ao Sistema de Controle de Tarefas.</asp:Panel>
        <div id="Textbox" aria-expanded="false" aria-live="off" style="font-family: Calibri; font-size: x-large; height: 54px;">
            <br />
            Lista de Tarefas:</div>
        <p>
            <asp:LinkButton ID="CadastrarTarefa" runat="server" Font-Names="Calibri" Font-Size="Medium" OnClick="CadastrarTarefa_Click">Cadastrar nova tarefa</asp:LinkButton>
        </p>
        <asp:GridView ID="TabelaTarefa" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="592px" OnSelectedIndexChanged="TabelaTarefa_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:CommandField HeaderText="Ações" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </form>
</body>
</html>
