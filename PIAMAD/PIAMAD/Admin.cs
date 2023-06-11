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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void registrarHotel_Click(object sender, EventArgs e)
        {
            RegHotel RegHotel = new RegHotel();
            RegHotel.ShowDialog();
        }

        private void modificarHotel_Click(object sender, EventArgs e)
        {

        }

        private void eliminarHotel_Click(object sender, EventArgs e)
        {

        }

        private void registrarHabit_Click(object sender, EventArgs e)
        {

        }

        private void modificarHabit_Click(object sender, EventArgs e)
        {

        }

        private void eliminarHabit_Click(object sender, EventArgs e)
        {

        }

        private void cancelarReserv_Click(object sender, EventArgs e)
        {

        }

        private void desbloquearUsuario_Click(object sender, EventArgs e)
        {

        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
