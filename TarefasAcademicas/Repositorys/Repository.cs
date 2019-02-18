using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;

namespace Repositorys
{
    public abstract class Repository
    {
        protected OleDbConnection dbConnection;
        protected OleDbParameter[] Parametros;

        protected Repository()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoAccess"].ToString();
            dbConnection = new OleDbConnection(connectionString);
        }

        protected OleDbCommand CmdFactory(string query)
        {
            OleDbCommand cmd = new OleDbCommand(query, dbConnection);

            return cmd;
        }

        protected bool Execute(string query)
        {
            if (Parametros.Length <= 0) throw new ArgumentException("É obrigatório popular ParametrosList no construtor do Repository");

            dbConnection.Open();

            var cmd = CmdFactory(query);

            cmd.Parameters.AddRange(Parametros);

            try
            {
                return (cmd.ExecuteNonQuery() > 0);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        protected OleDbDataReader ExecuteReader(string query)
        {
            dbConnection.Open();

            var cmd = CmdFactory(query);

            try
            {
                return cmd.ExecuteReader();
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}