using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.Dominio
{
    public class Centavos: ConversorBase
    {
        public Centavos()
        {

        }
        public Centavos( int dezena, int unidade)
        {
            this.Dezena = dezena;
            this.Unidade = unidade;
        }
        private string UnidadeComDezenaECentenaZero()
        {
            if (Dezena == 0)
            {
                return "Centavo";
            }
            else return "Centavos";
        }
        public override string StringUnidade()
        {
            switch (Unidade)
            {
                case 0:
                    return "Centavos";
                case 1:
                    return $"Um {UnidadeComDezenaECentenaZero()}";
                case 2:
                    return "Dois Centavos";
                case 3:
                    return "Três Centavos";
                case 4:
                    return "Quatro Centavos";
                case 5:
                    return "Cinco Centavos";
                case 6:
                    return "Seis Centavos";
                case 7:
                    return "Sete Centavos";
                case 8:
                    return "Oito Centavos";
                case 9:
                    return "Nove Centavos";
                default:
                    return "Erro";
            }
        }
        protected override string DezenaComUm()
        {
            switch (Unidade)
            {
                case 0:
                    return "Dez Centavos";
                case 1:
                    return "Onze Centavos";
                case 2:
                    return "Doze Centavos";
                case 3:
                    return "Treze Centavos";
                case 4:
                    return "Quatorze Centavos";
                case 5:
                    return "Quinze Centavos";
                case 6: 
                    return "Dezesseis Centavos";
                case 7:
                    return "Dezessete Centavos";
                case 8:
                    return "Dezoito Centavos";
                case 9:
                    return "Dezenove Centavos";
                default:
                    return "Erro";
            }
        }
    }
}
