namespace Projet3
{
    partial class frmNbEnfants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNbEnfants));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 86);
            this.label1.TabIndex = 75;
            this.label1.Text = "Quel est le nombre d\'enfant \r\nque vous voulez abonner?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(44, 98);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(337, 20);
            this.numericUpDown1.TabIndex = 76;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.BackgroundImage")));
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnuler.Location = new System.Drawing.Point(228, 124);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 75);
            this.btnAnnuler.TabIndex = 78;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjout.BackgroundImage")));
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjout.Location = new System.Drawing.Point(108, 124);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(81, 75);
            this.btnAjout.TabIndex = 77;
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // frmNbEnfants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 202);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "frmNbEnfants";
            this.Text = "frmNbEnfants";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjout;
    }
}