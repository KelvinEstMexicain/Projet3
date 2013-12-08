namespace Projet3
{
    partial class frmRapports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RapportDEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDClubDeGolfBDataSet = new Projet3.BDClubDeGolfBDataSet();
            this.RapportDepenseAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RapportAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RapportPartieJoueeTerrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RapportPartieJoueesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PartieJoueeParAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDepenseEmploye = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RapportDETableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.RapportDETableAdapter();
            this.RapportDepenseAbonnementTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.RapportDepenseAbonnementTableAdapter();
            this.RapportAnneeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.RapportAnneeTableAdapter();
            this.RapportPartieJoueeTerrainTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.RapportPartieJoueeTerrainTableAdapter();
            this.RapportPartieJoueesAbonnementTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.RapportPartieJoueesAbonnementTableAdapter();
            this.PartieJoueeParAnneeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.PartieJoueeParAnneeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RapportDEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapportDepenseAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapportAnneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapportPartieJoueeTerrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapportPartieJoueesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartieJoueeParAnneeBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDepenseEmploye.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // RapportDEBindingSource
            // 
            this.RapportDEBindingSource.DataMember = "RapportDE";
            this.RapportDEBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // BDClubDeGolfBDataSet
            // 
            this.BDClubDeGolfBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RapportDepenseAbonnementBindingSource
            // 
            this.RapportDepenseAbonnementBindingSource.DataMember = "RapportDepenseAbonnement";
            this.RapportDepenseAbonnementBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // RapportAnneeBindingSource
            // 
            this.RapportAnneeBindingSource.DataMember = "RapportAnnee";
            this.RapportAnneeBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // RapportPartieJoueeTerrainBindingSource
            // 
            this.RapportPartieJoueeTerrainBindingSource.DataMember = "RapportPartieJoueeTerrain";
            this.RapportPartieJoueeTerrainBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // RapportPartieJoueesAbonnementBindingSource
            // 
            this.RapportPartieJoueesAbonnementBindingSource.DataMember = "RapportPartieJoueesAbonnement";
            this.RapportPartieJoueesAbonnementBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // PartieJoueeParAnneeBindingSource
            // 
            this.PartieJoueeParAnneeBindingSource.DataMember = "PartieJoueeParAnnee";
            this.PartieJoueeParAnneeBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDepenseEmploye);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 51);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 413);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabDepenseEmploye
            // 
            this.tabDepenseEmploye.Controls.Add(this.reportViewer1);
            this.tabDepenseEmploye.Location = new System.Drawing.Point(4, 40);
            this.tabDepenseEmploye.Name = "tabDepenseEmploye";
            this.tabDepenseEmploye.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepenseEmploye.Size = new System.Drawing.Size(795, 369);
            this.tabDepenseEmploye.TabIndex = 0;
            this.tabDepenseEmploye.Text = "Dépenses par employé";
            this.tabDepenseEmploye.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.RapportDEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projet3.rapportDepensesEmploye.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(792, 387);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dépenses par abonnement";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.RapportDepenseAbonnementBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Projet3.raportDepenseAbonnement.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(795, 383);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 369);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Dépense par année";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            reportDataSource9.Name = "DataSet1";
            reportDataSource9.Value = this.RapportAnneeBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Projet3.rapportDepenseAnnee.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 4);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(795, 387);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 369);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Rapport des parties jouées par terrain";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource10.Name = "DataSet1";
            reportDataSource10.Value = this.RapportPartieJoueeTerrainBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Projet3.rapportPartieJoueeTerrain1.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 4);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(795, 387);
            this.reportViewer4.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer5);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(795, 369);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Rapport des parties jouées par abonnement";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            reportDataSource11.Name = "DataSet1";
            reportDataSource11.Value = this.RapportPartieJoueesAbonnementBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Projet3.rapportPartieJoueeAbonnement.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 4);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(795, 391);
            this.reportViewer5.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer6);
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(795, 369);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Rapport des parties jouées par année";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            reportDataSource12.Name = "DataSet1";
            reportDataSource12.Value = this.PartieJoueeParAnneeBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "Projet3.rapportPartieJoueeAnnee.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(0, 4);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.Size = new System.Drawing.Size(795, 387);
            this.reportViewer6.TabIndex = 0;
            // 
            // RapportDETableAdapter
            // 
            this.RapportDETableAdapter.ClearBeforeFill = true;
            // 
            // RapportDepenseAbonnementTableAdapter
            // 
            this.RapportDepenseAbonnementTableAdapter.ClearBeforeFill = true;
            // 
            // RapportAnneeTableAdapter
            // 
            this.RapportAnneeTableAdapter.ClearBeforeFill = true;
            // 
            // RapportPartieJoueeTerrainTableAdapter
            // 
            this.RapportPartieJoueeTerrainTableAdapter.ClearBeforeFill = true;
            // 
            // RapportPartieJoueesAbonnementTableAdapter
            // 
            this.RapportPartieJoueesAbonnementTableAdapter.ClearBeforeFill = true;
            // 
            // PartieJoueeParAnneeTableAdapter
            // 
            this.PartieJoueeParAnneeTableAdapter.ClearBeforeFill = true;
            // 
            // frmRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRapports";
            this.Text = "Rapport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRapports_FormClosing);
            this.Load += new System.EventHandler(this.frmRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RapportDEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapportDepenseAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapportAnneeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapportPartieJoueeTerrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapportPartieJoueesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartieJoueeParAnneeBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDepenseEmploye.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDepenseEmploye;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RapportDEBindingSource;
        private BDClubDeGolfBDataSet BDClubDeGolfBDataSet;
        private BDClubDeGolfBDataSetTableAdapters.RapportDETableAdapter RapportDETableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.BindingSource RapportDepenseAbonnementBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.RapportDepenseAbonnementTableAdapter RapportDepenseAbonnementTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource RapportAnneeBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.RapportAnneeTableAdapter RapportAnneeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource RapportPartieJoueeTerrainBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.RapportPartieJoueeTerrainTableAdapter RapportPartieJoueeTerrainTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource RapportPartieJoueesAbonnementBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.RapportPartieJoueesAbonnementTableAdapter RapportPartieJoueesAbonnementTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.BindingSource PartieJoueeParAnneeBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.PartieJoueeParAnneeTableAdapter PartieJoueeParAnneeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}