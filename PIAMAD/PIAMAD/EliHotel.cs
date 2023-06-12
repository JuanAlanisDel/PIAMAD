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
using static System.Net.Mime.MediaTypeNames;

namespace PIAMAD
{
    public partial class EliHotel : Form
    {
        E_Hotel objehotel = new E_Hotel();
        N_Hotel objnhotel = new N_Hotel();
        Admin frm1 = new Admin();
        public static string correo;
        void mantenimiento(String accion)
        {
            objehotel.nombre = textNombre.Text;
            objehotel.ciudad = textCiudad.Text;
            objehotel.estado = textEstado.Text;
            objehotel.pais = textPais.Text;
            objehotel.domicilio = textDomicilio.Text;
            objehotel.zonatur = textZonaTur.Text;
            objehotel.canthabit = Convert.ToInt32(cantHab.Text);
            objehotel.nopisos = Convert.ToInt32(noPisos.Text);
            objehotel.hotelid = Convert.ToInt32(textId.Text);
            objehotel.accion = accion;
            string formato = "dd/MM/yyyy";
            DateTime fecha = DateTime.ParseExact(inioper.Text, formato, CultureInfo.InvariantCulture);
            objehotel.inioper = fecha.ToString();
            String men = objnhotel.N_Mantenimiento_Hotel(objehotel);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public EliHotel()
        {
            InitializeComponent();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + textNombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void EliHotel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objnhotel.N_Get_Hotel();
        }
        void limpiar()
        {
            textNombre.Text = "";
            textDomicilio.Text = "";
            textZonaTur.Text = "";
            textCiudad.Text = "";
            textEstado.Text = "";
            textPais.Text = "";
            textId.Text = "";
            dataGridView1.DataSource = objnhotel.N_Get_Hotel();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                noPisos.Text = row.Cells["numpiso"].Value.ToString();
                cantHab.Text = row.Cells["cantHab"].Value.ToString();
                textNombre.Text = row.Cells["hotelNom"].Value.ToString();
                textDomicilio.Text = row.Cells["hotelDom"].Value.ToString();
                textZonaTur.Text = row.Cells["zonaTur"].Value.ToString();
                textCiudad.Text = row.Cells["hotelCd"].Value.ToString();
                textEstado.Text = row.Cells["hotelEst"].Value.ToString();
                textPais.Text = row.Cells["hotelPais"].Value.ToString();
                inioper.Text = row.Cells["iniOper"].Value.ToString();
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
    }
}
