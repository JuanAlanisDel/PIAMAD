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
    public partial class RegHabit : Form
    {
        E_Habitacion objehabitacion = new E_Habitacion();
        N_Habitacion objnhabitacion = new N_Habitacion();
        Oper frm1 = new Oper();
        public static string correo;

        void registro()
        {
            DataTable dt = new DataTable();
            objehabitacion.nivel = comboNivel.Text;
            objehabitacion.carac = textCarac.Text;
            objehabitacion.amen = textAmen.Text;
            objehabitacion.tiposcamas = comboTipos.Text;
            objehabitacion.nocamas = Convert.ToInt32(noCamas.Text);
            objehabitacion.cantper = Convert.ToInt32(cantPer.Text);
            objehabitacion.perNocPer = Convert.ToInt32(preNocPer.Text);
            objehabitacion.fechaNac = fechaNac.Text;
            dt = objnhabitacion.N_Create_Cliente(objehabitacion);
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
        public RegHabit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
