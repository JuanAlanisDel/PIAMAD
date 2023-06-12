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
    public class D_Reserv
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable D_Create_Reservacion(E_Reserv obje)
        {
            SqlCommand cmd = new SqlCommand("CreateReservacion", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecIni", obje.fecIni);
            cmd.Parameters.AddWithValue("@fecFin", obje.fecFin);
            cmd.Parameters.AddWithValue("resAnt", obje.resAnt);
            cmd.Parameters.AddWithValue("@resCliRFC", obje.resCliRFC);
            cmd.Parameters.AddWithValue("@resHotelId", obje.resHotelId);
            cmd.Parameters.AddWithValue("@resCantHab", obje.resCantHab);
            cmd.Parameters.AddWithValue("@resCantPer", obje.resCantPer);
            cmd.Parameters.AddWithValue("@resHabId", obje.resHabId);
            cmd.Parameters.AddWithValue("@resMetodo", obje.resMetodo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String D_Mantenimiento_Reservacion(E_Reserv obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("MantenimientoReservacion", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecIni", obje.fecIni);
            cmd.Parameters.AddWithValue("@fecFin", obje.fecFin);
            cmd.Parameters.AddWithValue("resAnt", obje.resAnt);
            cmd.Parameters.AddWithValue("@resCliRFC", obje.resCliRFC);
            cmd.Parameters.AddWithValue("@resHotelId", obje.resHotelId);
            cmd.Parameters.AddWithValue("@resHabId", obje.resHabId);
            cmd.Parameters.AddWithValue("@resMetodo", obje.resMetodo);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
        public DataTable D_Buscar_Reservacion(E_Reserv obje)
        {
            SqlCommand cmd = new SqlCommand("BuscarReserv", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@resCod", obje.resCod);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Get_Reservacion()
        {
            SqlCommand cmd = new SqlCommand("GetHabitacion", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
