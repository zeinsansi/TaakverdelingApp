using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaakVerdelingLibrary
{
    public class Persoon
    {
        private string Naam;
        private string GebruikerNaam;
        public List<Taak> taken { get; } = new List<Taak>();

        public Persoon (string Naam, string GebruikerNaam)
        {
            this.Naam = Naam;
            this.GebruikerNaam = GebruikerNaam;
        }
        public string GetNaam() { return this.Naam; }
        public string GetGebruikerNaam() { return this.GebruikerNaam; }

        public void VoegTaakToe()
        {

        }

        public void VerwijderTaak()
        {

        }

        public override string ToString()
        {
            return $"Naam: {this.Naam}\nGebruikerNaam: {this.GebruikerNaam}\n";
        }
    }
}
