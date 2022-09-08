using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVeiculos
{
    public class Carro : Veiculo
    {
        private string numpassa;
        private string carroce;
        private string numport;
        private string capaport;

        public Carro(){
            this.numpassa = null;
            this.carroce = null;
            this.numport = null;
            this.capaport = null;
        }
        public Carro(string marca, string tipocombu, string poten, string peso, string placa, string preco,
            string cambio, string auto, string datafab, string cor, string chassi, string numpassa, string carroce, string numport, string capaport)
        {
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
            this.NumPassa = numpassa;
            this.Carroce = carroce;
            this.NumPort = numport;
            this.CapaPort = capaport;
        }
        public String NumPassa
        {
            get { return numpassa; }
            set { numpassa = value; }
        }
        public String Carroce
        {
            get { return carroce; }
            set { carroce = value; }
        }
        public String NumPort
        {
            get { return numport; }
            set { numport = value; }
        }
        public string CapaPort
        {
            get { return capaport; }
            set { capaport = value; }
        }

        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Marca, "", this.TipoCombu, "", this.Poten, "", this.Peso, "", this.Placa, "", this.Preco, "", this.Cambio,
                this.Auto,"", this.Datafab, "", this.Cor, "", this.Chassi, "", this.NumPassa, "", this.Carroce, "", this.NumPort, "", this.CapaPort);
            return s;
        }
    }
}
