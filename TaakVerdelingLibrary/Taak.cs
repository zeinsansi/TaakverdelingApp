using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaakVerdelingLibrary
{
    public class Taak
    {
        /// <summary>  De naam van de Taak </summary>
        private string Naam;
        /// <summary>  De beschrijving van de taak  </summary>
        private string Beschrijving;
        /// <summary>  Het deadline van de taak  </summary>
        private DateTime Deadline;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Naam"></param>
        /// <param name="Beschrijving"></param>
        /// <param name="deadline"></param>
        public Taak(string Naam, string Beschrijving, DateTime deadline)
        {
            this.Naam = Naam;
            this.Beschrijving = Beschrijving;
            this.Deadline = deadline;
        }
        /// <summary>
        /// Geeft de naam van de taak terug
        /// </summary>
        /// <returns>Naam</returns>
        public string GetNaam() { return this.Naam; }
        /// <summary>
        /// Geeft de beschrijving van de taak terug
        /// </summary>
        /// <returns>Beschrijving</returns>
        public string GetBeschrijving() { return this.Beschrijving; }
        /// <summary>
        /// Geeft het deadline van de taak terug
        /// </summary>
        /// <returns>Deadline</returns>
        public DateTime GetDeadLine() { return this.Deadline; }

        public override string ToString()
        {
            return $"Naam: {this.Naam}\nBeschrijving: {this.Beschrijving}\nDeadline: {this.Deadline}";
        }
    }
}
