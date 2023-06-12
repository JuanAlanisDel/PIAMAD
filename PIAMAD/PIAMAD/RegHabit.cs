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
        E_Hotel objehotel = new E_Hotel();
        N_Hotel objnhotel = new N_Hotel();
        E_Habitacion objehabitacion = new E_Habitacion();
        N_Habitacion objnhabitacion = new N_Habitacion();
        Admin frm1 = new Admin();
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
            objehabitacion.hotelId = Convert.ToInt32(textId.Text);
            dt = objnhabitacion.N_Create_Habitacion(objehabitacion);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Se encontró el correo y la contraseña en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correo = dt.Rows[0][1].ToString();
                textCarac.Text = "";
                textAmen.Text = "";
                textId.Text = "";
            }
            else
            {
                MessageBox.Show("No se encontraron similitudes con la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textId.Text = row.Cells["hotelId"].Value.ToString();
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                objehotel.nombre = textBuscar.Text;
                DataTable dt = new DataTable();
                dt = objnhotel.N_Buscar_Hotel(objehotel);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objnhotel.N_Get_Hotel();

            }
        }

        private void RegHabit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objnhotel.N_Get_Hotel();
        }
    }
}
