using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3aApp
{
    public partial class FormGererMedecin : Form
    {
        public FormGererMedecin()
        {
            InitializeComponent();
            medecinClassBindingSource.DataSource = ClassDAL.GetAll();

            //Afficher les noms dans le comboBoxNom
            comboBoxNom.DataSource = ClassDAL.GetAllNoms();
            comboBoxNom.DisplayMember = "nom";

            //Afficher les departements dans le comboBoxDepartement
            comboBoxDepartement.DataSource = ClassDAL.GetAllDepartements();
            comboBoxDepartement.DisplayMember = "departement";
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            string nom = comboBoxNom.Text;
            string departement = comboBoxDepartement.Text;
            medecinClassBindingSource.DataSource = ClassDAL.GetAllMedecinsByNomDep(nom, departement);
        }
    }
}
