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
    }
}
