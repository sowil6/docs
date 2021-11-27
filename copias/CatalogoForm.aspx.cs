using cartagenafirmas.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cartagenafirmas.Public
{
    public partial class CatalogoForm : System.Web.UI.Page
    {
        string fileName = "/GetFirmas/CargaNotasRapidas.xml";
        GestionXML gxml = new GestionXML();
        protected void Page_Load(object sender, EventArgs e)
        {
            //RepeaterCatalogo.DataSource = gxml.CargarXMLEnPaginaWeb(fileName);
            //RepeaterCatalogo.DataBind();


            CatalagoDataList1.DataSource = gxml.CargarXMLEnPaginaWeb(fileName);
            CatalagoDataList1.DataBind();
        }
    }
}