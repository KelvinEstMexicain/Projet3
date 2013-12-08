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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BDClubDeGolfBDataSet = new Projet3.BDClubDeGolfBDataSet();
            this.StatsAbonnementAnneeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatsAbonnementAnneeTypeTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.StatsAbonnementAnneeTypeTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatsAbonnementAnneeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // BDClubDeGolfBDataSet
            // 
            this.BDClubDeGolfBDataSet.DataSetName = "BDClubDeGolfBDataSet";
            this.BDClubDeGolfBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StatsAbonnementAnneeTypeBindingSource
            // 
            this.StatsAbonnementAnneeTypeBindingSource.DataMember = "StatsAbonnementAnneeType";
            this.StatsAbonnementAnneeTypeBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // StatsAbonnementAnneeTypeTableAdapter
            // 
            this.StatsAbonnementAnneeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // frmStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmStatistique";
            this.Text = "Statistique";
            this.Load += new System.EventHandler(this.frmStatistique_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatsAbonnementAnneeTypeBindingSource)).EndInit();
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
    }
}