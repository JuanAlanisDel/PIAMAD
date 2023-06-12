using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;
namespace Capa_Negocio
{
    public class N_Usuario
    {
        D_Usuario objd = new D_Usuario();
        public DataTable N_Create_Usuarios(E_Usuario obje)
        {
            return objd.D_Create_Usuarios(obje);
        }
        public String N_Mantenimiento_Usuarios(E_Usuario obje)
        {
            return objd.D_Mantenimiento_Usuarios(obje);
        }
        public DataTable N_Buscar_Usuarios(E_Usuario obje)
        {
            return objd.D_Buscar_Usuarios(obje);
        }
        public DataTable N_Login_Usuarios(E_Usuario obje)
        {
            return objd.D_Login_Usuarios(obje);
        }
        public DataTable N_Get_Usuarios()
        {
            return objd.D_Get_Usuarios();
        }
    }
}
