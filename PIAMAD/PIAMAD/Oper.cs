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
    public partial class Oper : Form
    {
        public Oper()
        {
            InitializeComponent();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegClientes RegClientes = new RegClientes();
            RegClientes.ShowDialog();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModClientes ModClientes = new ModClientes();
            ModClientes.ShowDialog();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliClientes EliClientes = new EliClientes();
            EliClientes.ShowDialog();
        }

        private void realizarReservToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservacion reservacion = new Reservacion();
            reservacion.ShowDialog();
        }
    }
}
