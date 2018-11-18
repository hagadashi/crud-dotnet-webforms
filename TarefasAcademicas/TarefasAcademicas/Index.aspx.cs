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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds.ReadXml(Server.MapPath("~/Dados/ControleTarefas.xml"));

            TabelaTarefa.DataSource = ds.Tables[0];

            TabelaTarefa.DataBind();
        }

        protected void CadastrarTarefa_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            var NovaTarefa = new Tarefa();

            var tarefaController = new TarefaController();

            bool cadastrado = tarefaController.Cadastrar(NovaTarefa);
         
        }

        protected void TabelaTarefa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}