using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PIAMAD
{
    public partial class ModUsu : Form
    {
        E_Usuario objeusuario = new E_Usuario();
        N_Usuario objnusuario = new N_Usuario();
        Admin frm1 = new Admin();
        public static string correo;
        void mantenimiento(String accion)
        {
            objeusuario.correo = textCorreo.Text;
            objeusuario.password = textPassword.Text;
            objeusuario.nombre = textNombre.Text;
            objeusuario.domicilio = textDomicilio.Text;
            objeusuario.rol = comboRol.Text;
            objeusuario.estatus = comboEstatus.Text;
            objeusuario.accion = accion;
            string formato = "dd/MM/yyyy";
            DateTime fecha = DateTime.ParseExact(fechaNac.Text, formato, CultureInfo.InvariantCulture);
            objeusuario.fechaNac = fecha.ToString();
            objeusuario.telefono = Convert.ToInt32(textTelefono.Text);
            String men = objnusuario.N_Mantenimiento_Usuarios(objeusuario);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public ModUsu()
        {
            InitializeComponent();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                objeusuario.nomina = Convert.ToInt32(textBuscar.Text);
                DataTable dt = new DataTable();
                dt = objnusuario.N_Buscar_Usuarios(objeusuario);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objnusuario.N_Get_Usuarios();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textNomina.Text = row.Cells["nomina"].Value.ToString();
            textCorreo.Text = row.Cells["correo"].Value.ToString();
            textPassword.Text = row.Cells["password"].Value.ToString();
            textNombre.Text = row.Cells["usuNom"].Value.ToString();
            textDomicilio.Text = row.Cells["usudom"].Value.ToString();
            comboRol.Text = row.Cells["nombre_tipo"].Value.ToString();
                comboEstatus.Text = row.Cells["nombre_estatus"].Value.ToString();
                textTelefono.Text = row.Cells["usutel"].Value.ToString();
                fechaNac.Text = row.Cells["usuNac"].Value.ToString();
            }
        }
        void limpiar()
        {
            textNomina.Text = "";
            textCorreo.Text = "";
            textPassword.Text = "";
            textTelefono.Text = "";
            textNombre.Text = "";
            textDomicilio.Text = "";
            textBuscar.Text = "";
            dataGridView1.DataSource = objnusuario.N_Get_Usuarios();
        }
        private void ModUsu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objnusuario.N_Get_Usuarios();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + textNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
            
        }
    }
}
