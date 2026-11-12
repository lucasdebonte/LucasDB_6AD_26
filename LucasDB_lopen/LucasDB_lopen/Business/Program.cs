using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucasDB_lopen
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmStart());


        }
        // Velden
        static private List<Deelnemer>_deelnemers = new List<Deelnemer>();


        // Functies 
        /// <summary>
        /// Ontvangt een naam, afstand en of er betaald is en voegt de deelnemer toe in de lijst.
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvAfst"></param>
        /// <param name="ontvBetaald"></param>
        static public void Inschrijven(String ontvNaam, int ontvAfst, bool ontvBetaald)
        {
            // Maak een nieuw object aan met de klasse met de juiste constructor 
            Deelnemer nieuweInschrijving  = new Deelnemer (ontvNaam,ontvAfst,ontvBetaald);

            // Voeg de nieuwe deelnemer toe aan de lijst 
            _deelnemers.Add(nieuweInschrijving);
        }
        /// <summary>
        /// Ontvangt nieuwe gegevens uit de GUI, maakt een nieuw object aan en 
        /// overschrijft het juist object in de lijst. 
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvAfst"></param>
        /// <param name="ontvBetaald"></param>

        static public void Aanpassen(int ontvIndex, String ontvNaam, int ontvAfst, bool ontvBetaald)
        {
            // Maak een nieuw object aan met de klasse met de juiste constructor 
            Deelnemer Aangepasteinschrijving  = new Deelnemer(ontvNaam, ontvAfst, ontvBetaald);

            // Voeg de nieuwe deelnemer toe aan de lijst 
            _deelnemers[ontvIndex] = Aangepasteinschrijving;
        }
        /// <summary>
        /// Krijgt de index van een object en verwijdert het uit de lijst.
        /// </summary>
        /// <param name="ontvIndex"></param>
        static public void Verwijderen(int ontvIndex)
        {
            // verwijder de inschrijving 
            _deelnemers.RemoveAt(ontvIndex);
        }
        /// <summary>
        /// Geeft een lijst door met alle namen van de deelnemers 
        /// </summary>
        /// <returns></returns>
        static public List<String> Deelnemers()
        {
            // Maak een nieuwe lijst aan
            List<String> antwoord = new List<String>();

            //Overloop de lijst met deelenemers
            // d is afzonderlijk object waarin 1 voor 1 de objecten 
            // Van de lijst deelnemers wordt in gekopieerd 
            foreach (Deelnemer d in _deelnemers)
            {
                // Neem de naam van de deelnemer (object) en voeg deze toe aan
                // de antwoordlijst.
                antwoord.Add(d._naam);
            }

            return antwoord;
        }

        /// <summary>
        /// Stuur een string door met alle gegevens van alle objecten 
        /// maar mooi geordend 
        /// </summary>
        /// <returns></returns>

        static public String Allegegevens()
        {
            // Maak de antwoord variabele aan 
            string antwoord = null;

            // Overloop de lijst met deelnemers 
            foreach (Deelnemer d in _deelnemers)
            {
                // Neem de naam van de deelnemer (object) en voeg deze toe aan
                // de antwoordlijst.
                antwoord += d.AlleGegevens();
            }
            // Return de antwoord variabele 
            return antwoord;
        }
        /// <summary>
        /// Geeft van 1 specifieke deelnemer weer werlke afstand hij loopt en 
        /// of hij wel of niet betaald heeft.
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public String Geg1Deeln(int ontvIndex)
        {
            string antwoord = null;

            antwoord = _deelnemers[ontvIndex].AfstEnBetaald();

            return antwoord;
        }

        static public Deelnemer GegDeelnemer(int ontvIndex)
        {
            return _deelnemers[ontvIndex];
        }

    }
}
