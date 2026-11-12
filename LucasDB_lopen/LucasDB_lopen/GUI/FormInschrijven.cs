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
    public partial class FormInschrijven : Form
    {
        public FormInschrijven()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grbBetaald_Enter(object sender, EventArgs e)
        {

        }

        private void rbNietbetaald_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInschrijven_Click(object sender, EventArgs e)
        {
            // kijken of alles werd ingevuld.
            if (txtNaam.Text != "" && cmbAfstand.SelectedIndex != -1)//als een combobox niet veranderd is dan is de index -1. 
            {
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
                // Stuur door naar een business om op te slaan 
                Program.Inschrijven(ontvNm, ontvAfs , ontvBet);

                // Bevestig bij de gebruiker 
                MessageBox.Show("Deze persoon is ingeschreven", "succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // reset from 
                txtNaam.Text = "";
                cmbAfstand.SelectedIndex = -1;
                cmbAfstand.Text = "";
                rbNietbetaald.Checked = true; 

            }
            else
            {
                // Foutmelding
                MessageBox.Show("u heeft niet alles ingevuld", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbAfstand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormInschrijven_Load(object sender, EventArgs e)
        {
            rbNietbetaald.Checked = true;

        }

        
    }
}
