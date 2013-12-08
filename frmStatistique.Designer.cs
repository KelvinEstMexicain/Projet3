namespace Projet3
{
    partial class frmStatistique
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource38 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource39 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource40 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource41 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.StatsAbonnementAnneeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDClubDeGolfBDataSet = new Projet3.BDClubDeGolfBDataSet();
            this.statsAbonnementMoisAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.StatsAbonnementAnneeTypeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.StatsAbonnementAnneeTypeTableAdapter();
            this.statsAbonnementMoisAnneeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.statsAbonnementMoisAnneeTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReabonnementAnneeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReabonnementAnneeTypeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.ReabonnementAnneeTypeTableAdapter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bDClubDeGolfBDataSet1 = new Projet3.BDClubDeGolfBDataSet();
            this.statsReabonnementMoisAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statsReabonnementMoisAnneeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.statsReabonnementMoisAnneeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StatsAbonnementAnneeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsAbonnementMoisAnneeBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReabonnementAnneeTypeBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDClubDeGolfBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsReabonnementMoisAnneeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StatsAbonnementAnneeTypeBindingSource
            // 
            this.StatsAbonnementAnneeTypeBindingSource.DataMember = "StatsAbonnementAnneeType";
            this.StatsAbonnementAnneeTypeBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // BDClubDeGolfBDataSet
            // 
            this.BDClubDeGolfBDataSet.DataSetName = "BDClubDeGolfBDataSet";
            this.BDClubDeGolfBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statsAbonnementMoisAnneeBindingSource
            // 
            this.statsAbonnementMoisAnneeBindingSource.DataMember = "statsAbonnementMoisAnnee";
            this.statsAbonnementMoisAnneeBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(873, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Abonnement par année et par type d\'abonnement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource38.Name = "DataSet1";
            reportDataSource38.Value = this.StatsAbonnementAnneeTypeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource38);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projet3.statsAbonnementAnneesType.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(877, 434);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(873, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abonnement par mois de l\'année et par type d\'abonnement";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource39.Name = "DataSet1";
            reportDataSource39.Value = this.statsAbonnementMoisAnneeBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource39);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Projet3.statsAbonnementMoiAnnee.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 7);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(873, 423);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(873, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Réabonnement par année et par type d\'abonnement";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // StatsAbonnementAnneeTypeTableAdapter
            // 
            this.StatsAbonnementAnneeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // statsAbonnementMoisAnneeTableAdapter
            // 
            this.statsAbonnementMoisAnneeTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.BackColor = System.Drawing.SystemColors.Window;
            reportDataSource40.Name = "DataSet1";
            reportDataSource40.Value = this.ReabonnementAnneeTypeBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource40);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Projet3.statsReabonnementAnneeType.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(4, 4);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(866, 426);
            this.reportViewer3.TabIndex = 0;
            // 
            // ReabonnementAnneeTypeBindingSource
            // 
            this.ReabonnementAnneeTypeBindingSource.DataMember = "ReabonnementAnneeType";
            this.ReabonnementAnneeTypeBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // ReabonnementAnneeTypeTableAdapter
            // 
            this.ReabonnementAnneeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(873, 430);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Réabonnement par mois de l\'année courante et par type d\'abonnement";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            reportDataSource41.Name = "DataSet1";
            reportDataSource41.Value = this.statsReabonnementMoisAnneeBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource41);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Projet3.rapportStatsReabonnementMoisAnnee.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(7, 7);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(866, 420);
            this.reportViewer4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(873, 430);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bDClubDeGolfBDataSet1
            // 
            this.bDClubDeGolfBDataSet1.DataSetName = "BDClubDeGolfBDataSet";
            this.bDClubDeGolfBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statsReabonnementMoisAnneeBindingSource
            // 
            this.statsReabonnementMoisAnneeBindingSource.DataMember = "statsReabonnementMoisAnnee";
            this.statsReabonnementMoisAnneeBindingSource.DataSource = this.bDClubDeGolfBDataSet1;
            // 
            // statsReabonnementMoisAnneeTableAdapter
            // 
            this.statsReabonnementMoisAnneeTableAdapter.ClearBeforeFill = true;
            // 
            // frmStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmStatistique";
            this.Text = "Statistique";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStatistique_FormClosing);
            this.Load += new System.EventHandler(this.frmStatistique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatsAbonnementAnneeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsAbonnementMoisAnneeBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReabonnementAnneeTypeBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bDClubDeGolfBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsReabonnementMoisAnneeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StatsAbonnementAnneeTypeBindingSource;
        private BDClubDeGolfBDataSet BDClubDeGolfBDataSet;
        private BDClubDeGolfBDataSetTableAdapters.StatsAbonnementAnneeTypeTableAdapter StatsAbonnementAnneeTypeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource statsAbonnementMoisAnneeBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.statsAbonnementMoisAnneeTableAdapter statsAbonnementMoisAnneeTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource ReabonnementAnneeTypeBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.ReabonnementAnneeTypeTableAdapter ReabonnementAnneeTypeTableAdapter;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.TabPage tabPage5;
        private BDClubDeGolfBDataSet bDClubDeGolfBDataSet1;
        private System.Windows.Forms.BindingSource statsReabonnementMoisAnneeBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.statsReabonnementMoisAnneeTableAdapter statsReabonnementMoisAnneeTableAdapter;
    }
}