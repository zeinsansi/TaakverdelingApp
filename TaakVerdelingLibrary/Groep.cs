using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaakVerdelingLibrary
{
    public class Groep
    {
        /// <summary>  De naam van de groep  </summary>
        private string Naam;
        /// <summary>  De naam van de groep project  </summary>
        private string ProjectNaam;
        /// <summary>  De beschrijving van groep project  </summary>
        private string ProjectBeschrijving;
        private List<Persoon> groepsleden = new List<Persoon>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Naam"></param>
        /// <param name="ProjectNaam"></param>
        /// <param name="ProjectBeschrijving"></param>
        public Groep (string Naam, string ProjectNaam, string ProjectBeschrijving)
        {
            this.Naam = Naam;
            this.ProjectNaam = ProjectNaam;
            this.ProjectBeschrijving = ProjectBeschrijving;
            
        }
        /// <summary>
        /// Geeft de naam van de groep terug
        /// </summary>
        /// <returns>Naam</returns>
        public string GetNaam() { return this.Naam; }
        /// <summary>
        /// Geeft de projectnaam van de groep terug
        /// </summary>
        /// <returns>ProjectNaam </returns>
        public string GetProjectNaam() { return this.ProjectNaam; }
        /// <summary>
        /// Geeft de projectbeschrijving van de groep terug
        /// </summary>
        /// <returns>ProjectBeschrijving </returns>
        public string GetProjectBeschrijving() { return this.ProjectBeschrijving; }

        public override string ToString()
        {
            return $"Naam: {this.Naam}\n Project: {this.ProjectNaam}\n Beschrijving: {this.ProjectBeschrijving}";
        }
    }
}
