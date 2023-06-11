using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class D_Habitacion
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable D_Create_Habitacion(E_Habitacion obje)
        {
            SqlCommand cmd = new SqlCommand("CreateHabitacion", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@habNivel", obje.habNivel);
            cmd.Parameters.AddWithValue("@habCarac", obje.habCarac);
            cmd.Parameters.AddWithValue("habAmen", obje.habAmen);
            cmd.Parameters.AddWithValue("@habCam", obje.habCam);
            cmd.Parameters.AddWithValue("@numCama", obje.numCama);
            cmd.Parameters.AddWithValue("@habCantPer", obje.habCantPer);
            cmd.Parameters.AddWithValue("@habPrecio", obje.habPrecio);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
