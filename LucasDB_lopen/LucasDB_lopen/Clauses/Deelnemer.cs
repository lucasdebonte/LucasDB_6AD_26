using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasDB_lopen
{
    internal class Deelnemer
    {
        // Lucas De Bonte 
        // 11/09/2026

        // Velden + properties
        String _naam { get; set; } = "";
        int _afstand { get; set; } = 0;
        bool _betaald { get; set; } = false;


        // Functies
        // Toont alle gegeven die we hebben 
        public String AlleGegevens()
        {
            string antwoord = "";

            antwoord = $"Deelnemer : {_naam}, loopt{_afstand}km";
            if (_betaald)
            {
                antwoord += "en heeft betaald";
            }
            else
            {
                antwoord += "en heeft nog niet betaald";
            }

            return antwoord;
        }
        // Toont welke afstand een pebaald loper heeft en of hij betaald heeft

        public String AfstEnBetaald()
        {
            string resultaat = "";

            resultaat = $"Afstand : {_afstand}km";
            if (_betaald)
            {
                resultaat += "en heeft betaald";
            }
            else
            {
                resultaat += "en heeft NIET betaald";
            }

            return resultaat;
        }


        // Constructors 
        // Default constructor 
        public Deelnemer() { }
        public Deelnemer(string ontvNaam, int ontvafstand, bool ontvbetaald ) 
        {
            _naam = ontvNaam;
            _afstand = ontvafstand;
            _betaald = ontvbetaald;
        }
    }
}
