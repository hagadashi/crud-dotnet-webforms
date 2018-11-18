<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Atualizar.aspx.cs" Inherits="TarefasAcademicas.Atualizar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Editar Tarefas</title>
        <style>

        body {
            background-color:aliceblue;
        }
        
        h1 {
            font-family:Arial;
            font-size:xx-large;
             text-shadow: 2px 2px 5px cornflowerblue;
        }
        .container{
            width: 450px;
            margin: 0 auto;
            font-family:Calibri;
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
           
         .btn input[type="submit"]{
            float:right;
            display:inline;
            margin:0 5px;
            transition-duration: 0.4s;
            color:black;
            border-radius:4px;
            width: 150px;
            padding: 10px;
          }

         .btn input[type="submit"]:hover{
             background-color:cornflowerblue;
             color:white;
         }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Tarefas</h1>
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

            <div class="btn">
                <input type="submit" title="Atualizar" value="Atualizar"/>
               
            
            <div class="btn">
                <input type="submit" title="Cancelar" value="Cancelar" />
               

            </div>
        </div>
    </form>
</body>
</html>
