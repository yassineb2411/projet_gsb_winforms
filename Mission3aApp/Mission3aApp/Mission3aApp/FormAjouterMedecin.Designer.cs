namespace Mission3aApp
{
    partial class FormAjouterMedecin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxSpecialiteComplementaire = new System.Windows.Forms.TextBox();
            this.textBoxDepartement = new System.Windows.Forms.TextBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Téléphone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Spécialité Complémentaire :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Département :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(250, 95);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(113, 22);
            this.textBoxNom.TabIndex = 6;
            this.textBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNom_KeyPress);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(250, 144);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(113, 22);
            this.textBoxPrenom.TabIndex = 7;
            this.textBoxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrenom_KeyPress);
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(250, 190);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(191, 22);
            this.textBoxAdresse.TabIndex = 8;
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(250, 238);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(129, 22);
            this.textBoxTelephone.TabIndex = 9;
            this.textBoxTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelephone_KeyPress);
            // 
            // textBoxSpecialiteComplementaire
            // 
            this.textBoxSpecialiteComplementaire.Location = new System.Drawing.Point(250, 281);
            this.textBoxSpecialiteComplementaire.Name = "textBoxSpecialiteComplementaire";
            this.textBoxSpecialiteComplementaire.Size = new System.Drawing.Size(154, 22);
            this.textBoxSpecialiteComplementaire.TabIndex = 10;
            this.textBoxSpecialiteComplementaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpecialiteComplementaire_KeyPress);
            // 
            // textBoxDepartement
            // 
            this.textBoxDepartement.Location = new System.Drawing.Point(250, 330);
            this.textBoxDepartement.Name = "textBoxDepartement";
            this.textBoxDepartement.Size = new System.Drawing.Size(72, 22);
            this.textBoxDepartement.TabIndex = 11;
            this.textBoxDepartement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDepartement_KeyPress);
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(155, 410);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(208, 33);
            this.buttonEnregistrer.TabIndex = 12;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // FormAjouterMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 502);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.textBoxDepartement);
            this.Controls.Add(this.textBoxSpecialiteComplementaire);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAjouterMedecin";
            this.Text = "GSB | Ajouter un médecin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxSpecialiteComplementaire;
        private System.Windows.Forms.TextBox textBoxDepartement;
        private System.Windows.Forms.Button buttonEnregistrer;
    }
}