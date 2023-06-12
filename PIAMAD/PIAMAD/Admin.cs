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
            ModHotel ModHotel = new ModHotel();
            ModHotel.ShowDialog();
        }

        private void eliminarHotel_Click(object sender, EventArgs e)
        {
            EliHotel EliHotel = new EliHotel();
            EliHotel.ShowDialog();
        }

        private void registrarHabit_Click(object sender, EventArgs e)
        {
            RegHabit RegHabit = new RegHabit();
            RegHabit.ShowDialog();
        }

        private void modificarHabit_Click(object sender, EventArgs e)
        {
            ModHabit ModHabit = new ModHabit();
            ModHabit.ShowDialog();
        }

        private void eliminarHabit_Click(object sender, EventArgs e)
        {
            EliHabit EliHabit = new EliHabit();
            EliHabit.ShowDialog();
        }

        private void cancelarReserv_Click(object sender, EventArgs e)
        {

        }

        private void desbloquearUsuario_Click(object sender, EventArgs e)
        {

        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModUsu ModUsu = new ModUsu();
            ModUsu.ShowDialog();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliUsu EliUsu = new EliUsu();
            EliUsu.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }
    }
}
