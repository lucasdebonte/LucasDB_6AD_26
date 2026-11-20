using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace LucasDB_ClasseMinigolg
{
    public class MijnDB
    {
        // Velden 
        static String _mijnPad = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\C:\\Users\\Lucas\\OneDrive - Oscar Romerocollege\\6AD\\Software\\Databanken\\MiniGolf.accdb\";
        OleDbConnection _mijnConnectie = new OleDbConnection(_mijnPad);

        // Functies 

        /// <summary>
        /// Stuurt een list met objecten van alle spelers uit de databank
        /// </summary>
        /// <returns></returns>
        public List<speler> GetSpelers()
        {
            List<speler> antwoord = new List<speler>();

            // Maak de sql aan 
            String sql = "SELECT Voornaam,Naam,Totaalslagen" +
                "FROM Speler";
            // Maak het commando 
            OleDbCommand mijnComn = new OleDbCommand(sql, _mijnConnectie);

            // Maak een datareader aan zonder instalatie 
            OleDbDataReader mijnReader;

            // Open Connectie 
            _mijnConnectie.Open();

            //Voer het commando uit en start de reader 
            mijnReader = mijnComn.ExecuteReader();

            // Kijk of de reader nog of al bezig 
            while(mijnReader.Read())
            {
                // Vang deze gegevens uit de database op
                // Converteer ze naar het juiste datatype 
                // Sla ze op in een variabele
                int ontvID = Convert.ToInt32(mijnReader["SpelerID"]);
                string ontvVn = Convert.ToString(mijnReader["Voornaam"]);
                string ontvFn = Convert.ToString(mijnReader["Naam"]);
                int ontvSlg = Convert.ToInt32(mijnReader["TotaalSlagen"]);

                // Maak een object van type speler 
                speler nieuwespeler = new speler(ontvID, ontvVn, ontvFn, ontvSlg);

                // Toevoegen aan lijst 
                antwoord.Add(nieuwespeler);
            }

            // Sluit connectie 
            _mijnConnectie.Close();

            return antwoord;

        }
        /// <summary>
        ///  voegt een speler toe aan databank 
        /// </summary>
        /// <param name="ontvSpeler"></param>
        /// <returns></returns>
        
        public void DbToevoegenSpeler (Speler ontvSpeler)
        {
            string voornaam = ontvSpeler._voornaam;
            string Familienaam = ontvSpeler._familienaam;
            // Maak je de sql 
            string Sql = $"INSERT INTO Speler (Voornaam, Naam) VALUES('{voornaam}' , '{Familienaam}' ";
            // Maak een command dat deze sql uitvoerd in onze databank 
            OleDbCommand mijnComn = new OleDbCommand(Sql, _mijnConnectie);

            // Open connectie met DB 
            _mijnConnectie.Open();

            // Het commando haalt niet uit de database en
            // moet dus enkel uitgevoerd worden.
            mijnComn.ExecuteNonQuery();

            // Sluit connectie met de DB
            _mijnConnectie.Close();

        }
        /// <summary>
        /// Updat een speler in de databank 
        /// </summary>
        /// <param name="ontvSpeler"></param>
        /// <returns></returns>
        public void SpelerAanpassenInDB (Speler ontvSpeler)
        {
            int id = ontvSpeler._spelerID;
            string voornaam = ontvSpeler._voornaam;
            string Familienaam = ontvSpeler._familienaam;
            int aantalSlagen = ontvSpeler._totaalSlagen;

            // Maak je de sql 
            string Sql = $"UPDATE Speler SET Voornaam = '{voornaam}'," + 
            $"Naam  = '{Familienaam}', TotaalSlagen = {aantalSlagen}" +
            $"WHERE SpelerID = {id}";

            // Maak een command dat deze sql uitvoerd in onze databank 
            OleDbCommand mijnComn = new OleDbCommand(Sql, _mijnConnectie);

            // Open connectie met DB 
            _mijnConnectie.Open();

            // Het commando haalt niet uit de database en
            // moet dus enkel uitgevoerd worden.
            mijnComn.ExecuteNonQuery();

            // Sluit connectie met de DB
            _mijnConnectie.Close();
        }
        public void SpelerVerwijderenInDB (Speler ontvSpeler)
        {
            // haal de gegevens op 
            int id = ontvSpeler._spelerID;

            // Maak je de sql 
            string Sql = $"DELETE FROM speler WHERE SpelerID= {id}";

            // Maak een command dat deze sql uitvoerd in onze databank 
            OleDbCommand mijnComn = new OleDbCommand(Sql, _mijnConnectie);

            // Open connectie met DB 
            _mijnConnectie.Open();

            // Het commando haalt niet uit de database en
            // moet dus enkel uitgevoerd worden.
            mijnComn.ExecuteNonQuery();

            // Sluit connectie met de DB
            _mijnConnectie.Close();
        }

        public void ResetSpelInDB()
        {
            // haal de gegevens op 
            string Sql = $"DELETE FROM Speler"; 

            // Maak een command dat deze sql uitvoerd in onze databank 
            OleDbCommand mijnComn = new OleDbCommand(Sql, _mijnConnectie);

            // Open connectie met DB 
            _mijnConnectie.Open();

            // Het commando haalt niet uit de database en
            // moet dus enkel uitgevoerd worden.
            mijnComn.ExecuteNonQuery();

            // Sluit connectie met de DB
            _mijnConnectie.Close();
        }

    }
}
