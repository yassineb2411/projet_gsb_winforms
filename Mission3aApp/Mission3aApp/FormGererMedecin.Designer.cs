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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialiteComplementaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxRecherche = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxNom = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.comboBoxDepartement = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinClassBindingSource)).BeginInit();
            this.groupBoxRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.specialiteComplementaireDataGridViewTextBoxColumn,
            this.departementDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medecinClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 251);
            this.dataGridView1.TabIndex = 0;
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
            this.groupBoxRecherche.Controls.Add(this.button1);
            this.groupBoxRecherche.Controls.Add(this.comboBoxNom);
            this.groupBoxRecherche.Controls.Add(this.button2);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(563, 36);
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
            // FormGererMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 508);
            this.Controls.Add(this.groupBoxRecherche);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGererMedecin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinClassBindingSource)).EndInit();
            this.groupBoxRecherche.ResumeLayout(false);
            this.groupBoxRecherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialiteComplementaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departementDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medecinClassBindingSource;
        private System.Windows.Forms.GroupBox groupBoxRecherche;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.ComboBox comboBoxDepartement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNom;
        private System.Windows.Forms.Button button1;
    }
}