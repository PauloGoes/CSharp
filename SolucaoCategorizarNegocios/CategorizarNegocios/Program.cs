// See https://aka.ms/new-console-template for more information

using CategorizarNegocios.Categoria;
using CategorizarNegocios.Risco;
using CategorizarNegocios.Trade;

var Trades = new List<ITrade>() {
    new Trade { Value = 2000000, ClientSector = "Private", NextPaymentDate = new DateTime(2025, 12, 29) }
    , new Trade { Value = 400000 , ClientSector = "Public" , NextPaymentDate = new DateTime(2020,  7,  1) }
    , new Trade { Value = 5000000, ClientSector = "Public" , NextPaymentDate = new DateTime(2024,  1,  2) }
    , new Trade { Value = 3000000, ClientSector = "Public" , NextPaymentDate = new DateTime(2023, 10, 26) }
};


var Riscos = Risco.CalcularRisco(Trades);
foreach (var risco in Riscos)
{
    Console.WriteLine(risco);
}
Console.WriteLine("");

/*** Descomentar, caso queira comparar o Resultado ***/
//foreach (var trade in Trades)
//{
//    /*
//    1.EXPIRADO(EXPIRED): Negociações cuja próxima data de pagamento esteja atrasada em mais de 30
//      dias com base em uma data de referência que será seja dado.
//    */
//    if (trade.NextPaymentDate.Subtract(DateTime.Today).TotalDays < (-30))
//    {
//        Console.WriteLine(
//            string.Format(
//                "{0} - {1} - {2} - {3} - ({4})"
//                , "EXPIRED"
//                , trade.Value
//                , trade.ClientSector
//                , trade.NextPaymentDate
//                , trade.NextPaymentDate.Subtract(DateTime.Today).TotalDays
//        ));
//    }
//    /*
//    2. ALTO RISCO(HIGHRISK): Operações com valor superior a 1.000.000 e cliente do Setor Privado.
//    */
//    else if (trade.Value > 1000000 && trade.ClientSector.Equals("Private"))
//    {
//        Console.WriteLine(
//             string.Format(
//                "{0} - {1} - {2} - {3} - ({4})"
//                , "HIGHRISK"
//                , trade.Value
//                , trade.ClientSector
//                , trade.NextPaymentDate
//                , trade.NextPaymentDate.Subtract(DateTime.Today).TotalDays
//        ));
//    }
//    /*
//    3. RISCO MÉDIO(MEDIUMRISK): Operações com valor superior a 1.000.000 e cliente do Setor Público.
//    */
//    else if (trade.Value > 1000000 && trade.ClientSector.Equals("Public")
//    )
//    {
//        Console.WriteLine(
//             string.Format(
//                "{0} - {1} - {2} - {3} - ({4})"
//                , "MEDIUMRISK"
//                , trade.Value
//                , trade.ClientSector
//                , trade.NextPaymentDate
//                , trade.NextPaymentDate.Subtract(DateTime.Today).TotalDays
//        ));
//    }
//}

Console.ReadKey();

