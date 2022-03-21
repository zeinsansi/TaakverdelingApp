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
        private string IdNummer;
        public List<Taak> taken { get; } = new List<Taak>();

        public Persoon (string Naam, string IdNummer)
        {
            this.Naam = Naam;
            this.IdNummer = IdNummer;
        }
        public string GetNaam() { return this.Naam; }
        public string GetIdNummer() { return this.IdNummer; }

        public void VoegTaakToe()
        {

        }

        public void VerwijderTaak()
        {

        }

        public override string ToString()
        {
            return $"Naam: {this.Naam}\nBeschrijving: {this.IdNummer}\n";
        }
    }
}
