using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVeiculos
{
    internal class Caminhao: Veiculo
    {
        // Criando as variaveis
        private string tipocarga;
        private string altura;
        private string numrodas;
        private string capacidade;
        private string tipocabines;

        // Instanciano as variaveis sem parametros
        public Caminhao()
        {
            this.tipocarga = null;
            this.altura = null;
            this.numrodas = null;
            this.capacidade = null;
            this.tipocabines = null;
        }

        // Instanciano as variaveis com parametros
        public Caminhao(string marca, string tipocombu, string poten, string peso, string placa, string preco,
            string cambio, string auto, string datafab, string cor, string chassi, string tipocarga, string altura,
            string numrodas, string capacidade, string tipocabines) {

            this.Marca = marca;
            this.TipoCombu = tipocombu;
            this.Poten = poten;
            this.Peso = peso;
            this.Placa = placa;
            this.Preco = preco;
            this.Cambio = cambio;
            this.Auto = auto;
            this.Datafab = datafab;
            this.Cor = cor;
            this.Chassi = chassi;
            this.Tipocarga = tipocarga; 
            this.Altura = altura;
            this.Numrodas = numrodas;
            this.Capacidade = capacidade;
            this.Tipocabines = tipocabines;
        }

        // Aplicando os get e set nas variaveis
        public String Tipocarga
        {
            get { return this.tipocarga; }
            set { this.tipocarga = value; }
        }
        public String Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }
        public String Numrodas
        {
            get { return this.numrodas; }
            set { this.numrodas = value; }
        }
        public String Capacidade
        {
            get { return this.capacidade; }
            set { this.capacidade = value; }
        }
        public String Tipocabines
        {
            get { return this.tipocabines; }
            set { this.tipocabines = value; }
        }

        // Faz a concatenacão das variaveis e retorna para o ImprimeDados
        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat("Marca: " + this.Marca, "\n", "Tipo do Combustível: " + this.TipoCombu, "\n", "Potência: " + this.Poten, "\n", "Peso: " + this.Peso, "\n", "Placa: " + this.Placa, "\n", "Preço: R$" + this.Preco, "\n", "Câmbio: " + this.Cambio, "\n",
                "Autonomia: " + this.Auto, "\n", "Data de Fabricação: " + this.Datafab, "\n", "Cor: " + this.Cor, "\n", "Chassi: " + this.Chassi, "\n", "Tipo de Carga: " + this.Tipocarga, "\n", "Altura: " + this.Altura, "\n", "Número de Rodas: " + this.Numrodas, "\n", "Capacidade: " + this.Capacidade, "\n", "Tipo de Cabine: " + this.Tipocabines);
            return s;
        }
    }
    
    
}
