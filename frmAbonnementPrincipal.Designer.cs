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
            this.abonnementsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.abonnementsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cellulaireTextBox = new System.Windows.Forms.TextBox();
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
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.cmbAbonnement = new System.Windows.Forms.ComboBox();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingNavigator)).BeginInit();
            this.abonnementsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Location = new System.Drawing.Point(20, 297);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(56, 13);
            cellulaireLabel.TabIndex = 1;
            cellulaireLabel.Text = "*Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(20, 337);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 3;
            codePostalLabel.Text = "Code Postal:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Location = new System.Drawing.Point(20, 374);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(45, 13);
            courrielLabel.TabIndex = 5;
            courrielLabel.Text = "Courriel:";
            // 
            // dateAbonnementLabel
            // 
            dateAbonnementLabel.AutoSize = true;
            dateAbonnementLabel.Location = new System.Drawing.Point(383, 301);
            dateAbonnementLabel.Name = "dateAbonnementLabel";
            dateAbonnementLabel.Size = new System.Drawing.Size(96, 13);
            dateAbonnementLabel.TabIndex = 7;
            dateAbonnementLabel.Text = "Date Abonnement:";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Location = new System.Drawing.Point(20, 224);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(99, 13);
            dateNaissanceLabel.TabIndex = 9;
            dateNaissanceLabel.Text = "Date de naissance:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(20, 105);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Location = new System.Drawing.Point(20, 410);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(52, 13);
            idProvinceLabel.TabIndex = 13;
            idProvinceLabel.Text = "Province:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Location = new System.Drawing.Point(20, 447);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(62, 13);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "No Civique:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(20, 165);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 17;
            nomLabel.Text = "Nom:";
            // 
            // noTypeAbonnementLabel
            // 
            noTypeAbonnementLabel.AutoSize = true;
            noTypeAbonnementLabel.Location = new System.Drawing.Point(383, 101);
            noTypeAbonnementLabel.Name = "noTypeAbonnementLabel";
            noTypeAbonnementLabel.Size = new System.Drawing.Size(115, 13);
            noTypeAbonnementLabel.TabIndex = 19;
            noTypeAbonnementLabel.Text = "Type de l\'abonnement:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(20, 134);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 21;
            prenomLabel.Text = "Prénom:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(383, 370);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(63, 13);
            remarqueLabel.TabIndex = 23;
            remarqueLabel.Text = "*Remarque:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(383, 165);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(30, 13);
            rueLabel.TabIndex = 25;
            rueLabel.Text = "Rue:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(20, 192);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 27;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(20, 257);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 29;
            telephoneLabel.Text = "Télephone:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(383, 225);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 31;
            villeLabel.Text = "Ville:";
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(Projet3.Abonnements);
            // 
            // abonnementsBindingNavigator
            // 
            this.abonnementsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.abonnementsBindingNavigator.BindingSource = this.abonnementsBindingSource;
            this.abonnementsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.abonnementsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.abonnementsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.abonnementsBindingNavigatorSaveItem});
            this.abonnementsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.abonnementsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.abonnementsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.abonnementsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.abonnementsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.abonnementsBindingNavigator.Name = "abonnementsBindingNavigator";
            this.abonnementsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.abonnementsBindingNavigator.Size = new System.Drawing.Size(850, 25);
            this.abonnementsBindingNavigator.TabIndex = 0;
            this.abonnementsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // abonnementsBindingNavigatorSaveItem
            // 
            this.abonnementsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abonnementsBindingNavigatorSaveItem.Enabled = false;
            this.abonnementsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("abonnementsBindingNavigatorSaveItem.Image")));
            this.abonnementsBindingNavigatorSaveItem.Name = "abonnementsBindingNavigatorSaveItem";
            this.abonnementsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.abonnementsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // cellulaireTextBox
            // 
            this.cellulaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Cellulaire", true));
            this.cellulaireTextBox.Location = new System.Drawing.Point(140, 297);
            this.cellulaireTextBox.Name = "cellulaireTextBox";
            this.cellulaireTextBox.Size = new System.Drawing.Size(200, 20);
            this.cellulaireTextBox.TabIndex = 2;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "CodePostal", true));
            this.codePostalTextBox.Location = new System.Drawing.Point(140, 334);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(200, 20);
            this.codePostalTextBox.TabIndex = 4;
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Courriel", true));
            this.courrielTextBox.Location = new System.Drawing.Point(140, 371);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(200, 20);
            this.courrielTextBox.TabIndex = 6;
            // 
            // dateAbonnementDateTimePicker
            // 
            this.dateAbonnementDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementsBindingSource, "DateAbonnement", true));
            this.dateAbonnementDateTimePicker.Location = new System.Drawing.Point(503, 297);
            this.dateAbonnementDateTimePicker.Name = "dateAbonnementDateTimePicker";
            this.dateAbonnementDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateAbonnementDateTimePicker.TabIndex = 8;
            // 
            // dateNaissanceDateTimePicker
            // 
            this.dateNaissanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.abonnementsBindingSource, "DateNaissance", true));
            this.dateNaissanceDateTimePicker.Location = new System.Drawing.Point(140, 220);
            this.dateNaissanceDateTimePicker.Name = "dateNaissanceDateTimePicker";
            this.dateNaissanceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateNaissanceDateTimePicker.TabIndex = 10;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(140, 102);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "NoCivique", true));
            this.noCiviqueTextBox.Location = new System.Drawing.Point(140, 444);
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.noCiviqueTextBox.TabIndex = 16;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(140, 162);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomTextBox.TabIndex = 18;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(140, 131);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenomTextBox.TabIndex = 22;
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(503, 367);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.remarqueTextBox.TabIndex = 24;
            // 
            // rueTextBox
            // 
            this.rueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Rue", true));
            this.rueTextBox.Location = new System.Drawing.Point(503, 162);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(200, 20);
            this.rueTextBox.TabIndex = 26;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(140, 256);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.telephoneTextBox.TabIndex = 30;
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.abonnementsBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(503, 222);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(200, 20);
            this.villeTextBox.TabIndex = 32;
            // 
            // cmbAbonnement
            // 
            this.cmbAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.cmbAbonnement.DisplayMember = "Description";
            this.cmbAbonnement.FormattingEnabled = true;
            this.cmbAbonnement.Location = new System.Drawing.Point(503, 97);
            this.cmbAbonnement.Name = "cmbAbonnement";
            this.cmbAbonnement.Size = new System.Drawing.Size(200, 21);
            this.cmbAbonnement.TabIndex = 33;
            this.cmbAbonnement.ValueMember = "No";
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(Projet3.TypesAbonnement);
            // 
            // cmbProvince
            // 
            this.cmbProvince.DataSource = this.provincesBindingSource;
            this.cmbProvince.DisplayMember = "Nom";
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(140, 408);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(200, 21);
            this.cmbProvince.TabIndex = 34;
            this.cmbProvince.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(Projet3.Provinces);
            // 
            // cmbSexe
            // 
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "H",
            "F"});
            this.cmbSexe.Location = new System.Drawing.Point(140, 188);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(200, 21);
            this.cmbSexe.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(297, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "* signifie que l\'information est facultatif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 43);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nouvelle Abonnement";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.BackgroundImage")));
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnuler.Location = new System.Drawing.Point(623, 408);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(78, 74);
            this.btnAnnuler.TabIndex = 55;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjout.BackgroundImage")));
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjout.Location = new System.Drawing.Point(503, 408);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(78, 74);
            this.btnAjout.TabIndex = 54;
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // frmAbonnementPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSexe);
            this.Controls.Add(this.cmbProvince);
            this.Controls.Add(this.cmbAbonnement);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(this.cellulaireTextBox);
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
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.villeTextBox);
            this.Controls.Add(this.abonnementsBindingNavigator);
            this.Name = "frmAbonnementPrincipal";
            this.Text = "Nouvelle abonnement";
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingNavigator)).EndInit();
            this.abonnementsBindingNavigator.ResumeLayout(false);
            this.abonnementsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.BindingNavigator abonnementsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton abonnementsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cellulaireTextBox;
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
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.ComboBox cmbAbonnement;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjout;
    }
}