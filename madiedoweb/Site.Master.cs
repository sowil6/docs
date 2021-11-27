using cartagenafirmas.Beans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Windows.Forms;
using System.IO;


namespace cartagenafirmas
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        
      
        //XmlNodeList lista, lista2 = null;
        //string RaizNodoName = "Acto";
        //string TituloNodo = "Actos";
        //List<BeanNoticia> listFun = null;
        //BeanNoticia bn = null;
 
        protected void Page_Load(object sender, EventArgs e)
        {      
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
      
        //MultiView mv = (MultiView)this....Main.FindControl("MultiView1");


        //mv.ActiveViewIndex = Convert.ToInt32(e.Item.Value.ToString());
            //MultiView1.ActiveViewIndex = 0;
        }
        private string m_Titulo;
        public string Titulox
        {
            get
            {
                return m_Titulo;
            }
            set
            {
                m_Titulo = value;
                this.Hiperlink.Text = value;
            }
        }


        private string m_Titulo2;
        public string Titulo2
        {
            get
            {
                return m_Titulo2;
            }
            set
            {
                m_Titulo2 = value;
                this.Hyperlink3.Text = value;
            }
        }

    }
}
