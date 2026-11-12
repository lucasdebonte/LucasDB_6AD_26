using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucasDB_lopen
{
    public partial class FrmOpzoeken : Form
    {
        public FrmOpzoeken()
        {
            InitializeComponent();
        }

        private void lblVerwijderen_Click(object sender, EventArgs e)
        {
            PasUizichtAan(2);
        }

        private void btnAnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            PasUizichtAan(1);
            // Haal de gegevens uit de business 
            txttoon.Text =  Program.Allegegevens();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmOpzoeken_Load(object sender, EventArgs e)
        {
            VullCmb();
            PasUizichtAan(1);
        }
        void VullCmb()
        {
            // Haal lijst op 
            List<string> namen = Program.Deelnemers();

            // Maak cmb leeg
            comboBox1.Items.Clear();

            // Overloop de lijst met namen en steek ze 1 voor 1 in de cmb
            foreach (string s in namen)
            {
                comboBox1.Items.Add(s);
            }
        }

        /// <summary>
        /// Deze functie past het uizicht aan afhgankelijk van de gekozen optie
        /// </summary>
        /// <param name="versie"></param>
        void PasUizichtAan(int versie)
        {
            // Reset de stekstbox waarin de gegevens worden getoond 
            txttoon.Text = " ";

            if (versie ==1)// alle deelnemers 
            {
                lblKies.Visible = false;
                comboBox1.Visible= false;

                lblResultaten.Location = new Point(21, 108);
                txttoon.Location = new Point(26, 165);
                Size = new Size(800,525);
            }
            else
            {
                lblKies.Visible = true;
                comboBox1.Visible = true;

                lblResultaten.Location = new Point(21, 183);
                txttoon.Location = new Point(26, 241);
                Size = new Size(800, 600);




            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Toon de gegevens van de juiste persoon
            txttoon.Text = Program.Geg1Deeln(comboBox1.SelectedIndex);
        }
    }
}
