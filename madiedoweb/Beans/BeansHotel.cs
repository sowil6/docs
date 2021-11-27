using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cartagenafirmas.Beans
{
    public class BeansHotel
         {
           private int id_hotel;
 private string nombre_hotel;
 private string direccion_hotel;

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
            

             
    }
}