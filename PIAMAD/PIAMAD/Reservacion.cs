using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PIAMAD
{
    public partial class Reservacion : Form
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
        void registro()
        {
            DataTable dt = new DataTable();
            objereserv.resCliRFC = textId.Text;
            objereserv.resHotelId = Convert.ToInt32(textId2.Text);
            objereserv.resHabId = Convert.ToInt32(textId3.Text);
            objereserv.resCantHab = Convert.ToInt32(cantHabTipo.Text);
            objereserv.resCantPer = Convert.ToInt32(cantPerHosp.Text);
            objereserv.resAnt = Convert.ToSingle(anticipoRes.Text);
            objereserv.resMetodo = comboPago.Text;
            string formato = "dd/MM/yyyy";
            DateTime fecha = DateTime.ParseExact(dateTimePicker1.Text, formato, CultureInfo.InvariantCulture);
            objereserv.fecIni = fecha.ToString();
            DateTime fecha2 = DateTime.ParseExact(dateTimePicker2.Text, formato, CultureInfo.InvariantCulture);
            objereserv.fecFin = fecha2.ToString();
            dt = objnreserv.N_Create_Reservacion(objereserv);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Se encontró el correo y la contraseña en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nombre = dt.Rows[0][1].ToString();
                //area = dt.Rows[0][2].ToString();
                frm1.ShowDialog();
                Reservacion reservacion = new Reservacion();
                reservacion.ShowDialog();
                if (reservacion.DialogResult == DialogResult.OK)
                {
                    Application.Run(new Oper());
                    textId.Text = "";
                    textId2.Text = "";
                    textId3.Text = "";
                    cantHabTipo.Text = "";
                    cantPerHosp.Text = "";
                    anticipoRes.Text = "";
                }
            }
            else
            {
                MessageBox.Show("No se encontraron similitudes con la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm1.ShowDialog();
                textId.Text = "";
                textId2.Text = "";
                textId3.Text = "";
                cantHabTipo.Text = "";
                cantPerHosp.Text = "";
                anticipoRes.Text = "";
            }
        }
        public Reservacion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textId.Text = row.Cells["RFC"].Value.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textId2.Text = row.Cells["hotelId"].Value.ToString();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (textId2.Text != "")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                    textId3.Text = row.Cells["habId"].Value.ToString();
                    if (textId2.Text != row.Cells["hotelId"].Value.ToString())
                    {
                        MessageBox.Show("La habitacion elegida no se encuentra ligada al hotel elegido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                objecliente.nombre = textBuscar.Text;
                DataTable dt = new DataTable();
                dt = objncliente.N_Res_Cliente(objecliente);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objncliente.N_Get_Cliente();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar2.Text != "")
            {
                objehotel.ciudad = textBuscar2.Text;
                DataTable dt = new DataTable();
                dt = objnhotel.N_Res_Hotel(objehotel);
                dataGridView2.DataSource = dt;
            }
            else
            {
                dataGridView2.DataSource = objnhotel.N_Get_Hotel();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Reservacion_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objncliente.N_Get_Cliente();
            dataGridView2.DataSource = objnhotel.N_Get_Hotel();
            dataGridView3.DataSource = objnhabitacion.N_Get_Habitacion();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registro();
        }
    }
}
