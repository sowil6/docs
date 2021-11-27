using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cartagenafirmas.Beans
{
    public class BeansSede
    {
        private int id_Sede;
        private string nombre_sede;
        private string ubicacion;
        private int id_hotel;
        private string nombre_hotel;
        private string direccion_hotel;
        private string num_habitaciones;
        private string tipo_habitaciones;
        private string cupo_disponible;

        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        } 

 public string Nombre_sede
        {
            get { return nombre_sede; }
            set { nombre_sede = value; }
        }


        public int Id_Sede
        {
            get { return id_Sede; }
            set { id_Sede = value; }
        }

        public int Id_hotel
        {
            get { return id_hotel; }
            set { id_hotel = value; }
        }


        public string Nombre_hotel
        {
            get { return nombre_hotel; }
            set { nombre_hotel = value; }
        }


        public string Direccion_hotel
        {
            get { return direccion_hotel; }
            set { direccion_hotel = value; }
        }
     public string Num_habitaciones
        {
            get { return num_habitaciones; }
            set { num_habitaciones = value; }
        }
 public string Tipo_habitaciones
        {
            get { return tipo_habitaciones; }
            set { tipo_habitaciones = value; }
        }
  public string Cupo_disponible
        {
            get { return cupo_disponible; }
            set { cupo_disponible = value; }
        }
    }
}