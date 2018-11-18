<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="TarefasAcademicas.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Cadastro de Tarefas </title>
    <style>
        
        .container{
            width: 450px;
            margin: 0 auto;
         }

        .container h1{
            text-align: center;
        }

        .campo{
            padding: 10px;
        }

        .campo input[type="text"]{
            float:right;
            width: 350px;
        }
           
         .campo input[type="submit"]{
            float:right;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Cadastro de Tarefas</h1>
            <div class="campo">
                <label for="txtTitulo">Título:</label>
                <input type="text" id="txtTitulo" />
            </div>
            <div class="campo">
                <label for="txtDescricao">Descrição:</label>
                <input type="text" id="txtDescricao" />
            </div>
            <div class="campo">
                <label for="txtTipo">Tipo:</label>
                <input type="text" id="txtTipo" />
            </div>
            <div class="campo">
                <label for="txtData">Data limite: </label>
                <input type="text" id="txtData" />
            </div>
            <div class="campo">
                <label for="txtNota">Nota:</label>
                <input type="text" id="txtNota" />
            </div>
            <div class="campo">
                <label for="txtEntregue">Entregue:</label>
                <input type="text" id="txtEntregue" />
            </div>

            <div class="campo">
                <input type="submit" title="Cadastrar" value="Concluir cadastro"/>

            </div>
        </div>
    </form>
</body>
</html>
