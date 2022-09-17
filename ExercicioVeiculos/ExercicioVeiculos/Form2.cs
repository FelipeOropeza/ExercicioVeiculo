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
        Carro carro;
        public frmCarro()
        {
            InitializeComponent();
        }

        // Fazendo botão para volta ao menu principal
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }

        // Atribuindo a data selecionada a caixa de texto
        private void Calendario1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtData.Text = Calendario1.SelectionStart.ToShortDateString();
            Calendario1.Hide();
        }

        // Fazendo o calendario fica visivel
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Calendario1.Visible = true;
        }

        // Criando uma variavel para armazenar o que digitado nas caixas de textos
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            carro = new Carro(txtMarca.Text, txtComb.Text, txtPot.Text, txtPeso.Text, txtPlaca.Text, txtPreco.Text, txtCamb.Text, txtAuto.Text,
            txtData.Text, txtCor.Text, txtChassi.Text, txtNumPassa.Text, txtCarroce.Text, txtNumPort.Text, txtCapPort.Text);
            txtMarca.Clear();
            txtComb.Clear();
            txtPot.Clear();
            txtPeso.Clear();
            txtPlaca.Clear();
            txtPreco.Clear();
            txtCamb.Clear();
            txtAuto.Clear();
            txtData.Clear();
            txtCor.Clear();
            txtChassi.Clear();
            txtNumPassa.Clear();
            txtCarroce.Clear();
            txtNumPort.Clear();
            txtCapPort.Clear();
        }

        // Exibindo os dados cadastrados
        private void btnExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.ImprimeDados());
        }
    }
}
