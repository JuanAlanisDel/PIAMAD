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
        public DataTable N_Create_Habitacion(E_Habitacion obje)
        {
            return objd.D_Create_Habitacion(obje);
        }
    }
}
