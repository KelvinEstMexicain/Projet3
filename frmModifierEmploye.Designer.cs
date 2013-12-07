namespace Projet3
{
    partial class frmModifierEmploye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifierEmploye));
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.typesEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.provincesComboBox = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDClubDeGolfBDataSet = new Projet3.BDClubDeGolfBDataSet();
            this.provincesTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.ProvincesTableAdapter();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cellulaireMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.typesEmployeComboBox = new System.Windows.Forms.ComboBox();
            this.typesEmployeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typesEmployeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.TypesEmployeTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClubDeGolfBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(9, 181);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 54;
            ageLabel.Text = "Age:";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Location = new System.Drawing.Point(9, 349);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(56, 13);
            cellulaireLabel.TabIndex = 56;
            cellulaireLabel.Text = "*Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(261, 264);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 58;
            codePostalLabel.Text = "Code Postal:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(9, 279);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(45, 13);
            courrielLabel.TabIndex = 60;
            courrielLabel.Text = "Courriel:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Location = new System.Drawing.Point(261, 98);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(52, 13);
            idProvinceLabel.TabIndex = 62;
            idProvinceLabel.Text = "Province:";
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Location = new System.Drawing.Point(9, 210);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(77, 13);
            motDePasseLabel.TabIndex = 63;
            motDePasseLabel.Text = "Mot De Passe:";
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Location = new System.Drawing.Point(9, 98);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(24, 13);
            noLabel.TabIndex = 65;
            noLabel.Text = "No:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Location = new System.Drawing.Point(261, 315);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(62, 13);
            noCiviqueLabel.TabIndex = 67;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(9, 155);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 69;
            nomLabel.Text = "Nom:";
            // 
            // notypeEmployeLabel
            // 
            notypeEmployeLabel.AutoSize = true;
            notypeEmployeLabel.Location = new System.Drawing.Point(487, 98);
            notypeEmployeLabel.Name = "notypeEmployeLabel";
            notypeEmployeLabel.Size = new System.Drawing.Size(84, 13);
            notypeEmployeLabel.TabIndex = 71;
            notypeEmployeLabel.Text = "Type d\'employé:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(9, 127);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 72;
            prenomLabel.Text = "Prénom:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(498, 208);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 74;
            remarqueLabel.Text = "Remarque:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(261, 151);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(30, 13);
            rueLabel.TabIndex = 76;
            rueLabel.Text = "Rue:";
            // 
            // salaireHoraireLabel
            // 
            salaireHoraireLabel.AutoSize = true;
            salaireHoraireLabel.Location = new System.Drawing.Point(488, 151);
            salaireHoraireLabel.Name = "salaireHoraireLabel";
            salaireHoraireLabel.Size = new System.Drawing.Size(79, 13);
            salaireHoraireLabel.TabIndex = 78;
            salaireHoraireLabel.Text = "Salaire Horaire:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(9, 241);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 80;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(9, 312);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 81;
            telephoneLabel.Text = "Telephone:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(261, 208);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 83;
            villeLabel.Text = "Ville:";
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataSource = typeof(Projet3.Employes);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.BackgroundImage")));
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnuler.Location = new System.Drawing.Point(613, 302);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(78, 74);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjout.BackgroundImage")));
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjout.Location = new System.Drawing.Point(493, 302);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(78, 74);
            this.btnAjout.TabIndex = 16;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(46, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "* signifie que l\'information est facultatif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 43);
            this.label1.TabIndex = 88;
            this.label1.Text = "Modifier un employé";
            // 
            // cmbSexe
            // 
            this.cmbSexe.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employesBindingSource, "Sexe", true));
            this.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "H",
            "F"});
            this.cmbSexe.Location = new System.Drawing.Point(102, 238);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(100, 21);
            this.cmbSexe.TabIndex = 4;
            this.cmbSexe.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSexe_Validating);
            // 
            // typesEmployeBindingSource
            // 
            this.typesEmployeBindingSource.DataSource = typeof(Projet3.TypesEmploye);
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(Projet3.Provinces);
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "CodePostal", true));
            this.codePostalTextBox.Location = new System.Drawing.Point(354, 261);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(100, 20);
            this.codePostalTextBox.TabIndex = 11;
            this.codePostalTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.codePostalTextBox_Validating);
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Courriel", true));
            this.courrielTextBox.Location = new System.Drawing.Point(102, 276);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(100, 20);
            this.courrielTextBox.TabIndex = 5;
            this.courrielTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.courrielTextBox_Validating);
            // 
            // motDePasseTextBox
            // 
            this.motDePasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "MotDePasse", true));
            this.motDePasseTextBox.Location = new System.Drawing.Point(102, 207);
            this.motDePasseTextBox.Name = "motDePasseTextBox";
            this.motDePasseTextBox.Size = new System.Drawing.Size(100, 20);
            this.motDePasseTextBox.TabIndex = 3;
            this.motDePasseTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.motDePasseTextBox_Validating);
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "No", true));
            this.noTextBox.Location = new System.Drawing.Point(102, 95);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.ReadOnly = true;
            this.noTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTextBox.TabIndex = 66;
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "NoCivique", true));
            this.noCiviqueTextBox.Location = new System.Drawing.Point(354, 312);
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.noCiviqueTextBox.TabIndex = 12;
            this.noCiviqueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.noCiviqueTextBox_Validating);
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(102, 152);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 1;
            this.nomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nomTextBox_Validating);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(102, 124);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 0;
            this.prenomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.prenomTextBox_Validating);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(591, 205);
            this.remarqueTextBox.Multiline = true;
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(100, 72);
            this.remarqueTextBox.TabIndex = 15;
            this.remarqueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.remarqueTextBox_Validating);
            // 
            // rueTextBox
            // 
            this.rueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Rue", true));
            this.rueTextBox.Location = new System.Drawing.Point(354, 148);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(100, 20);
            this.rueTextBox.TabIndex = 9;
            this.rueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.rueTextBox_Validating);
            // 
            // salaireHoraireTextBox
            // 
            this.salaireHoraireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "SalaireHoraire", true));
            this.salaireHoraireTextBox.Location = new System.Drawing.Point(591, 148);
            this.salaireHoraireTextBox.Name = "salaireHoraireTextBox";
            this.salaireHoraireTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaireHoraireTextBox.TabIndex = 14;
            this.salaireHoraireTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.salaireHoraireTextBox_Validating);
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(354, 205);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(100, 20);
            this.villeTextBox.TabIndex = 10;
            this.villeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.villeTextBox_Validating);
            // 
            // provincesComboBox
            // 
            this.provincesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Provinces", true));
            this.provincesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employesBindingSource, "IdProvince", true));
            this.provincesComboBox.DataSource = this.provincesBindingSource1;
            this.provincesComboBox.DisplayMember = "Nom";
            this.provincesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provincesComboBox.FormattingEnabled = true;
            this.provincesComboBox.Location = new System.Drawing.Point(354, 95);
            this.provincesComboBox.Name = "provincesComboBox";
            this.provincesComboBox.Size = new System.Drawing.Size(118, 21);
            this.provincesComboBox.TabIndex = 8;
            this.provincesComboBox.ValueMember = "Id";
            this.provincesComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.provincesComboBox_Validating);
            // 
            // provincesBindingSource1
            // 
            this.provincesBindingSource1.DataMember = "Provinces";
            this.provincesBindingSource1.DataSource = this.bDClubDeGolfBDataSet;
            // 
            // bDClubDeGolfBDataSet
            // 
            this.bDClubDeGolfBDataSet.DataSetName = "BDClubDeGolfBDataSet";
            this.bDClubDeGolfBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provincesTableAdapter
            // 
            this.provincesTableAdapter.ClearBeforeFill = true;
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employesBindingSource, "Age", true));
            this.ageNumericUpDown.Location = new System.Drawing.Point(102, 179);
            this.ageNumericUpDown.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.ageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.ageNumericUpDown.TabIndex = 2;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Telephone", true));
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(102, 309);
            this.telephoneMaskedTextBox.Mask = "(999) 000-0000";
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telephoneMaskedTextBox.TabIndex = 6;
            this.telephoneMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telephoneMaskedTextBox_Validating);
            // 
            // cellulaireMaskedTextBox
            // 
            this.cellulaireMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Cellulaire", true));
            this.cellulaireMaskedTextBox.Location = new System.Drawing.Point(102, 346);
            this.cellulaireMaskedTextBox.Mask = "(999) 000-0000";
            this.cellulaireMaskedTextBox.Name = "cellulaireMaskedTextBox";
            this.cellulaireMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cellulaireMaskedTextBox.TabIndex = 7;
            this.cellulaireMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cellulaireMaskedTextBox_Validating);
            // 
            // typesEmployeComboBox
            // 
            this.typesEmployeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "TypesEmploye", true));
            this.typesEmployeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employesBindingSource, "NotypeEmploye", true));
            this.typesEmployeComboBox.DataSource = this.typesEmployeBindingSource1;
            this.typesEmployeComboBox.DisplayMember = "Description";
            this.typesEmployeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesEmployeComboBox.Enabled = false;
            this.typesEmployeComboBox.FormattingEnabled = true;
            this.typesEmployeComboBox.Location = new System.Drawing.Point(591, 95);
            this.typesEmployeComboBox.Name = "typesEmployeComboBox";
            this.typesEmployeComboBox.Size = new System.Drawing.Size(179, 21);
            this.typesEmployeComboBox.TabIndex = 13;
            this.typesEmployeComboBox.ValueMember = "No";
            // 
            // typesEmployeBindingSource1
            // 
            this.typesEmployeBindingSource1.DataMember = "TypesEmploye";
            this.typesEmployeBindingSource1.DataSource = this.bDClubDeGolfBDataSet;
            // 
            // typesEmployeTableAdapter
            // 
            this.typesEmployeTableAdapter.ClearBeforeFill = true;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmModifierEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(801, 408);
            this.Controls.Add(this.typesEmployeComboBox);
            this.Controls.Add(this.cellulaireMaskedTextBox);
            this.Controls.Add(this.telephoneMaskedTextBox);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.provincesComboBox);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSexe);
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
            this.Name = "frmModifierEmploye";
            this.Text = "Modifier un employé";
            this.Load += new System.EventHandler(this.frmModifierEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClubDeGolfBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employesBindingSource;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSexe;
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
        private System.Windows.Forms.BindingSource typesEmployeBindingSource;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.ComboBox provincesComboBox;
        private BDClubDeGolfBDataSet bDClubDeGolfBDataSet;
        private System.Windows.Forms.BindingSource provincesBindingSource1;
        private BDClubDeGolfBDataSetTableAdapters.ProvincesTableAdapter provincesTableAdapter;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
        private System.Windows.Forms.MaskedTextBox telephoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cellulaireMaskedTextBox;
        private System.Windows.Forms.ComboBox typesEmployeComboBox;
        private System.Windows.Forms.BindingSource typesEmployeBindingSource1;
        private BDClubDeGolfBDataSetTableAdapters.TypesEmployeTableAdapter typesEmployeTableAdapter;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}