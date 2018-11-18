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
    public partial class Atualizar : System.Web.UI.Page
    {
        private Tarefa tarefa;

        protected void Page_Load(object sender, EventArgs e)
        {
            Tarefa mock = new Tarefa();
            mock.Id = 1; // mock
            mock.DataEntrega = DateTime.Now;
            mock.Descricao = "Mock1";
            mock.Entregue = true;
            mock.Nota = 1;
            mock.Tipo = "Prova";
            mock.Titulo = "Prova Software para Internet";

            tarefa = mock; // substituir mock pela tarefa que será alterada
            dtDataEntrega.Text = tarefa.DataEntrega.ToString("yyyy-MM-dd");
            txtDescricao.Text = tarefa.Descricao;
            chkEntregue.Checked = tarefa.Entregue;
            txtNota.Text = tarefa.Nota.ToString();
            txtTipo.Text = tarefa.Tipo;
            txtTitulo.Text = tarefa.Titulo;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var _tarefa = new Tarefa();
                var _controller = new TarefaController();

                _tarefa.Id = tarefa.Id;
                _tarefa.DataEntrega = DateTime.ParseExact(dtDataEntrega.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                _tarefa.Descricao = txtDescricao.Text;
                _tarefa.Entregue = chkEntregue.Checked;
                _tarefa.Nota = Convert.ToByte(txtNota.Text);
                _tarefa.Tipo = txtTipo.Text;
                _tarefa.Titulo = txtTitulo.Text;

                var response = _controller.Alterar(_tarefa);

                if (response)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('Tarefa Atualizada com sucesso');", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Erro", "alert('Não foi possível Atualizar.');", true);
                }
            }
            catch (Exception err)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Erro", $"alert('erro ao tentar executar: {err.Message}');", true);
            }
        }
    }
}