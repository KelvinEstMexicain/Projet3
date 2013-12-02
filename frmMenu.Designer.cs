namespace Projet3
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
            this.btnAjoutAbonnement = new System.Windows.Forms.Button();
            this.btnGestionEmployes = new System.Windows.Forms.Button();
            this.btnAjoutDepenses = new System.Windows.Forms.Button();
            this.btnReabonnement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjoutAbonnement
            // 
            this.btnAjoutAbonnement.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutAbonnement.Location = new System.Drawing.Point(12, 50);
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
            this.btnGestionEmployes.Location = new System.Drawing.Point(12, 130);
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
            this.btnAjoutDepenses.Location = new System.Drawing.Point(12, 219);
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
            this.btnReabonnement.Location = new System.Drawing.Point(159, 50);
            this.btnReabonnement.Name = "btnReabonnement";
            this.btnReabonnement.Size = new System.Drawing.Size(122, 52);
            this.btnReabonnement.TabIndex = 5;
            this.btnReabonnement.Text = "Faire un réabonnement";
            this.btnReabonnement.UseVisualStyleBackColor = true;
            this.btnReabonnement.Click += new System.EventHandler(this.btnReabonnement_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 387);
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
    }
}