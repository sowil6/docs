using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
//using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Windows.Forms;


namespace cartagenafirmas
{
    public class ManagerBaseDeDatos
    {
       
        private SqlConnection ConexionConBD = null;
        private SqlCommand OrdenSQL = null;
   
        string ConStr = "";

        //public string ConStr = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=bdrfidactivos;Integrated Security=True";
      //  public string ConStr = " Data Source=10.10.96.15\\ZASQLSERVER;Initial Catalog=bdrfidactivos;User ID=sa;Password=za/147/zaq/*";
        //string ConStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public SqlConnection conectar()
        {
           ConStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
          ConexionConBD = new SqlConnection();
          //OrdenSQL = new SqlCommand();
          ConexionConBD.ConnectionString = ConStr;
          try
          {
              
              ConexionConBD.Open();
            
          }
          catch 
          {// MessageBox.Show("No se pudo tener acceso a la base de datos  "+ex.Message);
          
          }
       
            return ConexionConBD;
        }

        public void Desconectar()
        {
            
                ConexionConBD.Close();
          
        }

        public void InsertarTipo(string texboxtipo)
        {
            // AsignarcampoTabla();

            conectar();
                      OrdenSQL.CommandText = "INSERT INTO tipo(tipo) VALUES (@tipo)";
            //datos a tabla invetario

            OrdenSQL.Parameters.AddWithValue("@tipo",texboxtipo);

            OrdenSQL.Connection = ConexionConBD;
            int i = OrdenSQL.ExecuteNonQuery();
            ConexionConBD.Close();
            //tomamos la foto y la copiamos del la carpeta temp a la carpeta FotoActivo
           // MessageBox.Show("El Registro se agregó satisfactoriamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//fin insertar tipo

        public void eliminarTipo(string cod)
        {
            ConexionConBD.ConnectionString = ConStr;

            OrdenSQL.CommandText = "Delete from tipo where  idTipo ='" + cod + " '";
            OrdenSQL.Connection = ConexionConBD;
            ConexionConBD.Open();
            int i = OrdenSQL.ExecuteNonQuery();
            ConexionConBD.Close();

        }

    }
}