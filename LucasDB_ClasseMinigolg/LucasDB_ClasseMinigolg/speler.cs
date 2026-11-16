using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasDB_ClasseMinigolg
{
    public class speler
    {
        public int _spelerID { get; set; } = -1;
        public string _voornaam { get; set; }
        public string _familienaam { get; set; }
        public int _totaalslagen { get; set; } = 0;

       
        /// <summary>
        /// De voledige naam teruggeven.
        /// </summary>
        /// <returns></returns>
        public string VolledigeNaam()
        {
            return $"{_voornaam} {_familienaam}";
        }

        /// <summary>
        /// Alle gegevens van de speler terug geven. 
        /// </summary>
        /// <returns></returns>
        public string AlleGegevens()
        {
            
            return  $"SpelerID: {_spelerID}\n" +
                    $"Voornaam: {_voornaam}\n" +
                    $"Familienaam: {_familienaam}\n" +
                    $"Totaal slagen: {_totaalslagen}\n"; 

        }
        // Methode: extra slagen toevoegen
        public void SlagenToevoegen(int aantalSlagen)
        {
            _totaalslagen += aantalSlagen;
        }
    }
}
