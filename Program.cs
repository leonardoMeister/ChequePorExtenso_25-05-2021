using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChequePorExtenso.Dominio;

namespace ChequePorExtenso
{
    class Program
    {
        static void Main(string[] args)
        { 


            /*              LIXO NÃO MEXER KKKK
            //Conversor converter = new Conversor("911,111,123,231,20");
            //Console.WriteLine(converter.ValorPorExtenso);


            //SolucaoWeb aux = new SolucaoWeb();

            //aux.busqueExtenso(111, " e ");
            */





            /*
                                PODE TESTAR A VONTADE, SÓ PRECISA USAR . PRA SEPARAR E , PARA SEPARAR CENTAVOS
             */

                                                         // 122.911.283,99
            MinhaSolucaoAlternativaDeSucessoSemBug aux = new MinhaSolucaoAlternativaDeSucessoSemBug("2.101.283,99");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

            aux = new MinhaSolucaoAlternativaDeSucessoSemBug("3.222.101.283,11");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

            aux = new MinhaSolucaoAlternativaDeSucessoSemBug("1.283,11");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

            aux = new MinhaSolucaoAlternativaDeSucessoSemBug("123.013,01");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

            aux = new MinhaSolucaoAlternativaDeSucessoSemBug("3,41");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

            aux = new MinhaSolucaoAlternativaDeSucessoSemBug("111.039.101.201,10");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

        }
    }
}
