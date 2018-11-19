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
            string query = $"INSERT INTO tbTarefas (titulo, descricao, dataEntrega, tipo, entregue, nota) " +
                $"VALUES ({pTitulo.ParameterName}, {pDescricao.ParameterName}, {pDataEntrega.ParameterName}, " +
                $"{pTipo.ParameterName}, {pEntregue.ParameterName}, {pNota.ParameterName})";

            Parametros = new OleDbParameter[] { pTitulo, pDescricao, pDataEntrega, pTipo, pEntregue, pNota };

            return Execute(query);
        }

        public bool Alterar()
        {
            string query = $"UPDATE tbTarefas set titulo = {pTitulo.ParameterName}, descricao = {pDescricao.ParameterName}, " +
                $"dataEntrega = {pDataEntrega.ParameterName}, tipo = {pTipo.ParameterName}, entregue = {pEntregue.ParameterName}," +
                $"nota = {pNota.ParameterName} " +
                $"WHERE id = {pId.ParameterName}";

            Parametros = new OleDbParameter[] { pTitulo, pDescricao, pDataEntrega, pTipo, pEntregue, pNota, pId };

            return Execute(query);
        }

        public bool Excluir()
        {
            string query = $"DELETE FROM tbTarefas where id = {pId.ParameterName}";

            Parametros = new OleDbParameter[] { pId };

            return Execute(query);
        }

        public IEnumerable<Tarefa> ListarTudo()
        {
            string query = $"SELECT * FROM tbTarefas order by dataEntrega";

            dbConnection.Open();

            var cmd = CmdFactory(query);

            try
            {
                var dados = cmd.ExecuteReader();

                return ReaderToList(dados);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private List<Tarefa> ReaderToList(OleDbDataReader dados)
        {
            var tarefas = new List<Tarefa>();

            if (!dados.HasRows) return tarefas;

            while (dados.Read())
            {
                Tarefa tarefa = new Tarefa();

                if (!String.IsNullOrEmpty(dados["dataEntrega"].ToString()))
                    tarefa.DataEntrega = (DateTime)dados["dataEntrega"];
                if (!String.IsNullOrEmpty(dados["descricao"].ToString()))
                    tarefa.Descricao = (string)dados["descricao"];
                if (!String.IsNullOrEmpty(dados["entregue"].ToString()))
                    tarefa.Entregue = (bool)dados["entregue"];
                if (!String.IsNullOrEmpty(dados["id"].ToString()))
                    tarefa.Id = (int)dados["id"];
                if (!String.IsNullOrEmpty(dados["nota"].ToString()))
                {
                    var a = dados["nota"];
                    tarefa.Nota = (byte)dados["nota"];
                }
                if (!String.IsNullOrEmpty(dados["tipo"].ToString()))
                    tarefa.Tipo = (string)dados["tipo"];
                if (!String.IsNullOrEmpty(dados["titulo"].ToString()))
                    tarefa.Titulo = (string)dados["titulo"];

                tarefas.Add(tarefa);
            }

            return tarefas;
        }
    }
}