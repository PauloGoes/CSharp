using CategorizarNegocios.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CategorizarNegocios.Categoria;
using System.Reflection;

namespace CategorizarNegocios.Risco
{
    public static class Risco
    {
        /// <summary>
        /// Faz as chamadas do CalcularRisco das classes que fazem a verificação do tipo do risco, passando como parâmetro trade por trade.
        /// </summary>
        /// <param name="trades"></param>
        /// <returns></returns>
        public static List<string> CalcularRisco(List<ITrade> trades)
        {
            var Riscos = Categoria.Categoria.GetRiscoCategoria();
            var Calculado = new List<string>();

            foreach (var trade in trades)
            {
                foreach (IRiscoTipo risco in Riscos)
                {

                    if (risco.CalcularRisco(trade))
                    {
                        Calculado.Add(risco.CategoriaRisco);
                        break;
                    }
                }
            }

            return Calculado;
        }
    }
}
