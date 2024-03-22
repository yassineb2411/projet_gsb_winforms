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
    public partial class FormAjouterMedecin : Form
    {
        private DataGridView dgvMedecin;
        public FormAjouterMedecin(DataGridView dataGridView)
        {
            InitializeComponent();
            dgvMedecin = dataGridView; // Initialisez la référence au DataGridView
        }

        private void textBoxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Annuler le traitement de l'événement pour les chiffres
            }
        }

        private void textBoxPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Annuler le traitement de l'événement pour les chiffres
            }
        }

        private void textBoxSpecialiteComplementaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Annuler le traitement de l'événement pour les chiffres
            }
        }

        private void textBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Annuler le traitement de l'événement pour les lettres
            }
        }

        private void textBoxDepartement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Annuler le traitement de l'événement pour les lettres
            }
        }

        public string GetNom()
        {
            return textBoxNom.Text;
        }

        public string GetPrenom()
        {
            return textBoxPrenom.Text;
        }

        public string GetAdresse()
        {
            return textBoxAdresse.Text;
        }

        public int GetTel()
        {
            return Convert.ToInt32(textBoxTelephone.Text);
        }

        public string GetSpecialiteComplementaire()
        {
            return textBoxSpecialiteComplementaire.Text;
        }

        public int GetDepartement()
        {
            return Convert.ToInt32(textBoxDepartement.Text);
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = GetNom();
            string prenom = GetPrenom();
            string adresse = GetAdresse();
            int tel = GetTel();
            string specialiteComplementaire = GetSpecialiteComplementaire();
            int departement = GetDepartement();
            int maxId = ClassDAL.GetMaxMedecinId();
            int newId = maxId + 1;

            try
            {
                ClassDAL.AddMedecin(newId, nom, prenom, adresse, tel, specialiteComplementaire, departement);
                MessageBox.Show("Médecin ajouté avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout du médecin : " + ex.Message);
            }
        }
    }
}
