using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LucasDB_lopen
{
    public partial class FrmBewerken : Form
    {
        public FrmBewerken()
        {
            InitializeComponent();
        }

        private void btnAnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SLa de geselecteerde index op 
            int index = comboBox1.SelectedIndex;

            // Kijken of er een deelnemer geselcteerd is of het de 
            // rest is van de form
            if (index != -1)
            {
                // Haal de deelnemer op die bij deze index hoort 
                Deelnemer ontvDeelnemer = Program.GegDeelnemer(index);

                // Vul de gegevens in 
                txtNaam.Text = ontvDeelnemer._naam;
                if (ontvDeelnemer._afstand == 5)
                {
                    cmbAfstand.SelectedIndex = 0;
                }
                else if (ontvDeelnemer._afstand == 10)
                {
                    cmbAfstand.SelectedIndex = 1;
                }
                else if (ontvDeelnemer._afstand == 20)
                {
                    cmbAfstand.SelectedIndex = 2;
                }
                if (ontvDeelnemer._betaald)
                {
                    rbBetaald.Checked = true;
                }
                else 
                {
                    rbNietbetaald.Checked = true;
                }

            }

        }

        private void FrmBewerken_Load(object sender, EventArgs e)
        {
            rbNietbetaald.Checked = true;
            VullCmb();
        }

        void VullCmb()
        {
            // Haal lijst op 
            List<string> namen = Program.Deelnemers();

            // Maak cmb leeg
            comboBox1.Items.Clear();

            // Overloop de lijst met namen en steek ze 1 voor 1 in de cmb
            foreach(string s in namen)
            {
                comboBox1.Items.Add(s);
            }
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // kijken of alles werd ingevuld.
            if (comboBox1.SelectedIndex != -1 && txtNaam.Text != "" && cmbAfstand.SelectedIndex != -1)//als een combobox niet veranderd is dan is de index -1. 
            {
                // Sla alle ontvangen gegevens op in een variabele
                int ontvInd = comboBox1.SelectedIndex;
                string ontvNm = txtNaam.Text;
                int ontvAfs = 0;
                if (cmbAfstand.SelectedIndex == 0)
                {
                    ontvAfs = 5;
                }
                else if (cmbAfstand.SelectedIndex == 1)
                {
                    ontvAfs = 10;
                }
                else if (cmbAfstand.SelectedIndex == 2)
                {
                    ontvAfs = 20;
                }

                bool ontvBet = false;
                if (rbBetaald.Checked)
                {
                    ontvBet = true;
                }
                // Stuur door naar een business om aan te passen 
                Program.Aanpassen(ontvInd,ontvNm, ontvAfs, ontvBet);

                // Bevestig bij de gebruiker 
                MessageBox.Show("Deze persoon is aangepast", "succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // reset from 
                comboBox1.SelectedIndex = -1;
                comboBox1.Text = "";
                txtNaam.Text = "";
                cmbAfstand.SelectedIndex = -1;
                cmbAfstand.Text = "";
                rbNietbetaald.Checked = true;
                VullCmb();

            }
            else
            {
                // Foutmelding
                MessageBox.Show("u heeft niet alles ingevuld", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblVerwijderen_Click(object sender, EventArgs e)
        {
            // Kijken of alles werd ingevuld 
            if (comboBox1.SelectedIndex != -1)
            {
                // Sla de ontvangen gegevens op in een vatriabelen
                int ontvInd = comboBox1.SelectedIndex;

                // Geef de gegevens door naar de business 
                Program.Verwijderen(ontvInd);


                // Bevestig bij de gebruiker 
                MessageBox.Show("Deze persoon is verwijderd", "succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // reset from 
                comboBox1.SelectedIndex = -1;
                comboBox1.Text = "";
                txtNaam.Text = "";
                cmbAfstand.SelectedIndex = -1;
                cmbAfstand.Text = "";
                rbNietbetaald.Checked = true;
                VullCmb();

            }
            else
            {
                // Foutmelding
                MessageBox.Show("u heeft niet alles ingevuld", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
