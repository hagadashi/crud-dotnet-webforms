using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using Controller;

namespace TarefasAcademicas
{
    public partial class Default : System.Web.UI.Page
    {
        private IEnumerable<Tarefa> lista;
        private TarefaController controller;

        protected void Page_Load(object sender, EventArgs e)
        {
            controller = new TarefaController();

            lista = controller.ListarTudo();

            if (!this.IsPostBack) AlertarTarefasAtrasadas();

            TabelaTarefa.DataSource = lista;

            TabelaTarefa.DataBind();
        }

        protected void CadastrarTarefa_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cadastro");
        }

        protected void TabelaTarefa_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = TabelaTarefa.Rows[index];
            var tarefa = lista.SingleOrDefault(x => x.Id.ToString() == row.Cells[1].Text);

            if (e.CommandName == "Edit")
            {
                if (tarefa == null) throw new Exception("Id Tarefa Não localizado");

                Session["TarefaAtual"] = tarefa;

                Response.Redirect("~/Atualizar");
            }
            else if (e.CommandName == "Delete")
            {
                if (tarefa == null) throw new Exception("Id Tarefa Não localizado");

                controller.Excluir(tarefa);

                Response.Redirect("~/");
            }
        }

        private void AlertarTarefasAtrasadas()
        {
            if (lista != null && lista.Any())
            {
                foreach (var tarefa in lista)
                {
                    if (!tarefa.Entregue && tarefa.DataEntrega < DateTime.Now)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Aviso", "alert('Você possuí tarefas Atrasadas ou para serem entregues hoje! Entregue-as o quanto antes.');", true);
                        break;
                    }
                }
            }
        }
    }
}