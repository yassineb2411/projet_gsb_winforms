using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3aApp
{
    public partial class FormDernierRapport : Form
    {
        public FormDernierRapport()
        {
            InitializeComponent();

            rapportClassBindingSource.DataSource = ClassDAL.GetAllRapports();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            MettreAJourResultatsDeRecherche();
        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            MettreAJourResultatsDeRecherche();
        }

        private void MettreAJourResultatsDeRecherche()
        {
            string nomRecherche = textBoxNom.Text;
            string prenomRecherche = textBoxPrenom.Text;

            IList<RapportClass> rapports = ClassDAL.GetAllRapports();

            //Filtrer les rapports en fonction du texte entré dans textBoxNom et textBoxPrenom
            var resultats = rapports.Where(rapport =>
                rapport.nom.ToLower().Contains(nomRecherche) &&
                rapport.prenom.ToLower().Contains(prenomRecherche)
            ).OrderByDescending(rapport => rapport.date).FirstOrDefault();

            //var resultats = rapports.Where(rapport =>
            //    rapport.nom.ToLower().Contains(nomRecherche) &&
            //    rapport.prenom.ToLower().Contains(prenomRecherche)
            //).ToList();


            // Mettre à jour la source de données pour afficher les résultats filtrés
            rapportClassBindingSource.DataSource = resultats;
        }

        private void buttonExporterXml_Click(object sender, EventArgs e)
        {
            // Vérifiez si un rapport est sélectionné dans le DataGridView
            if (dgvRapports.SelectedRows.Count > 0)
            {
                // Récupérez le rapport sélectionné
                RapportClass rapport = dgvRapports.SelectedRows[0].DataBoundItem as RapportClass;

                // Vérifiez si le rapport n'est pas null
                if (rapport != null)
                {
                    // Obtenir le chemin du répertoire Téléchargements de l'utilisateur
                    string cheminTelechargements = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

                    // Créez un sérialiseur XML pour la classe RapportClass
                    System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(RapportClass));

                    // Créez le chemin complet du fichier XML dans le répertoire Téléchargements
                    string cheminFichierXML = Path.Combine(cheminTelechargements, "rapport.xml");

                    // Créez un flux pour écrire les données XML
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(cheminFichierXML))
                    {
                        // Sérialisez le rapport et écrivez-le dans le flux
                        serializer.Serialize(writer, rapport);
                    }

                    MessageBox.Show("Rapport exporté au format XML dans le répertoire Téléchargements avec succès !");
                }
                else
                {
                    MessageBox.Show("Aucun rapport sélectionné.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un rapport à exporter.");
            }
        }
    }
}
