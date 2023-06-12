using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace PIAMAD
{
    public partial class InicioSesion : Form
    {
        E_Usuario objeusuario = new E_Usuario();
        N_Usuario objnusuario = new N_Usuario();
        Admin frm1 = new Admin();
        Oper frm2 = new Oper();
        public static string correo;
        public static string area;
        void login()
        {
            DataTable dt = new DataTable();
            objeusuario.correo = textCorreo.Text;
            objeusuario.password = textPassword.Text;
            dt = objnusuario.N_Login_Usuarios(objeusuario);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Se encontró el correo y la contraseña en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correo = dt.Rows[0][1].ToString();
                area = dt.Rows[0][0].ToString();
                if (area == "0")
                {
                    frm1.ShowDialog();
                    if (DialogResult == DialogResult.OK)
                    {
                        Application.Run(new Admin());
                        textCorreo.Clear();
                        textPassword.Clear();
                    }
                }
                else if (area == "1")
                {
                    frm2.ShowDialog();
                    if (DialogResult == DialogResult.OK)
                    {
                        Application.Run(new Oper());
                        textCorreo.Clear();
                        textPassword.Clear();
                    }
                }
                
                
            }
            else
            {
                MessageBox.Show("No se encontraron similitudes con la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCorreo.Clear();
                textPassword.Clear();
            }
        }
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ingresar_Click_1(object sender, EventArgs e)
        {
            login();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegUsu RegUsu = new RegUsu();
            RegUsu.ShowDialog();
        }
    }
}
