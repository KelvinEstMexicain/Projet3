﻿namespace Projet3
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnAjoutAbonnement = new System.Windows.Forms.Button();
            this.btnGestionEmployes = new System.Windows.Forms.Button();
            this.btnAjoutDepenses = new System.Windows.Forms.Button();
            this.btnReabonnement = new System.Windows.Forms.Button();
            this.btnIncrirePartie = new System.Windows.Forms.Button();
            this.btnInscrireDepense = new System.Windows.Forms.Button();
            this.btnRapport = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnModifierAbonnes = new System.Windows.Forms.Button();
            this.btnDeco = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjoutAbonnement
            // 
            this.btnAjoutAbonnement.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutAbonnement.Location = new System.Drawing.Point(159, 48);
            this.btnAjoutAbonnement.Name = "btnAjoutAbonnement";
            this.btnAjoutAbonnement.Size = new System.Drawing.Size(122, 52);
            this.btnAjoutAbonnement.TabIndex = 0;
            this.btnAjoutAbonnement.Text = "Ajout d\'un abonnement";
            this.btnAjoutAbonnement.UseVisualStyleBackColor = true;
            this.btnAjoutAbonnement.Click += new System.EventHandler(this.btnAjoutAbonnement_Click);
            // 
            // btnGestionEmployes
            // 
            this.btnGestionEmployes.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEmployes.Location = new System.Drawing.Point(12, 50);
            this.btnGestionEmployes.Name = "btnGestionEmployes";
            this.btnGestionEmployes.Size = new System.Drawing.Size(122, 50);
            this.btnGestionEmployes.TabIndex = 2;
            this.btnGestionEmployes.Text = "Gestion d\'un employes";
            this.btnGestionEmployes.UseVisualStyleBackColor = true;
            this.btnGestionEmployes.Click += new System.EventHandler(this.btnGestionEmployes_Click);
            // 
            // btnAjoutDepenses
            // 
            this.btnAjoutDepenses.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutDepenses.Location = new System.Drawing.Point(12, 113);
            this.btnAjoutDepenses.Name = "btnAjoutDepenses";
            this.btnAjoutDepenses.Size = new System.Drawing.Size(122, 84);
            this.btnAjoutDepenses.TabIndex = 3;
            this.btnAjoutDepenses.Text = "Ajout d\'un prix et des dépenses obligatoires";
            this.btnAjoutDepenses.UseVisualStyleBackColor = true;
            this.btnAjoutDepenses.Click += new System.EventHandler(this.btnAjoutDepenses_Click);
            // 
            // btnReabonnement
            // 
            this.btnReabonnement.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReabonnement.Location = new System.Drawing.Point(159, 129);
            this.btnReabonnement.Name = "btnReabonnement";
            this.btnReabonnement.Size = new System.Drawing.Size(122, 52);
            this.btnReabonnement.TabIndex = 5;
            this.btnReabonnement.Text = "Faire un réabonnement";
            this.btnReabonnement.UseVisualStyleBackColor = true;
            this.btnReabonnement.Click += new System.EventHandler(this.btnReabonnement_Click);
            // 
            // btnIncrirePartie
            // 
            this.btnIncrirePartie.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrirePartie.Location = new System.Drawing.Point(159, 211);
            this.btnIncrirePartie.Name = "btnIncrirePartie";
            this.btnIncrirePartie.Size = new System.Drawing.Size(122, 84);
            this.btnIncrirePartie.TabIndex = 6;
            this.btnIncrirePartie.Text = "Inscrire une partie de golf jouée";
            this.btnIncrirePartie.UseVisualStyleBackColor = true;
            this.btnIncrirePartie.Click += new System.EventHandler(this.btnIncrirePartie_Click);
            // 
            // btnInscrireDepense
            // 
            this.btnInscrireDepense.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscrireDepense.Location = new System.Drawing.Point(12, 223);
            this.btnInscrireDepense.Name = "btnInscrireDepense";
            this.btnInscrireDepense.Size = new System.Drawing.Size(122, 60);
            this.btnInscrireDepense.TabIndex = 7;
            this.btnInscrireDepense.Text = "Inscrire des dépenses";
            this.btnInscrireDepense.UseVisualStyleBackColor = true;
            this.btnInscrireDepense.Click += new System.EventHandler(this.btnInscrireDepense_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapport.Location = new System.Drawing.Point(301, 125);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(122, 60);
            this.btnRapport.TabIndex = 8;
            this.btnRapport.Text = "Visualiser les rapports";
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistiques.Location = new System.Drawing.Point(301, 223);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(122, 60);
            this.btnStatistiques.TabIndex = 9;
            this.btnStatistiques.Text = "Visualiser les statistiques";
            this.btnStatistiques.UseVisualStyleBackColor = true;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnModifierAbonnes
            // 
            this.btnModifierAbonnes.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierAbonnes.Location = new System.Drawing.Point(301, 50);
            this.btnModifierAbonnes.Name = "btnModifierAbonnes";
            this.btnModifierAbonnes.Size = new System.Drawing.Size(122, 60);
            this.btnModifierAbonnes.TabIndex = 10;
            this.btnModifierAbonnes.Text = "Modifier les abonnés";
            this.btnModifierAbonnes.UseVisualStyleBackColor = true;
            this.btnModifierAbonnes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeco
            // 
            this.btnDeco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeco.BackgroundImage")));
            this.btnDeco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeco.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeco.Location = new System.Drawing.Point(59, 326);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(108, 87);
            this.btnDeco.TabIndex = 11;
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitter.BackgroundImage")));
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(282, 326);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(105, 87);
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 425);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.btnModifierAbonnes);
            this.Controls.Add(this.btnStatistiques);
            this.Controls.Add(this.btnRapport);
            this.Controls.Add(this.btnInscrireDepense);
            this.Controls.Add(this.btnIncrirePartie);
            this.Controls.Add(this.btnReabonnement);
            this.Controls.Add(this.btnAjoutDepenses);
            this.Controls.Add(this.btnGestionEmployes);
            this.Controls.Add(this.btnAjoutAbonnement);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutAbonnement;
        private System.Windows.Forms.Button btnGestionEmployes;
        private System.Windows.Forms.Button btnAjoutDepenses;
        private System.Windows.Forms.Button btnReabonnement;
        private System.Windows.Forms.Button btnIncrirePartie;
        private System.Windows.Forms.Button btnInscrireDepense;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnModifierAbonnes;
        private System.Windows.Forms.Button btnDeco;
        private System.Windows.Forms.Button btnQuitter;
    }
}