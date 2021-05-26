using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.Dominio
{
    public class Conversor
    {
        private Bilhao bilhao;
        private Milhao milhao;
        private Milhar milhar;
        private Simples simples;
        private Centavos centavos;
        public string ValorPorExtenso { get; private set; }

        public Conversor()
        {

        }
        public Conversor(string valor)
        {
            ValorCheio(valor);
        }

        private void ValorCheio(string valor)
        {
            IdentificarQuantidadeNumeros(ref valor);
            ValorPorExtenso += ConvertGrupoTresBilhao(valor.Substring(0, 3)) + " ";
            ValorPorExtenso += ConvertGrupoTresMilhao(valor.Substring(3, 3)) + " ";
            ValorPorExtenso += ConvertGrupoTresMilhar(valor.Substring(6, 3)) + " ";
            ValorPorExtenso += ConvertGrupoTres(valor.Substring(9, 3)) + " e ";
            ValorPorExtenso += ConvertCentavos(valor.Substring(12, 2));
        }

        private void IdentificarQuantidadeNumeros(ref string valor)
        {
            valor = valor.Replace(",", "");
            valor = valor.Replace(".", "");
        }

        public string ConvertGrupoTresMilhao(string grupo)
        {
            int unidade = Convert.ToInt32(grupo.Substring(2, 1));
            int dezena = Convert.ToInt32(grupo.Substring(1, 1));
            int centena = Convert.ToInt32(grupo.Substring(0, 1));

            milhao = new Milhao(centena, dezena, unidade);
            if (dezena == 1 && unidade != 1)
            {
                milhao.ValorPorEscrito += milhao.StringCentena();
            }
            else if (dezena == 1 && unidade == 1)
            {
                milhao.ValorPorEscrito += milhao.StringCentena();
            }
            else if (dezena != 1 && unidade != 1)
            {
                milhao.ValorPorEscrito += milhao.StringCentena() + " e ";
                milhao.ValorPorEscrito += milhao.StringDezena() + " ";
                milhao.ValorPorEscrito += milhao.StringUnidade();
            }
            else if (dezena != 1 && unidade == 1)
            {
                milhao.ValorPorEscrito += milhao.StringCentena() + " e ";
                milhao.ValorPorEscrito += milhao.StringDezena() + " ";
                milhao.ValorPorEscrito += milhao.StringUnidade();
            }
            return milhao.ValorPorEscrito;
        }

        public string ConvertGrupoTresBilhao(string grupo)
        {
            int unidade = Convert.ToInt32(grupo.Substring(2, 1));
            int dezena = Convert.ToInt32(grupo.Substring(1, 1));
            int centena = Convert.ToInt32(grupo.Substring(0, 1));

            bilhao = new Bilhao(centena, dezena, unidade);
            if (dezena == 1 && unidade != 1)
            {
                bilhao.ValorPorEscrito += bilhao.StringCentena();
            }
            
            else if (dezena != 1 && unidade != 1)
            {
                bilhao.ValorPorEscrito += bilhao.StringCentena() + " e ";
                bilhao.ValorPorEscrito += bilhao.StringDezena() + " ";
                bilhao.ValorPorEscrito += bilhao.StringUnidade();
            }
            else if (dezena != 1 && unidade == 1)
            {
                bilhao.ValorPorEscrito += bilhao.StringCentena() + " e ";
                bilhao.ValorPorEscrito += bilhao.StringDezena() + " ";
                bilhao.ValorPorEscrito += bilhao.StringUnidade();
            }
            else if (dezena == 1 && unidade == 1 && centena ==1)
            {
                bilhao.ValorPorEscrito += bilhao.StringCentena();
            }
            else if (dezena == 1 && unidade == 1)
            {
                bilhao.ValorPorEscrito += bilhao.StringCentena() + " e ";
                bilhao.ValorPorEscrito += bilhao.StringDezena();

            }
            return bilhao.ValorPorEscrito;
        }

        public string ConvertGrupoTresMilhar(string grupo)
        {
            int unidade = Convert.ToInt32(grupo.Substring(2, 1));
            int dezena = Convert.ToInt32(grupo.Substring(1, 1));
            int centena = Convert.ToInt32(grupo.Substring(0, 1));

            milhar = new Milhar(centena, dezena, unidade);
            if (dezena == 1 && unidade != 1)
            {
                milhar.ValorPorEscrito += milhar.StringCentena();
            }
            else if (dezena == 1 && unidade == 1)
            {
                milhar.ValorPorEscrito += milhar.StringCentena();
            }
            else if (dezena != 1 && unidade != 1 && centena ==1)
            {
                milhar.ValorPorEscrito += milhar.StringCentena() + " e ";
                milhar.ValorPorEscrito += milhar.StringUnidade();
            }
            else if (dezena != 1 && unidade != 1  )
            {
                milhar.ValorPorEscrito += milhar.StringCentena() + " e ";
                milhar.ValorPorEscrito += milhar.StringDezena() + " ";
                milhar.ValorPorEscrito += milhar.StringUnidade();
            }
            else if (dezena != 1 && unidade == 1)
            {
                milhar.ValorPorEscrito += milhar.StringCentena() + " e ";
                milhar.ValorPorEscrito += milhar.StringDezena() + " ";
                milhar.ValorPorEscrito += milhar.StringUnidade();
            }
            return milhar.ValorPorEscrito;
        }
        public string ConvertGrupoTres(string grupo)
        {
            int unidade = Convert.ToInt32(grupo.Substring(2, 1));
            int dezena = Convert.ToInt32(grupo.Substring(1, 1));
            int centena = Convert.ToInt32(grupo.Substring(0, 1));

            simples = new Simples(centena, dezena, unidade);
            if (dezena == 1 && unidade != 1)
            {
                simples.ValorPorEscrito += simples.StringCentena();
            }
            else if (dezena == 1 && unidade == 1)
            {
                simples.ValorPorEscrito += simples.StringCentena();
            }
            else if (dezena != 1 && unidade != 1)
            {
                simples.ValorPorEscrito += simples.StringCentena() + " e ";
                simples.ValorPorEscrito += simples.StringDezena() + " ";
                simples.ValorPorEscrito += simples.StringUnidade();
            }
            else if (dezena != 1 && unidade == 1)
            {
                simples.ValorPorEscrito += simples.StringCentena() + " e ";
                simples.ValorPorEscrito += simples.StringDezena() + " ";
                simples.ValorPorEscrito += simples.StringUnidade();
            }
            return simples.ValorPorEscrito;
        }
        public string ConvertCentavos(string grupo)
        {
            int unidade = Convert.ToInt32(grupo.Substring(1, 1));
            int dezena = Convert.ToInt32(grupo.Substring(0, 1));

            centavos = new Centavos(dezena, unidade);
            if (dezena == 1 && unidade != 1)
            {
                centavos.ValorPorEscrito += centavos.StringDezena();
            }
            else if (dezena != 1 && unidade == 1)
            {
                centavos.ValorPorEscrito += centavos.StringDezena() + " ";
                centavos.ValorPorEscrito += centavos.StringUnidade();

            }
            else if (dezena == 1 && unidade == 1)
            {
                centavos.ValorPorEscrito += centavos.StringDezena();
            }
            else if (dezena == 0)
            {
                centavos.ValorPorEscrito += centavos.StringUnidade();
            }
            else if (dezena != 1 && unidade != 1)
            {
                centavos.ValorPorEscrito += centavos.StringDezena() + " ";
                centavos.ValorPorEscrito += centavos.StringUnidade();
            }
            return centavos.ValorPorEscrito;
        }
    }
}
