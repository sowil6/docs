using cartagenafirmas.Beans;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace cartagenafirmas.Public
{
    public partial class WebFormPruebas : System.Web.UI.Page
    {
        List<String> listFun = new List<String>();
        DataTable dt;
        int filaCelda = 1;
        private SqlDataReader Lector = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarGredViewPersona();
        }


        public void llenarGredViewPersona()
        {
            string ConsultaGv = "SELECT * from Table_Sede ";

            //string ConsultaGv = "SELECT n.documento_Identidad, p.Nombre_Persona, n.Lider_Responsable, n.usuario_Logueado from TablePersonaNovedad n, TablePersona p where p.documento_Identidad = n.documento_Identidad ";
            string Constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            DataTable dataTabla = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(Constr))
                {
                    cn.Open();
                    using (SqlCommand OrdenSQL = new SqlCommand(ConsultaGv, cn))
                    {
                        SqlDataAdapter dataAdaptador = new SqlDataAdapter(OrdenSQL);
                        dataAdaptador.Fill(dataTabla);
                        GridViewHoteles.DataSource = dataTabla; ;
                        GridViewHoteles.DataBind();
                    }
                }
                //colorCelda();//si estaba algun registro selecionado, se repinta
            }
            catch (SqlException ex)
            {
                //MensajeAlertCliente(ex.Message);
                //MessageBox.Show(ex.Message);
                //imagen = "delete.jpg";
                //mensaje = "Error: " + ex.Message;
                //muestraMensajePopu(mensaje, imagen);
            }
        }

        protected void GridViewHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            filaCelda = GridViewHoteles.SelectedIndex;
            GridViewHoteles.Rows[filaCelda].Cells[1].BackColor = System.Drawing.Color.Gold;
            int paginaIndice = GridViewHoteles.PageIndex * 20;
            int fila = ((filaCelda + 1) + paginaIndice);
            TexBoxNombreSede.Text = HttpUtility.HtmlDecode(GridViewHoteles.Rows[filaCelda].Cells[3].Text);
            LabelFilaSeleccionada.Text = fila.ToString();//aqui, ponemos el valor real del registro seleccionado,
           string dato = LabelFilaSeleccionada.Text.Trim();
           //MessageBox.Show(dato); //BeansSede datosf =
               buscarDatoHotel(dato.Trim());




        }
        public void buscaHoteles()
        {
            string dato = LabelFilaSeleccionada.Text.Trim();
           
        }

        public BeansSede buscarDatoHotel(string cod)
        {
          BeansSede bp = new BeansSede();
            string Constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            DataTable dataTabla = new DataTable();
            try
            {
                using (SqlConnection cn = new SqlConnection(Constr))
                {
                    cn.Open();
                    using (SqlCommand OrdenSQL = new SqlCommand("select * from dbo.Table_hotel o, Table_Sede s where o.id_sede ='" + cod + " ' and s.id_sede= o.id_sede", cn))
                    {
                        /*Lector = OrdenSQL.ExecuteReader();
                        //llamar siempre reaser antes de acceder a los datos
                        if (Lector.Read())
                        {
                            // TexBoxNombreFuncionario.Text = Lector["nombreFuncionario"].ToString().Trim();
                            bp.Id_Sede = Convert.ToInt32(Lector["id_sede"].ToString().Trim());
                            bp.Nombre_sede = Lector["nombre_sede"].ToString();
                            bp.Nombre_hotel = Lector["nombre_hotel"].ToString().Trim();
                            bp.Direccion = Lector["Direccion"].ToString().Trim();
                        }

                        */

                        SqlDataAdapter dataAdaptador = new SqlDataAdapter(OrdenSQL);
                        dataAdaptador.Fill(dataTabla);
                        GridView2.DataSource = dataTabla; ;
                        GridView2.DataBind();


                    }
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }//fin catch
            return bp;
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TexBoxNombreHotel.Text = "";
            TexBoxDireccionHotel.Text = "";
            TexBoxNombreSede.Text = "";
            TexBox_Num_Habitaciones.Text = "";
            TexBox_Tipo_Habitaciones.Text = "";
            TexBox_Cupo_Disponible.Text = "";
            filaCelda = GridView2.SelectedIndex;
            GridView2.Rows[filaCelda].Cells[1].BackColor = System.Drawing.Color.Gold;
            int paginaIndice = GridView2.PageIndex * 20;
            int fila = ((filaCelda + 1) + paginaIndice);
            LabelFilaSeleccionada.Text = fila.ToString();//aqui, ponemos el valor real del registro seleccionado,
            string dato = LabelFilaSeleccionada.Text.Trim();
            string dato_id = HttpUtility.HtmlDecode(GridView2.Rows[filaCelda].Cells[2].Text);
            //MessageBox.Show(dato_id);
            BeansSede bp = new BeansSede();
            BeansSede datosf = buscarDatoFuncionario(dato_id);//primero busca el dato en la base de datos 
            TexBoxNombreHotel.Text = datosf.Nombre_hotel;
            TexBoxDireccionHotel.Text = datosf.Direccion_hotel;
            TexBoxNombreSede.Text = datosf.Nombre_sede;
            TexBox_Num_Habitaciones.Text = datosf.Num_habitaciones;
            TexBox_Tipo_Habitaciones.Text = datosf.Tipo_habitaciones;
            TexBox_Cupo_Disponible.Text = datosf.Cupo_disponible;

        }

        public BeansSede buscarDatoFuncionario(string cod)
        {
            BeansSede bp = new BeansSede();
            string Constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                using (SqlConnection cn = new SqlConnection(Constr))
                {
                    cn.Open();
                    using (SqlCommand OrdenSQL = new SqlCommand("select * from dbo.Table_hotel o, Table_Sede s  where o.id_hotel ='" + cod + " ' and s.id_sede= o.id_sede", cn))
                    {
                        Lector = OrdenSQL.ExecuteReader();
                        //llamar siempre reaser antes de acceder a los datos
                        if (Lector.Read())
                        {
                            // TexBoxNombreFuncionario.Text = Lector["nombreFuncionario"].ToString().Trim();
                            bp.Nombre_hotel = Lector["nombre_hotel"].ToString().Trim();
                            bp.Direccion_hotel = Lector["direccion_hotel"].ToString();
                            bp.Nombre_sede = Lector["nombre_sede"].ToString();
                            bp.Num_habitaciones = Lector["habitaciones"].ToString();
                            bp.Tipo_habitaciones = Lector["tipo"].ToString();
                            bp.Cupo_disponible = Lector["cupo"].ToString(); 
                                                       
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }//fin catch
            return bp;
        } 


    }
}