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

        protected void Page_Load(object sender, EventArgs e)
        {
            var _controller = new TarefaController();

            lista = _controller.ListarTudo();

            TabelaTarefa.DataSource = lista;

            TabelaTarefa.DataBind();
        }

        protected void CadastrarTarefa_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cadastro");
        }

        protected void TabelaTarefa_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = TabelaTarefa.Rows[index];
                var tarefa = lista.SingleOrDefault(x => x.Id.ToString() == row.Cells[1].Text);

                if (tarefa == null) throw new Exception("Id Tarefa Não localizado");

                Session["TarefaAtual"] = tarefa;

                Response.Redirect("~/Atualizar");
            }
        }
    }
}