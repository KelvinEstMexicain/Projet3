using System;
namespace Projet3
{
    partial class frmAbonnementPrincipal
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
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label dateAbonnementLabel;
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label noTypeAbonnementLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label villeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbonnementPrincipal));
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.courrielTextBox = new System.Windows.Forms.TextBox();
            this.dateAbonnementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateNaissanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.noCiviqueTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.rueTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDClubDeGolfBDataSet = new Projet3.BDClubDeGolfBDataSet();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.typesAbonnementComboBox = new System.Windows.Forms.ComboBox();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesAbonnementTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.TypesAbonnementTableAdapter();
            this.provincesTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.ProvincesTableAdapter();
            this.provincesComboBox = new System.Windows.Forms.ComboBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cellulaireMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            cellulaireLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            dateAbonnementLabel = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            noTypeAbonnementLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClubDeGolfBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Location = new System.Drawing.Point(17, 281);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(56, 13);
            cellulaireLabel.TabIndex = 1;
            cellulaireLabel.Text = "*Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(17, 321);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 3;
            codePostalLabel.Text = "Code Postal:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(17, 358);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(45, 13);
            courrielLabel.TabIndex = 5;
            courrielLabel.Text = "Courriel:";
            // 
            // dateAbonnementLabel
            // 
            dateAbonnementLabel.AutoSize = true;
            dateAbonnementLabel.Location = new System.Drawing.Point(307, 282);
            dateAbonnementLabel.Name = "dateAbonnementLabel";
            dateAbonnementLabel.Size = new System.Drawing.Size(96, 13);
            dateAbonnementLabel.TabIndex = 7;
            dateAbonnementLabel.Text = "Date Abonnement:";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Location = new System.Drawing.Point(307, 242);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(99, 13);
            dateNaissanceLabel.TabIndex = 9;
            dateNaissanceLabel.Text = "Date de naissance:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(17, 89);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Location = new System.Drawing.Point(17, 394);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(52, 13);
            idProvinceLabel.TabIndex = 13;
            idProvinceLabel.Text = "Province:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Location = new System.Drawing.Point(17, 431);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(62, 13);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(17, 149);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 17;
            nomLabel.Text = "Nom:";
            // 
            // noTypeAbonnementLabel
            // 
            noTypeAbonnementLabel.AutoSize = true;
            noTypeAbonnementLabel.Location = new System.Drawing.Point(309, 85);
            noTypeAbonnementLabel.Name = "noTypeAbonnementLabel";
            noTypeAbonnementLabel.Size = new System.Drawing.Size(115, 13);
            noTypeAbonnementLabel.TabIndex = 19;
            noTypeAbonnementLabel.Text = "Type de l\'abonnement:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(17, 118);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 21;
            prenomLabel.Text = "Prénom:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(309, 321);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 23;
            remarqueLabel.Text = "Remarque:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(309, 149);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(30, 13);
            rueLabel.TabIndex = 25;
            rueLabel.Text = "Rue:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(17, 176);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 27;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(17, 241);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 29;
            telephoneLabel.Text = "Télephone:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(309, 209);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 31;
            villeLabel.Text = "Ville:";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(Projet3.Abonnements);
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "CodePostal", true));
            this.codePostalTextBox.Location = new System.Drawing.Point(137, 318);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(147, 20);
            this.codePostalTextBox.TabIndex = 5;
            this.codePostalTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.codePostalTextBox_Validating);
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Courriel", true));
            this.courrielTextBox.Location = new System.Drawing.Point(137, 355);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(147, 20);
            this.courrielTextBox.TabIndex = 6;
            this.courrielTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.courrielTextBox_Validating);
            // 
            // dateAbonnementDateTimePicker
            // 
            this.dateAbonnementDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementsBindingSource, "DateAbonnement", true));
            this.dateAbonnementDateTimePicker.Enabled = false;
            this.dateAbonnementDateTimePicker.Location = new System.Drawing.Point(427, 278);
            this.dateAbonnementDateTimePicker.Name = "dateAbonnementDateTimePicker";
            this.dateAbonnementDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateAbonnementDateTimePicker.TabIndex = 13;
            // 
            // dateNaissanceDateTimePicker
            // 
            this.dateNaissanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementsBindingSource, "DateNaissance", true));
            this.dateNaissanceDateTimePicker.Location = new System.Drawing.Point(427, 238);
            this.dateNaissanceDateTimePicker.MaxDate = new System.DateTime(2013, 12, 6, 23, 51, 24, 745);
            this.dateNaissanceDateTimePicker.Name = "dateNaissanceDateTimePicker";
            this.dateNaissanceDateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.dateNaissanceDateTimePicker.TabIndex = 12;
            this.dateNaissanceDateTimePicker.Value = new System.DateTime(2013, 12, 6, 0, 0, 0, 0);
            this.dateNaissanceDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateNaissanceDateTimePicker_Validating);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(137, 86);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(147, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "NoCivique", true));
            this.noCiviqueTextBox.Location = new System.Drawing.Point(137, 428);
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(147, 20);
            this.noCiviqueTextBox.TabIndex = 8;
            this.noCiviqueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.noCiviqueTextBox_Validating);
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(137, 146);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(147, 20);
            this.nomTextBox.TabIndex = 1;
            this.nomTextBox.TextChanged += new System.EventHandler(this.nomTextBox_TextChanged);
            this.nomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nomTextBox_Validating);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(137, 115);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(147, 20);
            this.prenomTextBox.TabIndex = 0;
            this.prenomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.prenomTextBox_Validating);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(429, 321);
            this.remarqueTextBox.Multiline = true;
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 50);
            this.remarqueTextBox.TabIndex = 14;
            this.remarqueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.remarqueTextBox_Validating);
            // 
            // rueTextBox
            // 
            this.rueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Rue", true));
            this.rueTextBox.Location = new System.Drawing.Point(429, 146);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(200, 20);
            this.rueTextBox.TabIndex = 10;
            this.rueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.rueTextBox_Validating);
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(429, 206);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(200, 20);
            this.villeTextBox.TabIndex = 11;
            this.villeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.villeTextBox_Validating);
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataMember = "Provinces";
            this.provincesBindingSource.DataSource = this.bDClubDeGolfBDataSet;
            // 
            // bDClubDeGolfBDataSet
            // 
            this.bDClubDeGolfBDataSet.DataSetName = "BDClubDeGolfBDataSet";
            this.bDClubDeGolfBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSexe
            // 
            this.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "H",
            "F"});
            this.cmbSexe.Location = new System.Drawing.Point(137, 172);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(147, 21);
            this.cmbSexe.TabIndex = 2;
            this.cmbSexe.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSexe_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(226, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "* signifie que l\'information est facultative";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 43);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nouvel Abonnement";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.BackgroundImage")));
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnuler.Location = new System.Drawing.Point(549, 392);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(78, 74);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjout.BackgroundImage")));
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjout.Location = new System.Drawing.Point(429, 392);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(78, 74);
            this.btnAjout.TabIndex = 15;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // typesAbonnementComboBox
            // 
            this.typesAbonnementComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "TypesAbonnement", true));
            this.typesAbonnementComboBox.DataSource = this.typesAbonnementBindingSource;
            this.typesAbonnementComboBox.DisplayMember = "Description";
            this.typesAbonnementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesAbonnementComboBox.FormattingEnabled = true;
            this.typesAbonnementComboBox.Location = new System.Drawing.Point(429, 82);
            this.typesAbonnementComboBox.Name = "typesAbonnementComboBox";
            this.typesAbonnementComboBox.Size = new System.Drawing.Size(198, 21);
            this.typesAbonnementComboBox.TabIndex = 9;
            this.typesAbonnementComboBox.ValueMember = "No";
            this.typesAbonnementComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.typesAbonnementComboBox_Validating);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataMember = "TypesAbonnement";
            this.typesAbonnementBindingSource.DataSource = this.bDClubDeGolfBDataSet;
            // 
            // typesAbonnementTableAdapter
            // 
            this.typesAbonnementTableAdapter.ClearBeforeFill = true;
            // 
            // provincesTableAdapter
            // 
            this.provincesTableAdapter.ClearBeforeFill = true;
            // 
            // provincesComboBox
            // 
            this.provincesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Provinces", true));
            this.provincesComboBox.DataSource = this.provincesBindingSource;
            this.provincesComboBox.DisplayMember = "Nom";
            this.provincesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provincesComboBox.FormattingEnabled = true;
            this.provincesComboBox.Location = new System.Drawing.Point(137, 391);
            this.provincesComboBox.Name = "provincesComboBox";
            this.provincesComboBox.Size = new System.Drawing.Size(147, 21);
            this.provincesComboBox.TabIndex = 7;
            this.provincesComboBox.ValueMember = "Id";
            this.provincesComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.provincesComboBox_Validating);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Telephone", true));
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(137, 238);
            this.telephoneMaskedTextBox.Mask = "(999) 000-0000";
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(147, 20);
            this.telephoneMaskedTextBox.TabIndex = 3;
            this.telephoneMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telephoneMaskedTextBox_Validating);
            // 
            // cellulaireMaskedTextBox
            // 
            this.cellulaireMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Cellulaire", true));
            this.cellulaireMaskedTextBox.Location = new System.Drawing.Point(137, 278);
            this.cellulaireMaskedTextBox.Mask = "(999) 000-0000";
            this.cellulaireMaskedTextBox.Name = "cellulaireMaskedTextBox";
            this.cellulaireMaskedTextBox.Size = new System.Drawing.Size(147, 20);
            this.cellulaireMaskedTextBox.TabIndex = 4;
            this.cellulaireMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cellulaireMaskedTextBox_Validating);
            // 
            // frmAbonnementPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(674, 486);
            this.Controls.Add(this.cellulaireMaskedTextBox);
            this.Controls.Add(this.telephoneMaskedTextBox);
            this.Controls.Add(this.provincesComboBox);
            this.Controls.Add(this.typesAbonnementComboBox);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSexe);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(this.codePostalTextBox);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.courrielTextBox);
            this.Controls.Add(dateAbonnementLabel);
            this.Controls.Add(this.dateAbonnementDateTimePicker);
            this.Controls.Add(dateNaissanceLabel);
            this.Controls.Add(this.dateNaissanceDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(this.noCiviqueTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(noTypeAbonnementLabel);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.rueTextBox);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.villeTextBox);
            this.Name = "frmAbonnementPrincipal";
            this.Text = "Nouvelle abonnement";
            this.Load += new System.EventHandler(this.frmAbonnementPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClubDeGolfBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.TextBox courrielTextBox;
        private System.Windows.Forms.DateTimePicker dateAbonnementDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox noCiviqueTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.TextBox rueTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ComboBox typesAbonnementComboBox;
        private BDClubDeGolfBDataSet bDClubDeGolfBDataSet;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.TypesAbonnementTableAdapter typesAbonnementTableAdapter;
        private BDClubDeGolfBDataSetTableAdapters.ProvincesTableAdapter provincesTableAdapter;
        private System.Windows.Forms.ComboBox provincesComboBox;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.MaskedTextBox telephoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cellulaireMaskedTextBox;
    }
}