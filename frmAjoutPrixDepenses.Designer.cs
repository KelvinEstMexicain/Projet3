﻿namespace Projet3
{
    partial class frmAjoutPrixDepenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutPrixDepenses));
            this.prixDepensesAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prixDepensesAbonnementsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prixDepensesAbonnementsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prixDepensesAbonnementsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingNavigator)).BeginInit();
            this.prixDepensesAbonnementsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prixDepensesAbonnementsBindingSource
            // 
            this.prixDepensesAbonnementsBindingSource.DataSource = typeof(Projet3.PrixDepensesAbonnements);
            // 
            // prixDepensesAbonnementsBindingNavigator
            // 
            this.prixDepensesAbonnementsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prixDepensesAbonnementsBindingNavigator.BindingSource = this.prixDepensesAbonnementsBindingSource;
            this.prixDepensesAbonnementsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prixDepensesAbonnementsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prixDepensesAbonnementsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prixDepensesAbonnementsBindingNavigatorSaveItem});
            this.prixDepensesAbonnementsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prixDepensesAbonnementsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prixDepensesAbonnementsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prixDepensesAbonnementsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prixDepensesAbonnementsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prixDepensesAbonnementsBindingNavigator.Name = "prixDepensesAbonnementsBindingNavigator";
            this.prixDepensesAbonnementsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prixDepensesAbonnementsBindingNavigator.Size = new System.Drawing.Size(601, 25);
            this.prixDepensesAbonnementsBindingNavigator.TabIndex = 0;
            this.prixDepensesAbonnementsBindingNavigator.Text = "bindingNavigator1";
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
            // prixDepensesAbonnementsBindingNavigatorSaveItem
            // 
            this.prixDepensesAbonnementsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prixDepensesAbonnementsBindingNavigatorSaveItem.Enabled = false;
            this.prixDepensesAbonnementsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prixDepensesAbonnementsBindingNavigatorSaveItem.Image")));
            this.prixDepensesAbonnementsBindingNavigatorSaveItem.Name = "prixDepensesAbonnementsBindingNavigatorSaveItem";
            this.prixDepensesAbonnementsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prixDepensesAbonnementsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // prixDepensesAbonnementsDataGridView
            // 
            this.prixDepensesAbonnementsDataGridView.AllowUserToDeleteRows = false;
            this.prixDepensesAbonnementsDataGridView.AllowUserToResizeRows = false;
            this.prixDepensesAbonnementsDataGridView.AutoGenerateColumns = false;
            this.prixDepensesAbonnementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prixDepensesAbonnementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.prixDepensesAbonnementsDataGridView.DataSource = this.prixDepensesAbonnementsBindingSource;
            this.prixDepensesAbonnementsDataGridView.Location = new System.Drawing.Point(12, 92);
            this.prixDepensesAbonnementsDataGridView.Name = "prixDepensesAbonnementsDataGridView";
            this.prixDepensesAbonnementsDataGridView.Size = new System.Drawing.Size(548, 301);
            this.prixDepensesAbonnementsDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 43);
            this.label1.TabIndex = 89;
            this.label1.Text = "Ajout d\'un prix et des dépenses obligatoires";
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjout.BackgroundImage")));
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjout.Location = new System.Drawing.Point(482, 399);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(78, 74);
            this.btnAjout.TabIndex = 91;
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(Projet3.TypesAbonnement);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoTypeAbonnement";
            this.dataGridViewTextBoxColumn1.DataSource = this.prixDepensesAbonnementsBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "NoTypeAbonnement";
            this.dataGridViewTextBoxColumn1.HeaderText = "NoTypeAbonnement";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "NoTypeAbonnement";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Annee";
            this.dataGridViewTextBoxColumn2.HeaderText = "Annee";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prix";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DepensesObligatoires";
            this.dataGridViewTextBoxColumn4.HeaderText = "DepensesObligatoires";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn5.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmAjoutPrixDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 484);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prixDepensesAbonnementsDataGridView);
            this.Controls.Add(this.prixDepensesAbonnementsBindingNavigator);
            this.Name = "frmAjoutPrixDepenses";
            this.Text = "Ajout d\'un prix et des dépenses obligatoires";
            this.Load += new System.EventHandler(this.frmAjoutPrixDepenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingNavigator)).EndInit();
            this.prixDepensesAbonnementsBindingNavigator.ResumeLayout(false);
            this.prixDepensesAbonnementsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource prixDepensesAbonnementsBindingSource;
        private System.Windows.Forms.BindingNavigator prixDepensesAbonnementsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prixDepensesAbonnementsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView prixDepensesAbonnementsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}