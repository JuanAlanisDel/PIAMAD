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
    public class D_Hotel
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable D_Create_Hotel(E_Hotel obje)
        {
            SqlCommand cmd = new SqlCommand("CreateHotel", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hotelNom", obje.nombre);
            cmd.Parameters.AddWithValue("@hotelCd", obje.ciudad);
            cmd.Parameters.AddWithValue("@hotelEst", obje.estado);
            cmd.Parameters.AddWithValue("@hotelPais", obje.pais);
            cmd.Parameters.AddWithValue("@hotelDom", obje.domicilio);
            cmd.Parameters.AddWithValue("@numpiso", obje.nopisos);
            cmd.Parameters.AddWithValue("@cantHab", obje.canthabit);
            cmd.Parameters.AddWithValue("@zonaTur", obje.zonatur);
            cmd.Parameters.AddWithValue("@iniOper", value: obje.inioper);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String D_Mantenimiento_Hotel(E_Hotel obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("MantenimientoHotel", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hotelNom", obje.nombre);
            cmd.Parameters.AddWithValue("@hotelCd", obje.ciudad);
            cmd.Parameters.AddWithValue("@hotelEst", obje.estado);
            cmd.Parameters.AddWithValue("@hotelPais", obje.pais);
            cmd.Parameters.AddWithValue("@hotelDom", obje.domicilio);
            cmd.Parameters.AddWithValue("@numpiso", obje.nopisos);
            cmd.Parameters.AddWithValue("@cantHab", obje.canthabit);
            cmd.Parameters.AddWithValue("@zonaTur", obje.zonatur);
            cmd.Parameters.AddWithValue("@iniOper", value: obje.inioper);
            cmd.Parameters.AddWithValue("@hotelId", value: obje.hotelid);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
        public DataTable D_Buscar_Hotel(E_Hotel obje)
        {
            SqlCommand cmd = new SqlCommand("BuscarHotel", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Get_Hotel()
        {
            SqlCommand cmd = new SqlCommand("GetHotel", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Res_Hotel(E_Hotel obje)
        {
            SqlCommand cmd = new SqlCommand("ResHotel", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@buscaCd", obje.ciudad);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
