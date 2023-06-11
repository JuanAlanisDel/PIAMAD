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
    }
}
