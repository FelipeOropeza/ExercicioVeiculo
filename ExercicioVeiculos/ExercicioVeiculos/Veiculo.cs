using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVeiculos
{
    public abstract class Veiculo
    {
        // Criando as variaveis
        private string marca;
        private string tipocombu;
        private string poten;
        private string peso;
        private string placa;
        private string preco;
        private string cambio;
        private string auto;
        private string datafab;
        private string cor;
        private string chassi;

        // Instanciano as variaveis sem parametros
        public Veiculo()
        {
            this.marca = null;
            this.tipocombu = null;
            this.poten = null;
            this.peso = null;
            this.placa = null;
            this.preco = null;
            this.cambio = null;
            this.auto = null;
            this.datafab = null;
            this.cor = null;
            this.chassi = null;
        }

        // Instanciano as variaveis com parametros
        public Veiculo(string marca, string tipocombu, string poten, string peso, string placa, string preco, 
            string cambio, string auto, string datafab, string cor, string chassi)
        {
            this.marca = marca;
            this.tipocombu = tipocombu;
            this.poten = poten;
            this.peso = peso;
            this.placa = placa;
            this.preco = preco;
            this.cambio = cambio;
            this.auto = auto;
            this.datafab = datafab;
            this.cor = cor;
            this.chassi = chassi;
        }

        // Aplicando os get e set nas variaveis
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public String TipoCombu
        {
            get { return tipocombu; }
            set { tipocombu = value; }
        }
        public String Poten
        {
            get { return poten; }
            set { poten = value; }
        }
        public String Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public String Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public String Cambio
        {
            get { return cambio; }
            set{ cambio = value;  }
        }
        public String Auto
        {
            get { return auto; }
            set { auto = value; }
        }
        public String Datafab
        {
            get { return datafab; }
            set { datafab = value; }
        }
        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public String Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }

        // Aplicando o método ImpimeDados
        public abstract String ImprimeDados();
    }
}
