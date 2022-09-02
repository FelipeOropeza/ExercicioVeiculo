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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            frmCarro carro = new frmCarro();
            this.Hide();
            carro.Show();
        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            frmCaminhao caminhao = new frmCaminhao();
            this.Hide();
            caminhao.Show();

        }
    }
}
