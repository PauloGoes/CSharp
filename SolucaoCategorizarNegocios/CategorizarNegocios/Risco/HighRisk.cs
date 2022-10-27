using CategorizarNegocios.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizarNegocios.Risco
{
    public class HighRisk : IRiscoTipo
    {
        public string CategoriaRisco { get; set; } = null!;

        /// <summary>
        /// 2. ALTO RISCO(HIGHRISK): Operações com valor superior a 1.000.000 e cliente do Setor Privado.
        /// </summary>
        /// <param name="trade"></param>
        /// <returns></returns>
        public bool CalcularRisco(ITrade trade)
        {
            bool altoRisco = false;
            if (trade.Value > 1000000
                && trade.ClientSector.ToUpper()==Categoria.Categoria.enmClienteSetor.Private.ToString().ToUpper())
            {
                altoRisco = true;
                CategoriaRisco = Categoria.Categoria.enmCategoria.HIGHRISK.ToString();
            }
            return altoRisco;
        }
    }
}
