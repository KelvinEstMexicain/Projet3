namespace Projet3
{
    partial class frmAjoutEnfant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutEnfant));
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idAbonnementLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label sexeLabel;
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dependantsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.dateNaissanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idAbonnementTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            idAbonnementLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingNavigator)).BeginInit();
            this.dependantsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dependantsBindingSource
            // 
            this.dependantsBindingSource.DataSource = typeof(Projet3.Dependants);
            // 
            // dependantsBindingNavigator
            // 
            this.dependantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dependantsBindingNavigator.BindingSource = this.dependantsBindingSource;
            this.dependantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dependantsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dependantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dependantsBindingNavigatorSaveItem});
            this.dependantsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dependantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dependantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dependantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dependantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dependantsBindingNavigator.Name = "dependantsBindingNavigator";
            this.dependantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dependantsBindingNavigator.Size = new System.Drawing.Size(427, 25);
            this.dependantsBindingNavigator.TabIndex = 0;
            this.dependantsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // dependantsBindingNavigatorSaveItem
            // 
            this.dependantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dependantsBindingNavigatorSaveItem.Enabled = false;
            this.dependantsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dependantsBindingNavigatorSaveItem.Image")));
            this.dependantsBindingNavigatorSaveItem.Name = "dependantsBindingNavigatorSaveItem";
            this.dependantsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dependantsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.BackgroundImage")));
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnuler.Location = new System.Drawing.Point(339, 238);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 75);
            this.btnAnnuler.TabIndex = 73;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjout.BackgroundImage")));
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjout.Location = new System.Drawing.Point(219, 238);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(81, 75);
            this.btnAjout.TabIndex = 72;
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // cmbSexe
            // 
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "H",
            "F"});
            this.cmbSexe.Location = new System.Drawing.Point(113, 148);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(56, 21);
            this.cmbSexe.TabIndex = 71;
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Location = new System.Drawing.Point(21, 179);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(86, 13);
            dateNaissanceLabel.TabIndex = 58;
            dateNaissanceLabel.Text = "Date Naissance:";
            // 
            // dateNaissanceDateTimePicker
            // 
            this.dateNaissanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dependantsBindingSource, "DateNaissance", true));
            this.dateNaissanceDateTimePicker.Location = new System.Drawing.Point(113, 175);
            this.dateNaissanceDateTimePicker.Name = "dateNaissanceDateTimePicker";
            this.dateNaissanceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateNaissanceDateTimePicker.TabIndex = 59;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Enabled = false;
            idLabel.Location = new System.Drawing.Point(31, 240);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 60;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(123, 240);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(56, 20);
            this.idTextBox.TabIndex = 61;
            // 
            // idAbonnementLabel
            // 
            idAbonnementLabel.AutoSize = true;
            idAbonnementLabel.Enabled = false;
            idAbonnementLabel.Location = new System.Drawing.Point(31, 269);
            idAbonnementLabel.Name = "idAbonnementLabel";
            idAbonnementLabel.Size = new System.Drawing.Size(82, 13);
            idAbonnementLabel.TabIndex = 62;
            idAbonnementLabel.Text = "Id Abonnement:";
            // 
            // idAbonnementTextBox
            // 
            this.idAbonnementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "IdAbonnement", true));
            this.idAbonnementTextBox.Enabled = false;
            this.idAbonnementTextBox.Location = new System.Drawing.Point(123, 266);
            this.idAbonnementTextBox.Name = "idAbonnementTextBox";
            this.idAbonnementTextBox.Size = new System.Drawing.Size(56, 20);
            this.idAbonnementTextBox.TabIndex = 63;
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(21, 126);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 64;
            nomLabel.Text = "Nom:";
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(113, 123);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(160, 20);
            this.nomTextBox.TabIndex = 65;
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(21, 103);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 66;
            prenomLabel.Text = "Prenom:";
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(113, 100);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(160, 20);
            this.prenomTextBox.TabIndex = 67;
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(21, 204);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(63, 13);
            remarqueLabel.TabIndex = 68;
            remarqueLabel.Text = "*Remarque:";
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(113, 201);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.remarqueTextBox.TabIndex = 69;
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(21, 151);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 70;
            sexeLabel.Text = "Sexe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(124, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "* signifie que l\'information est facultatif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 43);
            this.label1.TabIndex = 74;
            this.label1.Text = "Abonnement d\'un enfant";
            // 
            // frmAjoutEnfant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.cmbSexe);
            this.Controls.Add(dateNaissanceLabel);
            this.Controls.Add(this.dateNaissanceDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idAbonnementLabel);
            this.Controls.Add(this.idAbonnementTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(this.dependantsBindingNavigator);
            this.Name = "frmAjoutEnfant";
            this.Text = "Ajout d\'un enfant";
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingNavigator)).EndInit();
            this.dependantsBindingNavigator.ResumeLayout(false);
            this.dependantsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dependantsBindingSource;
        private System.Windows.Forms.BindingNavigator dependantsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dependantsBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox idAbonnementTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}