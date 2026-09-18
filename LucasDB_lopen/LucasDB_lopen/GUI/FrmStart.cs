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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // object aanmaken van form 
             FormInschrijven nieuwFrm = new FormInschrijven();

            // dit dorm hiden 
            Hide();
            // object tonen
            nieuwFrm.ShowDialog();

            // dit form tonen 
            Show();
        }

        private void Btnafsluiten_Click(object sender, EventArgs e)
        {
            // afsluiten 
            Close();
        }

        private void Btnbewerken_Click(object sender, EventArgs e)
        {
            // object aanmaken van form 
            FrmBewerken nieuwFrm = new FrmBewerken();

            // dit dorm hiden 
            Hide();

            // object tonen
            nieuwFrm.ShowDialog();

            // dit form tonen 
            Show();
        }

        private void Btnopzoeken_Click(object sender, EventArgs e)
        {
            // object aanmaken van form 
            FrmOpzoeken nieuwFrm = new FrmOpzoeken();

            // dit dorm hiden 
            Hide();
            // object tonen
            nieuwFrm.ShowDialog();

            // dit form tonen 
            Show();
        }

       
    }
}
