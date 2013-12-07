using System;
namespace Projet3
{
    partial class frmAjoutDependant
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
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idAbonnementLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label sexeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutDependant));
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateNaissanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idAbonnementTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            dateNaissanceLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            idAbonnementLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Location = new System.Drawing.Point(30, 165);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(86, 13);
            dateNaissanceLabel.TabIndex = 1;
            dateNaissanceLabel.Text = "Date Naissance:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Enabled = false;
            idLabel.Location = new System.Drawing.Point(40, 288);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // idAbonnementLabel
            // 
            idAbonnementLabel.AutoSize = true;
            idAbonnementLabel.Enabled = false;
            idAbonnementLabel.Location = new System.Drawing.Point(40, 260);
            idAbonnementLabel.Name = "idAbonnementLabel";
            idAbonnementLabel.Size = new System.Drawing.Size(82, 13);
            idAbonnementLabel.TabIndex = 5;
            idAbonnementLabel.Text = "Id Abonnement:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(30, 112);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 7;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(30, 89);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 9;
            prenomLabel.Text = "Prenom:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(30, 190);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(59, 13);
            remarqueLabel.TabIndex = 11;
            remarqueLabel.Text = "Remarque:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Location = new System.Drawing.Point(30, 137);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(34, 13);
            sexeLabel.TabIndex = 13;
            sexeLabel.Text = "Sexe:";
            // 
            // dependantsBindingSource
            // 
            this.dependantsBindingSource.DataSource = typeof(Projet3.Dependants);
            // 
            // dateNaissanceDateTimePicker
            // 
            this.dateNaissanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dependantsBindingSource, "DateNaissance", true));
            this.dateNaissanceDateTimePicker.Location = new System.Drawing.Point(122, 161);
            this.dateNaissanceDateTimePicker.MaxDate = new System.DateTime(2013, 12, 7, 12, 34, 32, 852);
            this.dateNaissanceDateTimePicker.Name = "dateNaissanceDateTimePicker";
            this.dateNaissanceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateNaissanceDateTimePicker.TabIndex = 3;
            this.dateNaissanceDateTimePicker.Value = new System.DateTime(2013, 12, 7, 12, 34, 32, 852);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(132, 285);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(150, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // idAbonnementTextBox
            // 
            this.idAbonnementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "IdAbonnement", true));
            this.idAbonnementTextBox.Enabled = false;
            this.idAbonnementTextBox.Location = new System.Drawing.Point(132, 257);
            this.idAbonnementTextBox.Name = "idAbonnementTextBox";
            this.idAbonnementTextBox.Size = new System.Drawing.Size(150, 20);
            this.idAbonnementTextBox.TabIndex = 6;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(122, 109);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(160, 20);
            this.nomTextBox.TabIndex = 1;
            this.nomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nomTextBox_Validating);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(122, 86);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(160, 20);
            this.prenomTextBox.TabIndex = 0;
            this.prenomTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.prenomTextBox_Validating);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dependantsBindingSource, "Remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(122, 187);
            this.remarqueTextBox.Multiline = true;
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(200, 58);
            this.remarqueTextBox.TabIndex = 4;
            this.remarqueTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.remarqueTextBox_Validating);
            // 
            // cmbSexe
            // 
            this.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "H",
            "F"});
            this.cmbSexe.Location = new System.Drawing.Point(122, 134);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(56, 21);
            this.cmbSexe.TabIndex = 2;
            this.cmbSexe.SelectedIndexChanged += new System.EventHandler(this.cmbSexe_SelectedIndexChanged);
            this.cmbSexe.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSexe_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(129, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "* signifie que l\'information est facultatif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 43);
            this.label1.TabIndex = 54;
            this.label1.Text = "Abonnement du conjoint(e)";
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjout.BackgroundImage")));
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjout.Location = new System.Drawing.Point(347, 257);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(78, 74);
            this.btnAjout.TabIndex = 5;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // frmAjoutDependant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(454, 358);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Name = "frmAjoutDependant";
            this.Text = "Ajout d\'un conjoint(e)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAjoutDependant_FormClosing);
            this.Load += new System.EventHandler(this.frmAjoutDependant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dependantsBindingSource;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox idAbonnementTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}