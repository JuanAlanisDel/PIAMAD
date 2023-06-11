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
    public class N_Hotel
    {
        D_Hotel objd = new D_Hotel();
        public DataTable N_Create_Hotel(E_Hotel obje)
        {
            return objd.D_Create_Hotel(obje);
        }
        /*public DataTable N_Get_Hotel(E_Hotel obje)
        {
            return objd.D_Get_Hotel(obje);
        }*/
    }
}
