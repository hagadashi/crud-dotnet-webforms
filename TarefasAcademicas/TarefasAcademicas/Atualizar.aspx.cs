using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;

namespace TarefasAcademicas
{
    public partial class Atualizar : System.Web.UI.Page
    {
        private Tarefa tarefa;

        protected void Page_Load(object sender, EventArgs e)
        {
            tarefa = new Tarefa();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var _tarefa = new Tarefa();

            //string dateToInsert = theDate.ToString("dd-MM-yyyy");

            _tarefa.DataEntrega = DateTime.ParseExact(dtDataEntrega.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            _tarefa.Descricao = txtDescricao.Text;
            _tarefa.Entregue = chkEntregue.Checked;
            _tarefa.Id = tarefa.Id;
            _tarefa.Nota = Convert.ToByte(txtNota.Text);
            _tarefa.Tipo = txtTipo.Text;
            _tarefa.Titulo = txtTitulo.Text;
        }
    }
}