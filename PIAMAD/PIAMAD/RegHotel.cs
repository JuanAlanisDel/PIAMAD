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
    public partial class RegHotel : Form
    {
        E_Hotel objehotel = new E_Hotel();
        N_Hotel objnhotel = new N_Hotel();
        Admin frm1 = new Admin();
        public static string nombre;
        void registro()
        {
            DataTable dt = new DataTable();
            objehotel.nombre = textNombre.Text;
            objehotel.ciudad = textCiudad.Text;
            objehotel.estado = textEstado.Text;
            objehotel.pais = textPais.Text;
            objehotel.domicilio = textDomicilio.Text;
            objehotel.zonatur = textZonaTur.Text;
            objehotel.canthabit = Convert.ToInt32(cantHab.Text);
            objehotel.nopisos = Convert.ToInt32(noPisos.Text);
            string formato = "dd/MM/yyyy";
            DateTime fecha = DateTime.ParseExact(inioper.Text, formato, CultureInfo.InvariantCulture);
            objehotel.inioper = fecha.ToString();
            //falta Servicios Adicionales
            dt = objnhotel.N_Create_Hotel(objehotel);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Se encontró el correo y la contraseña en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nombre = dt.Rows[0][1].ToString();
                //area = dt.Rows[0][2].ToString();
                frm1.ShowDialog();
                RegHotel reghotel = new RegHotel();
                reghotel.ShowDialog();
                if (reghotel.DialogResult == DialogResult.OK)
                {
                    Application.Run(new Admin());
                    textNombre.Clear();
                    textCiudad.Clear();
                    textEstado.Clear();
                    textPais.Clear();
                    textDomicilio.Clear();
                    textZonaTur.Clear();
                }
            }
            else
            {
                MessageBox.Show("No se encontraron similitudes con la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm1.ShowDialog();
                textNombre.Clear();
                textCiudad.Clear();
                textEstado.Clear();
                textPais.Clear();
                textDomicilio.Clear();
                textZonaTur.Clear();
            }
        }
        public RegHotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //wifi
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //gimnasio
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //masaje
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //restaurante
        }
    }
}
