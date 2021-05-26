using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.Dominio
{
    public class Simples : ConversorBase
    {
        public Simples()
        {

        }
        public Simples(int centena, int dezena, int unidade)
        {
            this.Centena = centena;
            this.Dezena = dezena;
            this.Unidade = unidade;
        }

        public override string StringUnidade()
        {
            switch (Unidade)
            {
                case 0: return "";
                case 1: return "Um";
                case 2: return "Dois";
                case 3: return "Três";
                case 4: return "Quatro";
                case 5: return "Cinco";
                case 6: return "Seis";
                case 7: return "Sete";
                case 8: return "Oito";
                case 9: return "Nove";
                default: return "Erro";
            }
        }
        protected override string DezenaComUm()
        {
            switch (Unidade)
            {
                case 0: return "Dez";
                case 1: return "Onze";
                case 2: return "Doze";
                case 3: return "Treze";
                case 4: return "Quatorze";
                case 5: return "Quinze";
                case 6: return "Dezesseis";
                case 7: return "Dezessete";
                case 8: return "Dezoito";
                case 9: return "Dezenove";
                default: return "Erro";
            }
        }
    }
}
