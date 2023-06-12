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

namespace PIAMAD
{
    public partial class EliClientes : Form
    {
        E_Cliente objecliente = new E_Cliente();
        N_Cliente objncliente = new N_Cliente();
        Admin frm1 = new Admin();
        public static string correo;
        void mantenimiento(String accion)
        {
            objecliente.correo = textCorreo.Text;
            objecliente.rfc = textRfc.Text;
            objecliente.nombre = textNombre.Text;
            objecliente.domicilio = textDomicilio.Text;
            objecliente.estadocivil = textEstadoCivil.Text;
            objecliente.referencia = textReferencia.Text;
            objecliente.accion = accion;
            string formato = "dd/MM/yyyy";
            DateTime fecha = DateTime.ParseExact(fechaNac.Text, formato, CultureInfo.InvariantCulture);
            objecliente.fechaNac = fecha.ToString();
            objecliente.telefono = Convert.ToInt32(textTelefono.Text);
            String men = objncliente.N_Mantenimiento_Cliente(objecliente);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public EliClientes()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textRfc.Text = row.Cells["RFC"].Value.ToString();
                textCorreo.Text = row.Cells["cliCor"].Value.ToString();
                textEstadoCivil.Text = row.Cells["cliEstCiv"].Value.ToString();
                textNombre.Text = row.Cells["cliNomCom"].Value.ToString();
                textDomicilio.Text = row.Cells["cliDom"].Value.ToString();
                textReferencia.Text = row.Cells["cliRef"].Value.ToString();
                textTelefono.Text = row.Cells["cliTel"].Value.ToString();
                fechaNac.Text = row.Cells["cliNac"].Value.ToString();
            }
        }
        void limpiar()
        {
            textRfc.Text = "";
            textCorreo.Text = "";
            textEstadoCivil.Text = "";
            textTelefono.Text = "";
            textNombre.Text = "";
            textDomicilio.Text = "";
            textReferencia.Text = "";
            textBuscar.Text = "";
            //textBuscarCorreo.Text = "";
            dataGridView1.DataSource = objncliente.N_Get_Cliente();
        }
        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                objecliente.rfc = textBuscar.Text;
                DataTable dt = new DataTable();
                dt = objncliente.N_Buscar_Cliente_PRFC(objecliente);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objncliente.N_Get_Cliente();
            }
        }

        private void EliClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objncliente.N_Get_Cliente();
        }
    }
}
