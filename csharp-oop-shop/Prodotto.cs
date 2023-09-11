using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        //PROPRIETA' e STATI
        public int Codice { get; private set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Iva { get; set; }


        //COSTRUTTORI​
        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            this.Codice = new Random().Next(0, 99999999);
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
        }


        //GETTERS​
       public double GetPrezzoBase()
        {
            return this.Prezzo;
        }

        public double GetPrezzoIva()
        {
            return Prezzo + (Prezzo / 100 * Iva);

        }

        public string GetNomeCodice()
        {
            return this.Codice + " " + this.Nome;
        }
    }
}
