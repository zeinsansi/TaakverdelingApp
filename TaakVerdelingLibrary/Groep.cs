using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaakVerdelingLibrary
{
    public class Groep
    {
        private string Naam;
        private string ProjectNaam;
        private string ProjectBeschrijving;
        private List<Persoon> groepsleden = new List<Persoon>();

        public Groep (string Naam, string ProjectNaam, string ProjectBeschrijving)
        {
            this.Naam = Naam;
            this.ProjectNaam = ProjectNaam;
            this.ProjectBeschrijving = ProjectBeschrijving;
            
        }
        public string GetNaam() { return this.Naam; }
        public string GetProjectNaam() { return this.ProjectNaam; }
        public string GetProjectBeschrijving() { return this.ProjectBeschrijving; }

        public void VoegGroepslidToe()
        {

        }

        public void VerwijderGroepslid()
        {

        }

        public override string ToString()
        {
            return $"Naam: {this.Naam}\n Project: {this.ProjectNaam}\n Beschrijving: {this.ProjectBeschrijving}";
        }
    }
}
