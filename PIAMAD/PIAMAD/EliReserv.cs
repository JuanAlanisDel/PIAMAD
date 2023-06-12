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
    public partial class EliReserv : Form
    {
        E_Hotel objehotel = new E_Hotel();
        N_Hotel objnhotel = new N_Hotel();
        E_Cliente objecliente = new E_Cliente();
        N_Cliente objncliente = new N_Cliente();
        E_Habitacion objehabitacion = new E_Habitacion();
        N_Habitacion objnhabitacion = new N_Habitacion();
        E_Reserv objereserv = new E_Reserv();
        N_Reserv objnreserv = new N_Reserv();
        Oper frm1 = new Oper();
        public static string nombre;
        void mantenimiento(String accion)
        {
            objereserv.resCliRFC = textId.Text;
            objereserv.resHotelId = Convert.ToInt32(textId2.Text);
            objereserv.resHabId = Convert.ToInt32(textId3.Text);
            objereserv.resCantHab = Convert.ToInt32(cantHabTipo.Text);
            objereserv.resCantPer = Convert.ToInt32(cantPerHosp.Text);
            objereserv.resAnt = Convert.ToSingle(anticipoRes.Text);
            objereserv.resMetodo = comboPago.Text;
            String men = objnhabitacion.N_Mantenimiento_Habitacion(objehabitacion);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public EliReserv()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
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

        private void EliReserv_Load(object sender, EventArgs e)
        {
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
    }
}
