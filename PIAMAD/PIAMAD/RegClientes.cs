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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PIAMAD
{
    public partial class RegClientes : Form
    {
        E_Cliente objecliente = new E_Cliente();
        N_Cliente objncliente = new N_Cliente();
        Oper frm1 = new Oper();
        public static string correo;

        void registro()
        {
            DataTable dt = new DataTable();
            objecliente.nombre = textNombre.Text;
            objecliente.domicilio = textDomicilio.Text;
            objecliente.rfc = textRfc.Text;
            objecliente.correo = textCorreo.Text;
            objecliente.telefono = Convert.ToInt32(textTelefono.Text);
            objecliente.estadocivil = textEstadoCivil.Text;
            objecliente.referencia = textReferencia.Text;
            objecliente.fechaNac = fechaNac.Text;
            dt = objncliente.N_Create_Cliente(objecliente);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Se encontró el correo y la contraseña en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correo = dt.Rows[0][1].ToString();
                textNombre.Clear();
                textDomicilio.Clear();
                textRfc.Clear();
                textCorreo.Clear();
                textReferencia.Clear();
                textTelefono.Clear();
                textEstadoCivil.Clear();
            }
            else
            {
                MessageBox.Show("No se encontraron similitudes con la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm1.ShowDialog();
                RegUsu regusu = new RegUsu();
                regusu.ShowDialog();
                if (regusu.DialogResult == DialogResult.OK)
                {
                    Application.Run(new Oper());
                    textNombre.Clear();
                    textDomicilio.Clear();
                    textRfc.Clear();
                    textCorreo.Clear();
                    textTelefono.Clear();
                    textReferencia.Clear();
                    textEstadoCivil.Clear();
                }
            }
        }

        public RegClientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registro();
        }
    }
}
