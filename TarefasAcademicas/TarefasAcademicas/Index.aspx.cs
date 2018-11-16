using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TarefasAcademicas
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds.ReadXml(Server.MapPath("~/Views/Dados/ControleTarefas.xml"));

            TabelaTarefa.DataSource = ds.Tables[0];

            TabelaTarefa.DataBind();
        }
    }
}