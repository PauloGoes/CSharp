using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizarNegocios.Trade
{
    public class Trade : ITrade
    {
        public double Value { get; set; }
        public string ClientSector { get; set; } = null!;
        public DateTime NextPaymentDate { get; set; }
    }
}
