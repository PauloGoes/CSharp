using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizarNegocios.Trade
{
    public interface ITrade
    {
        /// <summary>
        /// /indica o valor da transação em dólares
        /// </summary>
        double Value { get; }

        /// <summary>
        /// //indica o setor do cliente que pode ser "Público" ou "Privado"
        /// </summary>
        string ClientSector { get; }

        /// <summary>
        /// indica quando é esperado o próximo pagamento do cliente ao banco
        /// </summary>
        DateTime NextPaymentDate { get; }
    }

}
