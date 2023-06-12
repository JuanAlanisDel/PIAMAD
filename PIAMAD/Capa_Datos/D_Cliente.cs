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
    public class D_Cliente
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable D_Create_Cliente(E_Cliente obje)
        {
            SqlCommand cmd = new SqlCommand("CreateCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliCor", obje.correo);
            cmd.Parameters.AddWithValue("@RFC", obje.rfc);
            cmd.Parameters.AddWithValue("@CliNomCom", obje.nombre);
            cmd.Parameters.AddWithValue("@cliEstCiv", obje.estadocivil);
            cmd.Parameters.AddWithValue("@cliDom", obje.domicilio);
            cmd.Parameters.AddWithValue("@cliRef", obje.referencia);
            cmd.Parameters.AddWithValue("@cliNac", obje.fechaNac);
            cmd.Parameters.AddWithValue("@cliTel", obje.telefono);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String D_Mantenimiento_Cliente(E_Cliente obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("MantenimientoCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliCor", obje.correo);
            cmd.Parameters.AddWithValue("@RFC", obje.rfc);
            cmd.Parameters.AddWithValue("@CliNomCom", obje.nombre);
            cmd.Parameters.AddWithValue("@cliEstCiv", obje.estadocivil);
            cmd.Parameters.AddWithValue("@cliDom", obje.domicilio);
            cmd.Parameters.AddWithValue("@cliRef", obje.referencia);
            cmd.Parameters.AddWithValue("@cliNac", obje.fechaNac);
            cmd.Parameters.AddWithValue("@cliTel", obje.telefono);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
        public DataTable D_Buscar_Cliente_PRFC(E_Cliente obje)
        {
            SqlCommand cmd = new SqlCommand("BuscarClientePRFC", cn);
            cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RFC", obje.rfc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Buscar_Cliente_PCor(E_Cliente obje)
        {
            SqlCommand cmd = new SqlCommand("BuscarClientePRFC", cn);
            cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cliCor", obje.correo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Res_Cliente(E_Cliente obje)
        {
            SqlCommand cmd = new SqlCommand("ResCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@busca", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable D_Get_Cliente()
        {
            SqlCommand cmd = new SqlCommand("GetCliente", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
