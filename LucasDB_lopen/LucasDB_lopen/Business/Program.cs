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

        static public void Aanpassen(int ontvIndex, String ontvNaam, int ontvAfst, bool ontvBetaald)
        {
            // Maak een nieuw object aan met de klasse met de juiste constructor 
            Deelnemer Aangepasteinschrijving  = new Deelnemer(ontvNaam, ontvAfst, ontvBetaald);

            // Voeg de nieuwe deelnemer toe aan de lijst 
            _deelnemers[ontvIndex] = Aangepasteinschrijving;
        }

        static public void Verwijderen(int ontvIndex)
        {
            // verwijder de inschrijving 
            _deelnemers.RemoveAt(ontvIndex);
        }

        static public List<String> Deelnemers()
        {
            List<String> antwoord = new List<String>();
            return antwoord;
        }


        static public String Allegegevens()
        {
            string antwoord = null;
            return antwoord;
        }

        static public String Geg1Deeln(int ontvIndex)
        {
            string antwoord = null;
            return antwoord;
        }

    }
}
