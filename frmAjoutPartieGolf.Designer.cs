namespace Projet3
{
    partial class frmAjoutPartieGolf
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
            System.Windows.Forms.Label datePartieLabel;
            System.Windows.Forms.Label idAbonnementLabel;
            System.Windows.Forms.Label noTerrainLabel;
            System.Windows.Forms.Label pointageLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutPartieGolf));
            this.partiesJoueesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datePartieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pointageTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTerrain = new System.Windows.Forms.ComboBox();
            this.terrainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.cbAbonnement = new System.Windows.Forms.ComboBox();
            this.noEtNomCompletAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            datePartieLabel = new System.Windows.Forms.Label();
            idAbonnementLabel = new System.Windows.Forms.Label();
            noTerrainLabel = new System.Windows.Forms.Label();
            pointageLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomCompletAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // datePartieLabel
            // 
            datePartieLabel.AutoSize = true;
            datePartieLabel.Location = new System.Drawing.Point(60, 93);
            datePartieLabel.Name = "datePartieLabel";
            datePartieLabel.Size = new System.Drawing.Size(88, 13);
            datePartieLabel.TabIndex = 1;
            datePartieLabel.Text = "Date de la partie:";
            // 
            // idAbonnementLabel
            // 
            idAbonnementLabel.AutoSize = true;
            idAbonnementLabel.Location = new System.Drawing.Point(60, 131);
            idAbonnementLabel.Name = "idAbonnementLabel";
            idAbonnementLabel.Size = new System.Drawing.Size(117, 13);
            idAbonnementLabel.TabIndex = 3;
            idAbonnementLabel.Text = "Numéro d\'abonnement:";
            // 
            // noTerrainLabel
            // 
            noTerrainLabel.AutoSize = true;
            noTerrainLabel.Location = new System.Drawing.Point(60, 167);
            noTerrainLabel.Name = "noTerrainLabel";
            noTerrainLabel.Size = new System.Drawing.Size(43, 13);
            noTerrainLabel.TabIndex = 5;
            noTerrainLabel.Text = "Terrain:";
            // 
            // pointageLabel
            // 
            pointageLabel.AutoSize = true;
            pointageLabel.Location = new System.Drawing.Point(60, 201);
            pointageLabel.Name = "pointageLabel";
            pointageLabel.Size = new System.Drawing.Size(52, 13);
            pointageLabel.TabIndex = 7;
            pointageLabel.Text = "Pointage:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(60, 234);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 9;
            remarqueLabel.Text = "Remarque:";
            // 
            // partiesJoueesBindingSource
            // 
            this.partiesJoueesBindingSource.DataSource = typeof(Projet3.PartiesJouees);
            // 
            // datePartieDateTimePicker
            // 
            this.datePartieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partiesJoueesBindingSource, "DatePartie", true));
            this.datePartieDateTimePicker.Location = new System.Drawing.Point(183, 93);
            this.datePartieDateTimePicker.Name = "datePartieDateTimePicker";
            this.datePartieDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datePartieDateTimePicker.TabIndex = 2;
            // 
            // pointageTextBox
            // 
            this.pointageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "Pointage", true));
            this.pointageTextBox.Location = new System.Drawing.Point(183, 198);
            this.pointageTextBox.Name = "pointageTextBox";
            this.pointageTextBox.Size = new System.Drawing.Size(200, 20);
            this.pointageTextBox.TabIndex = 8;
            this.pointageTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.pointageTextBox_Validating);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(183, 231);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.remarqueTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 43);
            this.label1.TabIndex = 51;
            this.label1.Text = "Inscription d\'une partie de golf jouée";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(Projet3.Abonnements);
            // 
            // cbTerrain
            // 
            this.cbTerrain.DataSource = this.terrainsBindingSource;
            this.cbTerrain.DisplayMember = "Nom";
            this.cbTerrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerrain.FormattingEnabled = true;
            this.cbTerrain.Location = new System.Drawing.Point(183, 159);
            this.cbTerrain.Name = "cbTerrain";
            this.cbTerrain.Size = new System.Drawing.Size(200, 21);
            this.cbTerrain.TabIndex = 53;
            this.cbTerrain.ValueMember = "No";
            // 
            // terrainsBindingSource
            // 
            this.terrainsBindingSource.DataSource = typeof(Projet3.Terrains);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.BackgroundImage")));
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnuler.Location = new System.Drawing.Point(302, 264);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 75);
            this.btnAnnuler.TabIndex = 80;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjout.BackgroundImage")));
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjout.Location = new System.Drawing.Point(130, 264);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(81, 75);
            this.btnAjout.TabIndex = 79;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // cbAbonnement
            // 
            this.cbAbonnement.DataSource = this.noEtNomCompletAbonnementBindingSource;
            this.cbAbonnement.DisplayMember = "nomCompletAbonnement";
            this.cbAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbonnement.FormattingEnabled = true;
            this.cbAbonnement.Location = new System.Drawing.Point(183, 122);
            this.cbAbonnement.Name = "cbAbonnement";
            this.cbAbonnement.Size = new System.Drawing.Size(200, 21);
            this.cbAbonnement.TabIndex = 81;
            this.cbAbonnement.ValueMember = "noAbonnement";
            // 
            // noEtNomCompletAbonnementBindingSource
            // 
            this.noEtNomCompletAbonnementBindingSource.DataSource = typeof(Projet3.noEtNomCompletAbonnement);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjoutPartieGolf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 351);
            this.Controls.Add(this.cbAbonnement);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.cbTerrain);
            this.Controls.Add(this.label1);
            this.Controls.Add(datePartieLabel);
            this.Controls.Add(this.datePartieDateTimePicker);
            this.Controls.Add(idAbonnementLabel);
            this.Controls.Add(noTerrainLabel);
            this.Controls.Add(pointageLabel);
            this.Controls.Add(this.pointageTextBox);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Name = "frmAjoutPartieGolf";
            this.Text = "Inscription d\'une nouvelle partie de golf";
            this.Load += new System.EventHandler(this.frmAjoutPartieGolf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terrainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomCompletAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource partiesJoueesBindingSource;
        private System.Windows.Forms.DateTimePicker datePartieDateTimePicker;
        private System.Windows.Forms.TextBox pointageTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.ComboBox cbTerrain;
        private System.Windows.Forms.BindingSource terrainsBindingSource;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ComboBox cbAbonnement;
        private System.Windows.Forms.BindingSource noEtNomCompletAbonnementBindingSource;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}