using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace LucasDB_ClasseMinigolg
{
    public class MijnDB
    {
        // Velden 
        static String _mijnPad = "";
        OleDbConnection _mijnconnectie = new OleDbConnection(_mijnPad);

        // Functies 

        /// <summary>
        /// Stuurt een list met objecten van alle spelers uit de databank
        /// </summary>
        /// <returns></returns>
        public List<speler> GetSpelers()
        {
            
        }
        /// <summary>
        ///  voegt een speler toe aan databank 
        /// </summary>
        /// <param name="ontvSpeler"></param>
        /// <returns></returns>
        
        public Void DbToevoegenSpeler (Speler ontvSpeler)
        {
            string voornaam = ontvSpeler._voornaam;
            string Familienaam = ontvSpeler._familienaam;
            // Maak je de sql 
            string Sql = $"INSERT INTO Speler (Voornaam, Familienaam) VALUES('{voornaam}' , '{Familienaam}' ";
            // Maak een command dat deze sql uitvoerd in onze databank 
            OleDbCommand mijnComn = new OleDbCommand(Sql, _mijnconnectie);
        }
        /// <summary>
        /// Updat een speler in de databank 
        /// </summary>
        /// <param name="ontvSpeler"></param>
        /// <returns></returns>
        public Void SpelerAanpassenInDB (Speler ontvSpeler)
        {

        }
        VoidSpelerVerwijderenInDB (Speler ontvSpeler)
        {

        }

ResetSpelInDB()

    }
}
