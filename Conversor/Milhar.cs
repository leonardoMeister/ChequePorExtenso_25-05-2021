using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.Dominio
{
    public class Milhar : ConversorBase
    {
        public Milhar()
        {

        }
        public Milhar(int centena, int dezena, int unidade)
        {
            this.Centena = centena;
            this.Dezena = dezena;
            this.Unidade = unidade;
        }

        public override string StringUnidade()
        {
            switch (Unidade)
            {
                case 0: return "Mil";
                case 1: return "Um Mil";
                case 2: return "Dois Mil";
                case 3: return "Três Mil";
                case 4: return "Quatro Mil";
                case 5: return "Cinco Mil";
                case 6: return "Seis Mil";
                case 7: return "Sete Mil";
                case 8: return "Oito Mil";
                case 9: return "Nove Mil";
                default: return "Erro";
            }
        }
        protected override string DezenaComUm()
        {
            switch (Unidade)
            {
                case 0: return "Dez mil";
                case 1: return "Onze mil";
                case 2: return "Doze mil";
                case 3: return "Treze mil";
                case 4: return "Quatorze mil";
                case 5: return "Quinze mil";
                case 6: return "Dezesseis mil";
                case 7: return "Dezessete mil";
                case 8: return "Dezoito mil";
                case 9: return "Dezenove mil";
                default: return "Erro";
            }
        }
    }
}
