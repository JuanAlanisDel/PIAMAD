using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class N_Reserv
    {
        D_Reserv objd = new D_Reserv();
        public String N_Mantenimiento_Reservacion(E_Reserv obje)
        {
            return objd.D_Mantenimiento_Reservacion(obje);
        }
        public DataTable N_Create_Reservacion(E_Reserv obje)
        {
            return objd.D_Create_Reservacion(obje);
        }
        public DataTable N_Get_Reservacion()
        {
            return objd.D_Get_Reservacion();
        }
        public DataTable N_Buscar_Reservacion(E_Reserv obje)
        {
            return objd.D_Buscar_Reservacion(obje);
        }
    }
}
