using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso
{
    public abstract class ConversorBase
    {

        protected int Centena { get; set; }
        protected int Dezena { get; set; }
        protected int Unidade { get; set; }
        public string ValorPorEscrito { get; set; }

        protected virtual string DezenaComUm()
        {
            return "";
        }
        public string StringDezena()
        {
            switch (Dezena)
            {
                case 0: return "";
                case 1: return DezenaComUm();
                case 2: return "Vinte";
                case 3: return "Trinta";
                case 4: return "Quarenta";
                case 5: return "Cinquenta";
                case 6: return "Sessenta";
                case 7: return "Setenta";
                case 8: return "Oitenta";
                case 9: return "Noventa";
                default: return "Erro";
            }
        }
        protected string CentenaComUm()
        {
            switch (Dezena)
            {
                case 0: return "";
                case 1: return DezenaComUm();
                case 2: return "Vinte";
                case 3: return "Trinta";
                case 4: return "Quarenta";
                case 5: return "Cinquenta";
                case 6: return "Sessenta";
                case 7: return "Setenta";
                case 8: return "Oitenta";
                case 9: return "Noventa";
                default: return "Erro";
            }
        }

        public string StringCentena()
        {
            switch (Centena)
            {
                case 0: return "";
                case 1: return "Cento e " + CentenaComUm();
                case 2: return "Duzentos";
                case 3: return "Trezentos";
                case 4: return "Quatrocentos";
                case 5: return "Quinhentos";
                case 6: return "seiscentos";
                case 7: return "setecentos";
                case 8: return "oitocentos";
                case 9: return "Novecentos";
                default: return "Erro";
            }
        }
        public virtual string StringUnidade()
        {
            return "";
        }
    }

}
