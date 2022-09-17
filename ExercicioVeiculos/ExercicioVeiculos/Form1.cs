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

        // Fazendo o botão para sair da aplicação
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Fazendo o botão para entrar no cadastro do carro
        private void btnCarro_Click(object sender, EventArgs e)
        {
            frmCarro carro = new frmCarro();
            this.Hide();
            carro.Show();
        }

        // Fazendo o botão para entrar no cadastro do caminhão
        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            frmCaminhao caminhao = new frmCaminhao();
            this.Hide();
            caminhao.Show();

        }
    }
}
