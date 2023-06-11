using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIAMAD
{
    public partial class RegUsu : Form
    {
        E_Usuario objeusuario = new E_Usuario();
        N_Usuario objnusuario = new N_Usuario();
        InicioSesion frm1 = new InicioSesion();
        public static string correo;
        public static string area;

        void registro()
        {
            DataTable dt = new DataTable();
            objeusuario.correo = textCorreo.Text;
            objeusuario.password = textPassword.Text;
            objeusuario.nombre = textNombre.Text;
            objeusuario.nomina = Convert.ToInt32(textNomina.Text);
            objeusuario.domicilio = textDomicilio.Text;
            objeusuario.rol = comboRol.Text;
            objeusuario.fechaNac = fechaNac.Text;
            objeusuario.telefono = Convert.ToInt32(textTelefono.Text);
            dt = objnusuario.N_Usuarios(objeusuario);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Se encontró el correo y la contraseña en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correo = dt.Rows[0][1].ToString();
                //area = dt.Rows[0][2].ToString();
                frm1.ShowDialog();
                RegUsu regusu = new RegUsu();
                regusu.ShowDialog();
                if(regusu.DialogResult == DialogResult.OK)
                {
                    Application.Run(new InicioSesion());
                    textCorreo.Clear();
                    textPassword.Clear();
                    textNombre.Clear();
                    textNomina.Clear();
                    textDomicilio.Clear();
                }
            }
            else
            {
                MessageBox.Show("No se encontraron similitudes con la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public RegUsu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrar_Click_1(object sender, EventArgs e)
        {
            registro();
        }
    }
}
