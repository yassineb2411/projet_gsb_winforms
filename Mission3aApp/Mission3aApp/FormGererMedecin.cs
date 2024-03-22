using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "id"; 
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            idColumn.ReadOnly = true; 
            dgvMedecin.Columns.Add(idColumn);

            // Activez la génération automatique des lignes pour que l'ID s'incrémente automatiquement
            dgvMedecin.AutoGenerateColumns = true;
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            string nom = comboBoxNom.Text;
            string departement = comboBoxDepartement.Text;
            medecinClassBindingSource.DataSource = ClassDAL.GetAllMedecinsByNomDep(nom, departement);
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
                foreach (DataGridViewRow row in dgvMedecin.Rows)
                {
                    if (row.Cells["nomDataGridViewTextBoxColumn"].Value != null && row.Cells["departementDataGridViewTextBoxColumn"].Value != null )
                    {
                        int id = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                        string nom = row.Cells["nomDataGridViewTextBoxColumn"].Value.ToString();
                        string prenom = row.Cells["prenomDataGridViewTextBoxColumn"].Value.ToString();
                        string adresse = row.Cells["adresseDataGridViewTextBoxColumn"].Value.ToString();

                        // Vérifier si la valeur de la cellule "tel" n'est pas vide
                        int tel;
                            // Tentative de conversion de la valeur de la cellule en entier
                            if (int.TryParse(row.Cells["telDataGridViewTextBoxColumn"].Value.ToString(), out tel))
                            {
                                // Conversion réussie, "tel" contient l'entier
                            }
                            else
                            {
                                // La valeur de la cellule "tel" n'est pas un entier valide
                                MessageBox.Show("Le numéro de téléphone n'est pas un entier valide pour l'enregistrement avec l'ID " + id);
                                return; // Sortir de la méthode pour éviter d'enregistrer des données invalides
                            }

                        string specialiteComplementaire = row.Cells["specialiteComplementaireDataGridViewTextBoxColumn"].Value != null
                            ? row.Cells["specialiteComplementaireDataGridViewTextBoxColumn"].Value.ToString()
                            : null;

                        int departement;
                        if (int.TryParse(row.Cells["departementDataGridViewTextBoxColumn"].Value.ToString(), out departement))
                        {

                        }
                        else
                        {
                            // La valeur de la cellule "departement" n'est pas un entier valide
                            MessageBox.Show("Le département n'est pas un entier valide pour l'enregistrement avec l'ID " + id);
                            return; // Sortir de la méthode pour éviter d'enregistrer des données invalides
                        }

                    ClassDAL.UpdateMedecin(id, nom, prenom, adresse, tel, specialiteComplementaire, departement);
                    }
                }

                MessageBox.Show("Modifications enregistrées avec succès !");
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            FormAjouterMedecin formAjouterMedecin = new FormAjouterMedecin(dgvMedecin);
            DialogResult result = formAjouterMedecin.ShowDialog();          
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvMedecin.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMedecin.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value);

                int reportCount = ClassDAL.GetMedecinByRapport(id);

                if (reportCount > 0)
                {
                    MessageBox.Show("Ce médecin ne peut pas être supprimé car il est associé à des rapports.");
                }
                else
                {
                    ClassDAL.DeleteMedecin(id);
                    MessageBox.Show("Médecin supprimé avec succès !");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un médecin à supprimer.");
            }
        }
    }
}

