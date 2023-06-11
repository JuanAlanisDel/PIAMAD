using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;
namespace Capa_Datos
{
    public class D_Usuario
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable D_Create_Usuarios(E_Usuario obje)
        {
            SqlCommand cmd = new SqlCommand("CreateUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@correo", obje.correo);
            cmd.Parameters.AddWithValue("@password", obje.password);
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            cmd.Parameters.AddWithValue("@nomina", obje.nomina);
            cmd.Parameters.AddWithValue("@usudom", obje.domicilio);
            cmd.Parameters.AddWithValue("@id_tipo", obje.rol);
            cmd.Parameters.AddWithValue("@usuNac", obje.fechaNac);
            cmd.Parameters.AddWithValue("@usutel", obje.telefono);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Get_Usuarios(E_Usuario obje)
        {
            SqlCommand cmd = new SqlCommand("GetUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@correo", obje.correo);
            cmd.Parameters.AddWithValue("@password", obje.password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
