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
            this.employesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.cellulaireTextBox = new System.Windows.Forms.TextBox();
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
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTypeEmploye = new System.Windows.Forms.ComboBox();
            this.typesEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingNavigator)).BeginInit();
            this.employesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).BeginInit();
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
            noCiviqueLabel.Location = new System.Drawing.Point(508, 119);
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
            notypeEmployeLabel.Location = new System.Drawing.Point(497, 180);
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
            remarqueLabel.Location = new System.Drawing.Point(508, 285);
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
            salaireHoraireLabel.Location = new System.Drawing.Point(498, 231);
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
            // employesBindingNavigator
            // 
            this.employesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employesBindingNavigator.BindingSource = this.employesBindingSource;
            this.employesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employesBindingNavigatorSaveItem});
            this.employesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employesBindingNavigator.Name = "employesBindingNavigator";
            this.employesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employesBindingNavigator.Size = new System.Drawing.Size(780, 25);
            this.employesBindingNavigator.TabIndex = 0;
            this.employesBindingNavigator.Text = "bindingNavigator1";
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
            // employesBindingNavigatorSaveItem
            // 
            this.employesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employesBindingNavigatorSaveItem.Enabled = false;
            this.employesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employesBindingNavigatorSaveItem.Image")));
            this.employesBindingNavigatorSaveItem.Name = "employesBindingNavigatorSaveItem";
            this.employesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employesBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(112, 203);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 2;
            // 
            // cellulaireTextBox
            // 
            this.cellulaireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Cellulaire", true));
            this.cellulaireTextBox.Location = new System.Drawing.Point(112, 371);
            this.cellulaireTextBox.Name = "cellulaireTextBox";
            this.cellulaireTextBox.Size = new System.Drawing.Size(100, 20);
            this.cellulaireTextBox.TabIndex = 4;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "CodePostal", true));
            this.codePostalTextBox.Location = new System.Drawing.Point(364, 286);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(100, 20);
            this.codePostalTextBox.TabIndex = 6;
            // 
            // courrielTextBox
            // 
            this.courrielTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Courriel", true));
            this.courrielTextBox.Location = new System.Drawing.Point(112, 301);
            this.courrielTextBox.Name = "courrielTextBox";
            this.courrielTextBox.Size = new System.Drawing.Size(100, 20);
            this.courrielTextBox.TabIndex = 8;
            // 
            // motDePasseTextBox
            // 
            this.motDePasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "MotDePasse", true));
            this.motDePasseTextBox.Location = new System.Drawing.Point(112, 232);
            this.motDePasseTextBox.Name = "motDePasseTextBox";
            this.motDePasseTextBox.Size = new System.Drawing.Size(100, 20);
            this.motDePasseTextBox.TabIndex = 12;
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "No", true));
            this.noTextBox.Location = new System.Drawing.Point(112, 120);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTextBox.TabIndex = 14;
            // 
            // noCiviqueTextBox
            // 
            this.noCiviqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "NoCivique", true));
            this.noCiviqueTextBox.Location = new System.Drawing.Point(601, 116);
            this.noCiviqueTextBox.Name = "noCiviqueTextBox";
            this.noCiviqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.noCiviqueTextBox.TabIndex = 16;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(112, 177);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 18;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(112, 149);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 22;
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(601, 282);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.remarqueTextBox.TabIndex = 24;
            // 
            // rueTextBox
            // 
            this.rueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Rue", true));
            this.rueTextBox.Location = new System.Drawing.Point(364, 173);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(100, 20);
            this.rueTextBox.TabIndex = 26;
            // 
            // salaireHoraireTextBox
            // 
            this.salaireHoraireTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "SalaireHoraire", true));
            this.salaireHoraireTextBox.Location = new System.Drawing.Point(601, 228);
            this.salaireHoraireTextBox.Name = "salaireHoraireTextBox";
            this.salaireHoraireTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaireHoraireTextBox.TabIndex = 28;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(112, 334);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telephoneTextBox.TabIndex = 32;
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employesBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(364, 230);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(100, 20);
            this.villeTextBox.TabIndex = 34;
            // 
            // cmbProvince
            // 
            this.cmbProvince.DataSource = this.provincesBindingSource;
            this.cmbProvince.DisplayMember = "Nom";
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(364, 119);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(100, 21);
            this.cmbProvince.TabIndex = 47;
            this.cmbProvince.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(Projet3.Provinces);
            // 
            // cmbTypeEmploye
            // 
            this.cmbTypeEmploye.DataSource = this.typesEmployeBindingSource;
            this.cmbTypeEmploye.DisplayMember = "Description";
            this.cmbTypeEmploye.FormattingEnabled = true;
            this.cmbTypeEmploye.Location = new System.Drawing.Point(601, 180);
            this.cmbTypeEmploye.Name = "cmbTypeEmploye";
            this.cmbTypeEmploye.Size = new System.Drawing.Size(100, 21);
            this.cmbTypeEmploye.TabIndex = 48;
            this.cmbTypeEmploye.ValueMember = "No";
            // 
            // typesEmployeBindingSource
            // 
            this.typesEmployeBindingSource.DataSource = typeof(Projet3.TypesEmploye);
            // 
            // cmbSexe
            // 
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "H",
            "F"});
            this.cmbSexe.Location = new System.Drawing.Point(112, 263);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(100, 21);
            this.cmbSexe.TabIndex = 49;
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
            // 
            // frmAjoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 445);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSexe);
            this.Controls.Add(this.cmbTypeEmploye);
            this.Controls.Add(this.cmbProvince);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(this.cellulaireTextBox);
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
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.villeTextBox);
            this.Controls.Add(this.employesBindingNavigator);
            this.Name = "frmAjoutEmploye";
            this.Text = "Ajout des employés";
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingNavigator)).EndInit();
            this.employesBindingNavigator.ResumeLayout(false);
            this.employesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employesBindingSource;
        private System.Windows.Forms.BindingNavigator employesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox cellulaireTextBox;
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
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.ComboBox cmbTypeEmploye;
        private System.Windows.Forms.BindingSource typesEmployeBindingSource;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnAnnuler;
    }
}