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
    public class N_Habitacion
    {
        D_Habitacion objd = new D_Habitacion();
        public String N_Mantenimiento_Habitacion(E_Habitacion obje)
        {
            return objd.D_Mantenimiento_Habitacion(obje);
        }
        public DataTable N_Create_Habitacion(E_Habitacion obje)
        {
            return objd.D_Create_Habitacion(obje);
        }
        public DataTable N_Get_Habitacion()
        {
            return objd.D_Get_Habitacion();
        }
        public DataTable N_Buscar_Habitacion(E_Habitacion obje)
        {
            return objd.D_Buscar_Habitacion(obje);
        }
    }
}
