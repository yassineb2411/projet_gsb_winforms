using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3aApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GererMedecinItem_Click(object sender, EventArgs e)
        {
            FormGererMedecin formGererMedecin = new FormGererMedecin();
            formGererMedecin.Show();
        }

        private void DernierRapportItem_Click(object sender, EventArgs e)
        {
            FormDernierRapport formDernierRapport = new FormDernierRapport();
            formDernierRapport.Show();
        }
    }
}
