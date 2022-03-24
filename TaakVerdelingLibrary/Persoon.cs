using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaakVerdelingLibrary
{
    public class Persoon
    {
        /// <summary>  De naam van de persoon  </summary>
        private string Naam;
        /// <summary> /// De unieke gebruikersnaan van de persoon /// </summary>
        private string GebruikerNaam;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Naam"></param>
        /// <param name="GebruikerNaam"></param>
        public Persoon (string Naam, string GebruikerNaam)
        {
            this.Naam = Naam;
            this.GebruikerNaam = GebruikerNaam;
        }
        /// <summary>
        /// Geeft de naam van de persoon terug
        /// </summary>
        /// <returns>Naam</returns>
        public string GetNaam() { return this.Naam; }
        /// <summary>
        /// Geeft de unieke gebruikersnaam van de persoon terug
        /// </summary>
        /// <returns>GebruikersNaam </returns>
        public string GetGebruikerNaam() { return this.GebruikerNaam; }

        public override string ToString()
        {
            return $"Naam: {this.Naam}\nGebruikerNaam: {this.GebruikerNaam}\n";
        }
    }
}
