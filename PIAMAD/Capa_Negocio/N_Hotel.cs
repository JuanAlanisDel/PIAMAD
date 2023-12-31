﻿using Capa_Datos;
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
        public String N_Mantenimiento_Hotel(E_Hotel obje)
        {
            return objd.D_Mantenimiento_Hotel(obje);
        }
        public DataTable N_Create_Hotel(E_Hotel obje)
        {
            return objd.D_Create_Hotel(obje);
        }
        public DataTable N_Get_Hotel()
        {
            return objd.D_Get_Hotel();
        }
        public DataTable N_Buscar_Hotel(E_Hotel obje)
        {
            return objd.D_Buscar_Hotel(obje);
        }
        public DataTable N_Res_Hotel(E_Hotel obje)
        {
            return objd.D_Res_Hotel(obje);
        }
    }
}
