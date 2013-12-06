namespace Projet3
{
    partial class frmAjoutEmploye
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
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label motDePasseLabel;
            System.Windows.Forms.Label noLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label notypeEmployeLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label salaireHoraireLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label villeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutEmploye));
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.courrielTextBox = new System.Windows.Forms.TextBox();
            this.motDePasseTextBox = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.noCiviqueTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.rueTextBox = new System.Windows.Forms.TextBox();
            this.salaireHoraireTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.cmbTypeEmploye = new System.Windows.Forms.ComboBox();
            this.typesEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.ageNumeric = new System.Windows.Forms.NumericUpDown();
            this.telTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celTextBox = new System.Windows.Forms.MaskedTextBox();
            ageLabel = new System.Windows.Forms.Label();
            cellulaireLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            motDePasseLabel = new System.Windows.Forms.Label();
            noLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            notypeEmployeLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            salaireHoraireLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(19, 206);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 1;
            ageLabel.Text = "Age:";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Location = new System.Drawing.Point(19, 374);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(56, 13);
            cellulaireLabel.TabIndex = 3;
            cellulaireLabel.Text = "*Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(271, 289);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 5;
            codePostalLabel.Text = "Code Postal:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(19, 304);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(45, 13);
            courrielLabel.TabIndex = 7;
            courrielLabel.Text = "Courriel:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Location = new System.Drawing.Point(271, 123);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(52, 13);
            idProvinceLabel.TabIndex = 9;
            idProvinceLabel.Text = "Province:";
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Location = new System.Drawing.Point(19, 235);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(77, 13);
            motDePasseLabel.TabIndex = 11;
            motDePasseLabel.Text = "Mot De Passe:";
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Location = new System.Drawing.Point(19, 123);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(24, 13);
            noLabel.TabIndex = 13;
            noLabel.Text = "No:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Location = new System.Drawing.Point(271, 341);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(62, 13);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(19, 180);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 17;
            nomLabel.Text = "Nom:";
            // 
            // notypeEmployeLabel
            // 
            notypeEmployeLabel.AutoSize = true;
            notypeEmployeLabel.Location = new System.Drawing.Point(497, 123);
            notypeEmployeLabel.Name = "notypeEmployeLabel";
            notypeEmployeLabel.Size = new System.Drawing.Size(84, 13);
            notypeEmployeLabel.TabIndex = 19;
            notypeEmployeLabel.Text = "Type d\'employé:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(19, 152);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 21;
            prenomLabel.Text = "Prénom:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(508, 235);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(66, 13);
            remarqueLabel.TabIndex = 23;
            remarqueLabel.Text = "* Remarque:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(271, 176);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(30, 13);
            rueLabel.TabIndex = 25;
            rueLabel.Text = "Rue:";
            // 
            // salaireHoraireLabel
            // 
            salaireHoraireLabel.AutoSize = true;
            salaireHoraireLabel.Location = new System.Drawing.Point(498, 176);
            salaireHoraireLabel.Name = "salaireHoraireLabel";
            salaireHoraireLabel.Size = new System.Drawing.Size(79, 13);
            salaireHoraireLabel.TabIndex = 27;
            salaireHoraireLabel.Text = "Salaire Horaire:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(19, 266);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 29;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(19, 337);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 31;
            telephoneLabel.Text = "Telephone:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(271, 233);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 33;
            villeLabel.Text = "Ville:";
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataSource = typeof(Projet3.Employes);
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.Location = new System.Drawing.Point(364, 286);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(100, 20);
            this.codePostalTextBox.TabIndex = 6;
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.Location = new System.Drawing.Point(112, 301);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(100, 20);
            this.courrielTextBox.TabIndex = 8;
            this.courrielTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.courrielTextBox_Validating);
            // 
            // motDePasseTextBox
            // 
            this.motDePasseTextBox.Location = new System.Drawing.Point(112, 232);
            this.motDePasseTextBox.Name = "motDePasseTextBox";
            this.motDePasseTextBox.Size = new System.Drawing.Size(100, 20);
            this.motDePasseTextBox.TabIndex = 12;
            this.motDePasseTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.motDePasseTextBox_Validating);
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "No", true));
            this.noTextBox.Enabled = false;
            this.noTextBox.Location = new System.Drawing.Point(112, 120);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.ReadOnly = true;
            this.noTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTextBox.TabIndex = 14;
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.Location = new System.Drawing.Point(364, 338);
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.noCiviqueTextBox.TabIndex = 16;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(112, 177);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 18;
            this.nomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nomTextBox_Validating);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(112, 149);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 22;
            this.prenomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.prenomTextBox_Validating);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.Location = new System.Drawing.Point(601, 232);
            this.remarqueTextBox.Multiline = true;
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(100, 74);
            this.remarqueTextBox.TabIndex = 24;
            // 
            // rueTextBox
            // 
            this.rueTextBox.Location = new System.Drawing.Point(364, 173);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(100, 20);
            this.rueTextBox.TabIndex = 26;
            // 
            // salaireHoraireTextBox
            // 
            this.salaireHoraireTextBox.Location = new System.Drawing.Point(601, 173);
            this.salaireHoraireTextBox.Name = "salaireHoraireTextBox";
            this.salaireHoraireTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaireHoraireTextBox.TabIndex = 28;
            // 
            // villeTextBox
            // 
            this.villeTextBox.Location = new System.Drawing.Point(364, 230);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(100, 20);
            this.villeTextBox.TabIndex = 34;
            // 
            // cmbTypeEmploye
            // 
            this.cmbTypeEmploye.DataSource = this.typesEmployeBindingSource;
            this.cmbTypeEmploye.DisplayMember = "Description";
            this.cmbTypeEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeEmploye.FormattingEnabled = true;
            this.cmbTypeEmploye.Location = new System.Drawing.Point(601, 123);
            this.cmbTypeEmploye.Name = "cmbTypeEmploye";
            this.cmbTypeEmploye.Size = new System.Drawing.Size(119, 21);
            this.cmbTypeEmploye.TabIndex = 48;
            this.cmbTypeEmploye.ValueMember = "No";
            // 
            // typesEmployeBindingSource
            // 
            this.typesEmployeBindingSource.DataSource = typeof(Projet3.TypesEmploye);
            // 
            // cmbSexe
            // 
            this.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "H",
            "F"});
            this.cmbSexe.Location = new System.Drawing.Point(112, 263);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(100, 21);
            this.cmbSexe.TabIndex = 49;
            this.cmbSexe.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSexe_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 43);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ajout d\'un employés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(56, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "* signifie que l\'information est facultatif";
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjout.BackgroundImage")));
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjout.Location = new System.Drawing.Point(503, 327);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(78, 74);
            this.btnAjout.TabIndex = 52;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.BackgroundImage")));
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnuler.Location = new System.Drawing.Point(623, 327);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(78, 74);
            this.btnAnnuler.TabIndex = 53;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cbProvince
            // 
            this.cbProvince.DataSource = this.provincesBindingSource;
            this.cbProvince.DisplayMember = "Nom";
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(364, 123);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(117, 21);
            this.cbProvince.TabIndex = 54;
            this.cbProvince.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(Projet3.Provinces);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // ageNumeric
            // 
            this.ageNumeric.Location = new System.Drawing.Point(112, 204);
            this.ageNumeric.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.ageNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageNumeric.Name = "ageNumeric";
            this.ageNumeric.Size = new System.Drawing.Size(100, 20);
            this.ageNumeric.TabIndex = 55;
            this.ageNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(112, 334);
            this.telTextBox.Mask = "(999) 000-0000";
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 20);
            this.telTextBox.TabIndex = 56;
            this.telTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telTextBox_Validating);
            // 
            // celTextBox
            // 
            this.celTextBox.Location = new System.Drawing.Point(112, 371);
            this.celTextBox.Mask = "(999) 000-0000";
            this.celTextBox.Name = "celTextBox";
            this.celTextBox.Size = new System.Drawing.Size(100, 20);
            this.celTextBox.TabIndex = 57;
            // 
            // frmAjoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 445);
            this.Controls.Add(this.celTextBox);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.ageNumeric);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSexe);
            this.Controls.Add(this.cmbTypeEmploye);
            this.Controls.Add(ageLabel);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(this.codePostalTextBox);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.courrielTextBox);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(motDePasseLabel);
            this.Controls.Add(this.motDePasseTextBox);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(this.noCiviqueTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(notypeEmployeLabel);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.rueTextBox);
            this.Controls.Add(salaireHoraireLabel);
            this.Controls.Add(this.salaireHoraireTextBox);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.villeTextBox);
            this.Name = "frmAjoutEmploye";
            this.Text = "Ajout des employés";
            this.Load += new System.EventHandler(this.frmAjoutEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employesBindingSource;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.TextBox courrielTextBox;
        private System.Windows.Forms.TextBox motDePasseTextBox;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox noCiviqueTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.TextBox rueTextBox;
        private System.Windows.Forms.TextBox salaireHoraireTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.ComboBox cmbTypeEmploye;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.BindingSource typesEmployeBindingSource;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.NumericUpDown ageNumeric;
        private System.Windows.Forms.MaskedTextBox telTextBox;
        private System.Windows.Forms.MaskedTextBox celTextBox;
    }
}