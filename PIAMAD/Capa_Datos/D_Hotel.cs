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
    }
}
