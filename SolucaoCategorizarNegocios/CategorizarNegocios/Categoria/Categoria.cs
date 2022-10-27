using CategorizarNegocios.Risco;
using CategorizarNegocios.Trade;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizarNegocios.Categoria
{
    public class Categoria
    {
        public enum enmClienteSetor
        {
            Private,
            Public
        }

        //public enum enmCategoria
        //{
        //    EXPIRED,
        //    HIGHRISK,
        //    MEDIUMRISK
        //}

        public enum enmCategoria
        {
            EXPIRED,
            HIGHRISK,
            MEDIUMRISK
        }

        /// <summary>
        /// Adicione a chamada do construtor na ordem prioritária da verificação.
        /// Importante: Esse ponto requer muita atenção pois é aqui que se define a ordem de execução das verificações.
        /// </summary>
        /// <returns></returns>
        public static List<IRiscoTipo> GetRiscoCategoria()
        {
            var ret = new List<IRiscoTipo>();
            ret.Add(new Expired());
            ret.Add(new HighRisk());
            ret.Add(new MediumRisk());

            return ret;
        }
    }
}
