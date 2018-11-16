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
    }
}