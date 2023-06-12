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
    public partial class EliHabit : Form
    {
        E_Habitacion objehabitacion = new E_Habitacion();
        N_Habitacion objnhabitacion = new N_Habitacion();
        Admin frm1 = new Admin();
        public static string correo;
        void mantenimiento(String accion)
        {
            objehabitacion.habNivel = comboNivel.Text;
            objehabitacion.habCarac = textCarac.Text;
            objehabitacion.habAmen = textAmen.Text;
            objehabitacion.habCam = comboTipos.Text;
            objehabitacion.numCama = Convert.ToInt32(noCamas.Text);
            objehabitacion.habCantPer = Convert.ToInt32(cantPer.Text);
            objehabitacion.habPrecio = Convert.ToSingle(preNocPer.Text);
            objehabitacion.habId = Convert.ToInt32(textId.Text);
            objehabitacion.accion = accion;
            String men = objnhabitacion.N_Mantenimiento_Habitacion(objehabitacion);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public EliHabit()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                comboNivel.Text = row.Cells["habNivel"].Value.ToString();
                textCarac.Text = row.Cells["habCarac"].Value.ToString();
                textAmen.Text = row.Cells["habAmen"].Value.ToString();
                comboTipos.Text = row.Cells["habCam"].Value.ToString();
                noCamas.Text = row.Cells["numCama"].Value.ToString();
                cantPer.Text = row.Cells["habCantPer"].Value.ToString();
                preNocPer.Text = row.Cells["habPrecio"].Value.ToString();
                textId.Text = row.Cells["habId"].Value.ToString();
            }
        }

        private void EliHabit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objnhabitacion.N_Get_Habitacion();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + textId.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }
        void limpiar()
        {
            textCarac.Text = "";
            textAmen.Text = "";
            noCamas.Text = "";
            cantPer.Text = "";
            preNocPer.Text = "";
            textId.Text = "";
            dataGridView1.DataSource = objnhabitacion.N_Get_Habitacion();
        }
        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                objehabitacion.habId = Convert.ToInt32(textBuscar.Text);
                DataTable dt = new DataTable();
                dt = objnhabitacion.N_Buscar_Habitacion(objehabitacion);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objnhabitacion.N_Get_Habitacion();

            }
        }
    }
}
