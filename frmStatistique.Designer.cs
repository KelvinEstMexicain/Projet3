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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.StatsAbonnementAnneeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDClubDeGolfBDataSet = new Projet3.BDClubDeGolfBDataSet();
            this.statsAbonnementMoisAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReabonnementAnneeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statsReabonnementMoisAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDClubDeGolfBDataSet1 = new Projet3.BDClubDeGolfBDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.StatsAbonnementAnneeTypeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.StatsAbonnementAnneeTypeTableAdapter();
            this.statsAbonnementMoisAnneeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.statsAbonnementMoisAnneeTableAdapter();
            this.ReabonnementAnneeTypeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.ReabonnementAnneeTypeTableAdapter();
            this.statsReabonnementMoisAnneeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.statsReabonnementMoisAnneeTableAdapter();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.statsPartieJoueeAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statsPartieJoueeAnneeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.statsPartieJoueeAnneeTableAdapter();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.statsPartieJoueeMoisAnneeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statsPartieJoueeMoisAnneeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.statsPartieJoueeMoisAnneeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StatsAbonnementAnneeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsAbonnementMoisAnneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReabonnementAnneeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsReabonnementMoisAnneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClubDeGolfBDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsPartieJoueeAnneeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsPartieJoueeMoisAnneeBindingSource)).BeginInit();
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
            // ReabonnementAnneeTypeBindingSource
            // 
            this.ReabonnementAnneeTypeBindingSource.DataMember = "ReabonnementAnneeType";
            this.ReabonnementAnneeTypeBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // statsReabonnementMoisAnneeBindingSource
            // 
            this.statsReabonnementMoisAnneeBindingSource.DataMember = "statsReabonnementMoisAnnee";
            this.statsReabonnementMoisAnneeBindingSource.DataSource = this.bDClubDeGolfBDataSet1;
            // 
            // bDClubDeGolfBDataSet1
            // 
            this.bDClubDeGolfBDataSet1.DataSetName = "BDClubDeGolfBDataSet";
            this.bDClubDeGolfBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
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
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StatsAbonnementAnneeTypeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
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
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.statsAbonnementMoisAnneeBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
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
            // reportViewer3
            // 
            this.reportViewer3.BackColor = System.Drawing.SystemColors.Window;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.ReabonnementAnneeTypeBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Projet3.statsReabonnementAnneeType.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(4, 4);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(866, 426);
            this.reportViewer3.TabIndex = 0;
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
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.statsReabonnementMoisAnneeBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Projet3.rapportStatsReabonnementMoisAnnee.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(7, 7);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(866, 420);
            this.reportViewer4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(873, 430);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Parties jouées par année et par terrain";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(873, 430);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Partie jouées par mois de l\'année courant et par terrain";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // StatsAbonnementAnneeTypeTableAdapter
            // 
            this.StatsAbonnementAnneeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // statsAbonnementMoisAnneeTableAdapter
            // 
            this.statsAbonnementMoisAnneeTableAdapter.ClearBeforeFill = true;
            // 
            // ReabonnementAnneeTypeTableAdapter
            // 
            this.ReabonnementAnneeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // statsReabonnementMoisAnneeTableAdapter
            // 
            this.statsReabonnementMoisAnneeTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer5
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.statsPartieJoueeAnneeBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Projet3.statsPartieJoueeAnneeTerrain.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(7, 7);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.Size = new System.Drawing.Size(863, 417);
            this.reportViewer5.TabIndex = 0;
            // 
            // statsPartieJoueeAnneeBindingSource
            // 
            this.statsPartieJoueeAnneeBindingSource.DataMember = "statsPartieJoueeAnnee";
            this.statsPartieJoueeAnneeBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // statsPartieJoueeAnneeTableAdapter
            // 
            this.statsPartieJoueeAnneeTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer6
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.statsPartieJoueeMoisAnneeBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "Projet3.statsPartieJoueeMoisAnnee.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(7, 7);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.Size = new System.Drawing.Size(860, 417);
            this.reportViewer6.TabIndex = 0;
            // 
            // statsPartieJoueeMoisAnneeBindingSource
            // 
            this.statsPartieJoueeMoisAnneeBindingSource.DataMember = "statsPartieJoueeMoisAnnee";
            this.statsPartieJoueeMoisAnneeBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // statsPartieJoueeMoisAnneeTableAdapter
            // 
            this.statsPartieJoueeMoisAnneeTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.ReabonnementAnneeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsReabonnementMoisAnneeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClubDeGolfBDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statsPartieJoueeAnneeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsPartieJoueeMoisAnneeBindingSource)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource statsPartieJoueeAnneeBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.statsPartieJoueeAnneeTableAdapter statsPartieJoueeAnneeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.BindingSource statsPartieJoueeMoisAnneeBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.statsPartieJoueeMoisAnneeTableAdapter statsPartieJoueeMoisAnneeTableAdapter;
    }
}