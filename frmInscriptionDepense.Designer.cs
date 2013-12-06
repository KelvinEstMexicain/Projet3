namespace Projet3
{
    partial class frmInscriptionDepense
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
            System.Windows.Forms.Label dateDepenseLabel;
            System.Windows.Forms.Label idAbonnementLabel;
            System.Windows.Forms.Label montantLabel;
            System.Windows.Forms.Label noLabel;
            System.Windows.Forms.Label noServiceLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscriptionDepense));
            this.depensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDepenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.montantTextBox = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.cbAbonnement = new System.Windows.Forms.ComboBox();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.noEtNomCompletAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateDepenseLabel = new System.Windows.Forms.Label();
            idAbonnementLabel = new System.Windows.Forms.Label();
            montantLabel = new System.Windows.Forms.Label();
            noLabel = new System.Windows.Forms.Label();
            noServiceLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomCompletAbonnementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDepenseLabel
            // 
            dateDepenseLabel.AutoSize = true;
            dateDepenseLabel.Location = new System.Drawing.Point(87, 73);
            dateDepenseLabel.Name = "dateDepenseLabel";
            dateDepenseLabel.Size = new System.Drawing.Size(79, 13);
            dateDepenseLabel.TabIndex = 1;
            dateDepenseLabel.Text = "Date Depense:";
            // 
            // idAbonnementLabel
            // 
            idAbonnementLabel.AutoSize = true;
            idAbonnementLabel.Location = new System.Drawing.Point(87, 98);
            idAbonnementLabel.Name = "idAbonnementLabel";
            idAbonnementLabel.Size = new System.Drawing.Size(70, 13);
            idAbonnementLabel.TabIndex = 3;
            idAbonnementLabel.Text = "Abonnement:";
            // 
            // montantLabel
            // 
            montantLabel.AutoSize = true;
            montantLabel.Location = new System.Drawing.Point(87, 124);
            montantLabel.Name = "montantLabel";
            montantLabel.Size = new System.Drawing.Size(49, 13);
            montantLabel.TabIndex = 5;
            montantLabel.Text = "Montant:";
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Location = new System.Drawing.Point(87, 150);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(24, 13);
            noLabel.TabIndex = 7;
            noLabel.Text = "No:";
            // 
            // noServiceLabel
            // 
            noServiceLabel.AutoSize = true;
            noServiceLabel.Location = new System.Drawing.Point(87, 176);
            noServiceLabel.Name = "noServiceLabel";
            noServiceLabel.Size = new System.Drawing.Size(46, 13);
            noServiceLabel.TabIndex = 9;
            noServiceLabel.Text = "Service:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(87, 202);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 11;
            remarqueLabel.Text = "Remarque:";
            // 
            // depensesBindingSource
            // 
            this.depensesBindingSource.DataSource = typeof(Projet3.Depenses);
            // 
            // dateDepenseDateTimePicker
            // 
            this.dateDepenseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.depensesBindingSource, "DateDepense", true));
            this.dateDepenseDateTimePicker.Location = new System.Drawing.Point(175, 69);
            this.dateDepenseDateTimePicker.Name = "dateDepenseDateTimePicker";
            this.dateDepenseDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDepenseDateTimePicker.TabIndex = 2;
            // 
            // montantTextBox
            // 
            this.montantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "Montant", true));
            this.montantTextBox.Location = new System.Drawing.Point(175, 121);
            this.montantTextBox.Name = "montantTextBox";
            this.montantTextBox.Size = new System.Drawing.Size(200, 20);
            this.montantTextBox.TabIndex = 6;
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "No", true));
            this.noTextBox.Location = new System.Drawing.Point(175, 147);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(102, 20);
            this.noTextBox.TabIndex = 8;
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(175, 199);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.remarqueTextBox.TabIndex = 12;
            // 
            // cbAbonnement
            // 
            this.cbAbonnement.DataSource = this.noEtNomCompletAbonnementBindingSource;
            this.cbAbonnement.DisplayMember = "nomCompletAbonnement";
            this.cbAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbonnement.FormattingEnabled = true;
            this.cbAbonnement.Location = new System.Drawing.Point(175, 94);
            this.cbAbonnement.Name = "cbAbonnement";
            this.cbAbonnement.Size = new System.Drawing.Size(200, 21);
            this.cbAbonnement.TabIndex = 13;
            this.cbAbonnement.ValueMember = "noAbonnement";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(Projet3.Abonnements);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "Inscription d\'une dépense";
            // 
            // txtService
            // 
            this.txtService.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "Remarque", true));
            this.txtService.Location = new System.Drawing.Point(175, 173);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(200, 20);
            this.txtService.TabIndex = 16;
            // 
            // btnAjout
            // 
            this.btnAjout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjout.BackgroundImage")));
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjout.Location = new System.Drawing.Point(83, 238);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(83, 80);
            this.btnAjout.TabIndex = 17;
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.BackgroundImage")));
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnuler.Location = new System.Drawing.Point(282, 238);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(78, 80);
            this.btnAnnuler.TabIndex = 58;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // noEtNomCompletAbonnementBindingSource
            // 
            this.noEtNomCompletAbonnementBindingSource.DataSource = typeof(Projet3.noEtNomCompletAbonnement);
            // 
            // frmInscriptionDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(451, 330);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAbonnement);
            this.Controls.Add(dateDepenseLabel);
            this.Controls.Add(this.dateDepenseDateTimePicker);
            this.Controls.Add(idAbonnementLabel);
            this.Controls.Add(montantLabel);
            this.Controls.Add(this.montantTextBox);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(noServiceLabel);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Name = "frmInscriptionDepense";
            this.Text = "Inscription d\'une dépense";
            this.Load += new System.EventHandler(this.frmInscriptionDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomCompletAbonnementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource depensesBindingSource;
        private System.Windows.Forms.DateTimePicker dateDepenseDateTimePicker;
        private System.Windows.Forms.TextBox montantTextBox;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.ComboBox cbAbonnement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.BindingSource noEtNomCompletAbonnementBindingSource;

    }
}