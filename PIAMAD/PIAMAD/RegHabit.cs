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
            objehabitacion.habNivel = comboNivel.Text;
            objehabitacion.habCarac = textCarac.Text;
            objehabitacion.habAmen = textAmen.Text;
            objehabitacion.habCam = comboTipos.Text;
            objehabitacion.numCama = Convert.ToInt32(noCamas.Text);
            objehabitacion.habCantPer = Convert.ToInt32(cantPer.Text);
            objehabitacion.habPrecio = Convert.ToSingle(preNocPer.Text);
            dt = objnhabitacion.N_Create_Habitacion(objehabitacion);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Se encontró el correo y la contraseña en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correo = dt.Rows[0][1].ToString();
                textCarac.Clear();
                textAmen.Clear();
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
                    textCarac.Clear();
                    textAmen.Clear();
                }
            }
        }
        public RegHabit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro();
        }
    }
}
