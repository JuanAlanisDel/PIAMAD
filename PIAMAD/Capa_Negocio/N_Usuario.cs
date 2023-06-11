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
        public DataTable N_Usuarios(E_Usuario obje)
        {
            return objd.D_Usuarios(obje);
        }
    }
}
