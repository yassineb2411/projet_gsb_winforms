namespace Mission3aApp
{
    partial class FormGererMedecin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvMedecin = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialiteComplementaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxRecherche = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.comboBoxNom = new System.Windows.Forms.ComboBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.comboBoxDepartement = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonActualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinClassBindingSource)).BeginInit();
            this.groupBoxRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedecin
            // 
            this.dgvMedecin.AutoGenerateColumns = false;
            this.dgvMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedecin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.specialiteComplementaireDataGridViewTextBoxColumn,
            this.departementDataGridViewTextBoxColumn});
            this.dgvMedecin.DataSource = this.medecinClassBindingSource;
            this.dgvMedecin.Location = new System.Drawing.Point(32, 229);
            this.dgvMedecin.Name = "dgvMedecin";
            this.dgvMedecin.RowHeadersWidth = 51;
            this.dgvMedecin.RowTemplate.Height = 24;
            this.dgvMedecin.Size = new System.Drawing.Size(905, 251);
            this.dgvMedecin.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.Width = 125;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.Width = 125;
            // 
            // specialiteComplementaireDataGridViewTextBoxColumn
            // 
            this.specialiteComplementaireDataGridViewTextBoxColumn.DataPropertyName = "specialiteComplementaire";
            this.specialiteComplementaireDataGridViewTextBoxColumn.HeaderText = "specialiteComplementaire";
            this.specialiteComplementaireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialiteComplementaireDataGridViewTextBoxColumn.Name = "specialiteComplementaireDataGridViewTextBoxColumn";
            this.specialiteComplementaireDataGridViewTextBoxColumn.Width = 125;
            // 
            // departementDataGridViewTextBoxColumn
            // 
            this.departementDataGridViewTextBoxColumn.DataPropertyName = "departement";
            this.departementDataGridViewTextBoxColumn.HeaderText = "departement";
            this.departementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departementDataGridViewTextBoxColumn.Name = "departementDataGridViewTextBoxColumn";
            this.departementDataGridViewTextBoxColumn.Width = 125;
            // 
            // medecinClassBindingSource
            // 
            this.medecinClassBindingSource.DataSource = typeof(Mission3aApp.MedecinClass);
            // 
            // groupBoxRecherche
            // 
            this.groupBoxRecherche.Controls.Add(this.buttonActualiser);
            this.groupBoxRecherche.Controls.Add(this.button4);
            this.groupBoxRecherche.Controls.Add(this.buttonAjouter);
            this.groupBoxRecherche.Controls.Add(this.buttonSupprimer);
            this.groupBoxRecherche.Controls.Add(this.comboBoxNom);
            this.groupBoxRecherche.Controls.Add(this.buttonEnregistrer);
            this.groupBoxRecherche.Controls.Add(this.buttonRechercher);
            this.groupBoxRecherche.Controls.Add(this.comboBoxDepartement);
            this.groupBoxRecherche.Controls.Add(this.label2);
            this.groupBoxRecherche.Controls.Add(this.label1);
            this.groupBoxRecherche.Location = new System.Drawing.Point(32, 28);
            this.groupBoxRecherche.Name = "groupBoxRecherche";
            this.groupBoxRecherche.Size = new System.Drawing.Size(905, 186);
            this.groupBoxRecherche.TabIndex = 1;
            this.groupBoxRecherche.TabStop = false;
            this.groupBoxRecherche.Text = "Recherche";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(682, 76);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(154, 35);
            this.buttonAjouter.TabIndex = 8;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(682, 117);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(154, 35);
            this.buttonSupprimer.TabIndex = 7;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // comboBoxNom
            // 
            this.comboBoxNom.DataSource = this.medecinClassBindingSource;
            this.comboBoxNom.FormattingEnabled = true;
            this.comboBoxNom.Location = new System.Drawing.Point(137, 36);
            this.comboBoxNom.Name = "comboBoxNom";
            this.comboBoxNom.Size = new System.Drawing.Size(241, 24);
            this.comboBoxNom.TabIndex = 6;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(682, 36);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(154, 35);
            this.buttonEnregistrer.TabIndex = 5;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(453, 36);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(154, 35);
            this.buttonRechercher.TabIndex = 4;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // comboBoxDepartement
            // 
            this.comboBoxDepartement.FormattingEnabled = true;
            this.comboBoxDepartement.Location = new System.Drawing.Point(137, 123);
            this.comboBoxDepartement.Name = "comboBoxDepartement";
            this.comboBoxDepartement.Size = new System.Drawing.Size(241, 24);
            this.comboBoxDepartement.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Département :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // buttonActualiser
            // 
            this.buttonActualiser.Location = new System.Drawing.Point(453, 117);
            this.buttonActualiser.Name = "buttonActualiser";
            this.buttonActualiser.Size = new System.Drawing.Size(154, 35);
            this.buttonActualiser.TabIndex = 10;
            this.buttonActualiser.Text = "Actualiser";
            this.buttonActualiser.UseVisualStyleBackColor = true;
            this.buttonActualiser.Click += new System.EventHandler(this.buttonActualiser_Click);
            // 
            // FormGererMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 508);
            this.Controls.Add(this.groupBoxRecherche);
            this.Controls.Add(this.dgvMedecin);
            this.Name = "FormGererMedecin";
            this.Text = "GSB | Gérer les médecins";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinClassBindingSource)).EndInit();
            this.groupBoxRecherche.ResumeLayout(false);
            this.groupBoxRecherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialiteComplementaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departementDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medecinClassBindingSource;
        private System.Windows.Forms.GroupBox groupBoxRecherche;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.ComboBox comboBoxDepartement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNom;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonActualiser;
    }
}