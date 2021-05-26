using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.Dominio
{
    public class Milhao : ConversorBase
    {
        public Milhao()
        {

        }

        public Milhao(int centena, int dezena, int unidade)
        {
            this.Centena = centena;
            this.Dezena = dezena;
            this.Unidade = unidade;
        }
        private string UnidadeComDezenaECentenaZero()
        {
            if (Dezena == 0 && Centena == 0)
            {
                return "Milhão";
            }
            else return "Milhões";
        }
        public override string StringUnidade()
        {
            switch (Unidade)
            {
                case 0: return "Milhões";
                case 1: return $"Um {UnidadeComDezenaECentenaZero()}";
                case 2: return "Dois Milhões";
                case 3: return "Três Milhões";
                case 4: return "Quatro Milhões";
                case 5: return "Cinco Milhões";
                case 6: return "Seis Milhões";
                case 7: return "Sete Milhões";
                case 8: return "Oito Milhões";
                case 9: return "Nove Milhões";
                default: return "Erro";
            }
        }
        protected override string DezenaComUm()
        {
            switch (Unidade)
            {
                case 0: return "Dez Milhões";
                case 1: return "Onze Milhões";
                case 2: return "Doze Milhões";
                case 3: return "Treze Milhões";
                case 4: return "Quatorze Milhões";
                case 5: return "Quinze Milhões";
                case 6: return "Dezesseis Milhões";
                case 7: return "Dezessete Milhões";
                case 8: return "Dezoito Milhões";
                case 9: return "Dezenove Milhões";
                default: return "Erro";
            }
        }

    }
}
