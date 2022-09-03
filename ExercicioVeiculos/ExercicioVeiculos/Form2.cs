using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioVeiculos
{
    public partial class frmCarro : Form
    {
        public frmCarro()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }

        // atribuindo a data selecionada a caixa de texto
        private void Calendario1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtData.Text = Calendario1.SelectionStart.ToShortDateString();
            Calendario1.Hide();
            
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Calendario1.Visible = true;
        }
    }
}
