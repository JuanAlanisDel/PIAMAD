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
    public class N_Cliente
    {
        D_Cliente objd = new D_Cliente();
        public DataTable N_Create_Cliente(E_Cliente obje)
        {
            return objd.D_Create_Cliente(obje);
        }
        public String N_Mantenimiento_Cliente(E_Cliente obje)
        {
            return objd.D_Mantenimiento_Cliente(obje);
        }
        public DataTable N_Buscar_Cliente_PRFC(E_Cliente obje)
        {
            return objd.D_Buscar_Cliente_PRFC(obje);
        }
        public DataTable N_Buscar_Cliente_PCor(E_Cliente obje)
        {
            return objd.D_Buscar_Cliente_PCor(obje);
        }
        public DataTable N_Res_Cliente(E_Cliente obje)
        {
            return objd.D_Res_Cliente(obje);
        }
        public DataTable N_Get_Cliente()
        {
            return objd.D_Get_Cliente();
        }
    }
}
