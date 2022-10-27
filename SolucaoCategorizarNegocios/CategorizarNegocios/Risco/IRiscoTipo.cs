using CategorizarNegocios.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizarNegocios.Risco
{
    public interface IRiscoTipo
    {
        public string CategoriaRisco { get; }
        bool CalcularRisco(ITrade trade);
    }
}
