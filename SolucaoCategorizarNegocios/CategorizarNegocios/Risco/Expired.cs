using CategorizarNegocios.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizarNegocios.Risco
{
    public class Expired : IRiscoTipo
    {
        public string CategoriaRisco { get; set; } = null!;

        /// <summary>
        /// 1.EXPIRADO(EXPIRED): Negociações cuja próxima data de pagamento esteja atrasada em mais de 30
        /// dias com base em uma data de referência que será seja dado.
        /// </summary>
        /// <param name="trade"></param>
        /// <returns></returns>
        public bool CalcularRisco(ITrade trade)
        {
            bool expirado = false;
            if (trade.NextPaymentDate.Subtract(DateTime.Today).TotalDays < (-30))
            {
                expirado = true;
                CategoriaRisco = Categoria.Categoria.enmCategoria.EXPIRED.ToString();
            }
            return expirado;
        }
    }
}
