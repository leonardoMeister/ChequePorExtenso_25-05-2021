using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso
{
    public class Cheque
    {
        public string Escrita { get; private set; }
        public double Valor { get; private set; }
        public Cheque()
        {
            Escrita = "";
            Valor = double.MinValue;
        }
        public Cheque(Double valor)
        {
            Valor = valor;
            CriarString();
        }

        private string CriarString()
        {

            return "";
        }


    }
}
