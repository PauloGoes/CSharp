using CategorizarNegocios.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizarNegocios.Risco
{
    public class MediumRisk : IRiscoTipo
    {
        public string CategoriaRisco { get; set; } = null!;

        /// <summary>
        /// 3. RISCO MÉDIO(MEDIUMRISK): Operações com valor superior a 1.000.000 e cliente do Setor Público.
        /// </summary>
        /// <param name="trade"></param>
        /// <returns></returns>
        public bool CalcularRisco(ITrade trade)
        {
            bool altoRisco = false;
            if (trade.Value > 1000000 
                && trade.ClientSector.ToUpper() == Categoria.Categoria.enmClienteSetor.Public.ToString().ToUpper())
            {
                altoRisco = true;
                CategoriaRisco = Categoria.Categoria.enmCategoria.MEDIUMRISK.ToString();
            }
            return altoRisco;
        }
    }
}
