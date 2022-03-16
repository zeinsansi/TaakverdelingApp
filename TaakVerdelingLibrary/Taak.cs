using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaakVerdelingLibrary
{
    public class Taak
    {
        private string Naam;
        private string Beschrijving;
        private DateTime Deadline;

        public Taak(string Naam, string Beschrijving, DateTime deadline)
        {
            this.Naam = Naam;
            this.Beschrijving = Beschrijving;
            this.Deadline = deadline;
        }
        public string GetNaam() { return this.Naam; }
        public string GetBeschrijving() { return this.Beschrijving; }
        public DateTime GetDeadLine() { return this.Deadline; }

        public override string ToString()
        {
            return $"Naam: {this.Naam}\nBeschrijving: {this.Beschrijving}\nDeadline: {this.Deadline}";
        }
    }
}
