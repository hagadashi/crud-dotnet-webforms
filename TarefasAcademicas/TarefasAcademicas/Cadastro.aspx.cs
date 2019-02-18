using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using Controller;

namespace TarefasAcademicas
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var _tarefa = new Tarefa();
                var _controller = new TarefaController();

                if (!String.IsNullOrEmpty(dtDataEntrega.Text))
                    _tarefa.DataEntrega = DateTime.ParseExact(dtDataEntrega.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                if (!String.IsNullOrEmpty(txtDescricao.Text))
                    _tarefa.Descricao = txtDescricao.Text;
                _tarefa.Entregue = chkEntregue.Checked;
                if (!String.IsNullOrEmpty(txtNota.Text))
                    _tarefa.Nota = Convert.ToByte(txtNota.Text);
                if (!String.IsNullOrEmpty(txtTipo.Text))
                    _tarefa.Tipo = txtTipo.Text;
                if (!String.IsNullOrEmpty(txtTitulo.Text))
                    _tarefa.Titulo = txtTitulo.Text;

                var response = _controller.Cadastrar(_tarefa);

                if (response)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('Tarefa Salva com sucesso');", true);
                    Response.Redirect("~/");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('Não foi possível salvar.');", true);
                }
            }
            catch (Exception err)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Erro", $"alert('erro ao tentar executar: {err.Message}');", true);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/");
        }
    }
}