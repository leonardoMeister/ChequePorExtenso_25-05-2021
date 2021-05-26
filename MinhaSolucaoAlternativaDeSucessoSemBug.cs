using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ChequePorExtenso
{
    class MinhaSolucaoAlternativaDeSucessoSemBug
    {
        public string auxValor = "";
        List<string> lista;

        public MinhaSolucaoAlternativaDeSucessoSemBug(string valor)
        {
            //criando lista
            lista = new List<string>();

            AdicionandoValoresNaLista(valor);
            AplicandoTraducaoDeCampos();
            RemovendoValoresVazios();
            AdicionandoMedidas();
            ConcatenandoStrings();

        }

        private void AdicionandoValoresNaLista(string valor)
        {
            //preenchendo lista
            for (int i = 0; i < valor.Length; i++)
            {
                lista.Add(valor.Substring(i, 1));
            }
        }

        private void AplicandoTraducaoDeCampos()
        {
            //var de controle de unidade dezena centena
            int aux = 4;
            aux = VerificarComoIniciaATraducao(aux);

            //passando de item em item da lista conforme unidade dezena centena
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == ",")
                {
                    aux = 2;
                }

                if (lista[i] != "." && lista[i] != ",")
                {
                    //Começa com centena
                    if (aux == 1)
                    {
                        if (lista[i] == "1")
                        {
                            if (lista[i + 2] == "0" && lista[i + 1] == "0")
                            {
                                lista[i] = RetorneValorString(100);
                            }
                            else lista[i] = RetornarValorUm(3);
                        }
                        else
                        {
                            lista[i] = RetorneValorString((Convert.ToInt32(lista[i])) * 100);
                        }

                        aux++;
                    }//Começa com Dezena
                    else if (aux == 2)
                    {
                        if (lista[i] == "1")
                        {
                            lista[i] = RetornarDezenaComUm(Convert.ToInt32(lista[(i + 1)]));
                            lista.Remove(lista[(i + 1)]);
                            aux = 1;
                        }
                        else
                        {
                            lista[i] = RetorneValorString((Convert.ToInt32(lista[i])) * 10);
                            aux++;
                        }
                    }//Começa com unidade   
                    else if (aux == 3)
                    {
                        lista[i] = RetorneValorString(Convert.ToInt32(lista[i]));
                        aux = 1; ;
                    }
                }
            }
        }

        private void RemovendoValoresVazios()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == "")
                {
                    lista.Remove(lista[i]);
                }
            }
        }

        private void ConcatenandoStrings()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                auxValor += lista[i] + " ";
            }
        }

        private void AdicionandoMedidas()
        {
            int medida = lista.Count;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == "." || lista[i] == ",")
                {
                    if (medida >= 12)
                    {
                        lista[i] = RetornarMedidas(4);
                        medida = 9;
                    }
                    else if (medida >= 9)
                    {
                        lista[i] = RetornarMedidas(1);
                        medida = 6;
                    }
                    else if (medida >= 6)
                    {
                        lista[i] = RetornarMedidas(0);
                        medida = 3;
                    }
                    else if (medida >= 3)
                    {
                        lista[i] = RetornarMedidas(7);
                        medida = 0;
                    }
                }
                else if (medida == 0)
                {
                    lista.Add(RetornarMedidas(5));
                    break;
                }
            }
        }

        private string RetornarMedidas(int identificador)
        {
            switch (identificador)
            {
                case 0: return "Mil";
                case 1: return "Milhões";
                case 2: return "Milhão";
                case 3: return "Bilhão";
                case 4: return "Bilhões";
                case 5: return "Centavos";
                case 6: return "Centavo";
                case 7: return "Reais";
                default: return "";
            }
        }

        private string RetornarDezenaComUm(int identificador)
        {
            switch (identificador)
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
                default: return "";
            }
        }
        private int VerificarComoIniciaATraducao(int aux)
        {
            for (int i = 0; i < lista.Count; i++)
            {

                if (lista[i] == "." || lista[i] ==",")
                {
                    break;
                }
                aux--;
            }

            return aux;
        }

        private string RetornarValorUm(int identificador)
        {
            switch (identificador)
            {
                case 1: return "Um";
                case 2: return "Onze";
                case 3: return "Cento";
                default: return "";
            }
        }

        private string RetorneValorString(int identificador)
        {
            switch (identificador)
            {
                case 1: return "Um";
                case 2: return "Dois";
                case 3: return "Tres";
                case 4: return "Quatro";
                case 5: return "Cinco";
                case 6: return "Seis";
                case 7: return "Sete";
                case 8: return "Oito";
                case 9: return "Nove";

                case 20: return "Vinte";
                case 30: return "Trinta";
                case 40: return "Quarenta";
                case 50: return "Cinquenta";
                case 60: return "Sessenta";
                case 70: return "Setenta";
                case 80: return "Oitenta";
                case 90: return "Noventa";

                case 100: return "Cem";
                case 200: return "Duzentos";
                case 300: return "Trezentos";
                case 400: return "Quatrocentos";
                case 500: return "Quinhentos";
                case 600: return "Seicentos";
                case 700: return "Setecentos";
                case 800: return "Oitocentos";
                case 900: return "Novecentos";

                default: return "";
            }

        }
    }
}
