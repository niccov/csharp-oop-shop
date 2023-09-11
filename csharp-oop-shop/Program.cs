// See https://aka.ms/new-console-template for more information

using csharp_oop_shop;

Prodotto brunello = new Prodotto("Brunello di Montalcino", "vino con uvaggio San Giovese", 20, 22);

Prodotto tuaRita = new Prodotto("Rosso dei Notri", "vino con uvaggi San Giovese, Cabernet e Merlot", 25, 22);

Prodotto renis = new Prodotto("Renis", "vino di Syrah in purezza", 22, 22);

Prodotto bulichella = new Prodotto("Tuscanio", "vino con uvaggio Vermentino", 15, 22);

Prodotto terradonna = new Prodotto("Bixbi", "vino con uvaggi Syrah e San Giovese", 16, 22);


//array prodotti

Prodotto[] arrayProdotti = new Prodotto[] { brunello, tuaRita, renis, bulichella, terradonna };

//chiamo la funzione per la stampa dell'array

StampaArrayProdotti(arrayProdotti);

//Funzioni

static void StampaArrayProdotti(Prodotto[] arrayProdotti)
{
    foreach (Prodotto prodotto in arrayProdotti)
    {
        Console.WriteLine($"Codice prodotto: {prodotto.Codice}");
        Console.WriteLine($"Nome esteso: {prodotto.GetNomeCodice()}");
        Console.WriteLine($"Nome prodotto: {prodotto.Nome}");
        Console.WriteLine($"Descrizione del prodotto: {prodotto.Descrizione}");
        Console.WriteLine($"Prezzo: {prodotto.GetPrezzoBase()} euro");
        Console.WriteLine($"Prezzo con iva: {prodotto.GetPrezzoIva()} euro");
        Console.WriteLine();
    }
}