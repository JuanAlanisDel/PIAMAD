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
            cmd.Parameters.AddWithValue("@hotelId", obje.hotelId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String D_Mantenimiento_Habitacion(E_Habitacion obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("MantenimientoHabitacion", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@habNivel", obje.habNivel);
            cmd.Parameters.AddWithValue("@habCarac", obje.habCarac);
            cmd.Parameters.AddWithValue("habAmen", obje.habAmen);
            cmd.Parameters.AddWithValue("@habCam", obje.habCam);
            cmd.Parameters.AddWithValue("@numCama", obje.numCama);
            cmd.Parameters.AddWithValue("@habCantPer", obje.habCantPer);
            cmd.Parameters.AddWithValue("@habPrecio", obje.habPrecio);
            cmd.Parameters.AddWithValue("@habId", obje.habId);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
        public DataTable D_Buscar_Habitacion(E_Habitacion obje)
        {
            SqlCommand cmd = new SqlCommand("BuscarHabitacion", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@habId", obje.habId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Get_Habitacion()
        {
            SqlCommand cmd = new SqlCommand("GetHabitacion", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
