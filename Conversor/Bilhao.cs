using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.Dominio
{
    public class Bilhao : ConversorBase
    {
        public Bilhao()
        {

        }
        public Bilhao(int centena, int dezena, int unidade)
        {
            this.Centena = centena;
            this.Dezena = dezena;
            this.Unidade = unidade;
        }
        private string UnidadeComDezenaECentenaZero()
        {
            if (Dezena == 0 && Centena == 0)
            {
                return "Bilhão";
            }
            else return "Bilhões";
        }
        public override string StringUnidade()
        {
            switch (Unidade)
            {
                case 0: return "Bilhões";
                case 1: return $"Um {UnidadeComDezenaECentenaZero()}";
                case 2: return "Dois Bilhões";
                case 3: return "Três Bilhões";
                case 4: return "Quatro Bilhões";
                case 5: return "Cinco Bilhões";
                case 6: return "Seis Bilhões";
                case 7: return "Sete Bilhões";
                case 8: return "Oito Bilhões";
                case 9: return "Nove Bilhões";
                default: return "Erro";
            }
        }
        protected override string DezenaComUm()
        {
            switch (Unidade)
            {
                case 0: return "Dez Bilhões";
                case 1: return "Onze Bilhões";
                case 2: return "Doze Bilhões";
                case 3: return "Treze Bilhões";
                case 4: return "Quatorze Bilhões";
                case 5: return "Quinze Bilhões";
                case 6: return "Dezesseis Bilhões";
                case 7: return "Dezessete Bilhões";
                case 8: return "Dezoito Bilhões";
                case 9: return "Dezenove Bilhões";
                default: return "Erro";
            }
        }
    }
}
