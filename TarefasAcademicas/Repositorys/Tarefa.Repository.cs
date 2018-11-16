using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Repositorys
{
    public class TarefaRepository : Repository
    {
        private readonly OleDbParameter pDataEntrega = new OleDbParameter("@DataEntrega", OleDbType.Date);
        private readonly OleDbParameter pDescricao = new OleDbParameter("@Descricao", OleDbType.VarChar);
        private readonly OleDbParameter pEntregue = new OleDbParameter("@Entregue", OleDbType.Boolean);
        private readonly OleDbParameter pId = new OleDbParameter("@Id", OleDbType.BigInt);
        private readonly OleDbParameter pNota = new OleDbParameter("@Nota", OleDbType.TinyInt);
        private readonly OleDbParameter pTipo = new OleDbParameter("@Tipo", OleDbType.VarChar);
        private readonly OleDbParameter pTitulo = new OleDbParameter("@Titulo", OleDbType.VarChar);

        public TarefaRepository(Tarefa tarefa) : base()
        {
            pDataEntrega.Value = tarefa.DataEntrega;
            pDescricao.Value = tarefa.Descricao;
            pEntregue.Value = tarefa.Entregue;
            pId.Value = tarefa.Id;
            pNota.Value = tarefa.Nota;
            pTipo.Value = tarefa.Tipo;
            pTitulo.Value = tarefa.Titulo;
        }

        public bool Cadastrar()
        {
            dbConnection.Open();

            string query = $"INSERT INTO tbTarefas (titulo, descricao, dataEntrega, tipo) " +
                $"VALUES ({pTitulo.ParameterName}, {pDescricao.ParameterName}, {pDataEntrega.ParameterName}, {pTipo.ParameterName})";

            var cmd = CmdFactory(query);

            cmd.Parameters.Add(pTitulo);
            cmd.Parameters.Add(pDescricao);
            cmd.Parameters.Add(pDataEntrega);
            cmd.Parameters.Add(pTipo);

            try
            {
                return (cmd.ExecuteNonQuery() > 0);
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}