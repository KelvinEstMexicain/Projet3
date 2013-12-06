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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RapportDEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDClubDeGolfBDataSet = new Projet3.BDClubDeGolfBDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDepenseEmploye = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.RapportDETableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.RapportDETableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RapportDepenseAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RapportDepenseAbonnementTableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.RapportDepenseAbonnementTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RapportDEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDepenseEmploye.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RapportDepenseAbonnementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RapportDEBindingSource
            // 
            this.RapportDEBindingSource.DataMember = "RapportDE";
            this.RapportDEBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // BDClubDeGolfBDataSet
            // 
            this.BDClubDeGolfBDataSet.DataSetName = "BDClubDeGolfBDataSet";
            this.BDClubDeGolfBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDepenseEmploye
            // 
            this.tabDepenseEmploye.Controls.Add(this.reportViewer1);
            this.tabDepenseEmploye.Location = new System.Drawing.Point(4, 22);
            this.tabDepenseEmploye.Name = "tabDepenseEmploye";
            this.tabDepenseEmploye.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepenseEmploye.Size = new System.Drawing.Size(795, 387);
            this.tabDepenseEmploye.TabIndex = 0;
            this.tabDepenseEmploye.Text = "Dépenses par employé";
            this.tabDepenseEmploye.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RapportDEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projet3.rapportDepensesEmploye.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(7, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(792, 387);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dépenses par année";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 387);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Dépense par abonnement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 387);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Rapport des parties jouées par terrain";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(795, 387);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Rapport des parties jouées par abonnement";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(795, 387);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Rapport des parties jouées par année";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // RapportDETableAdapter
            // 
            this.RapportDETableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.RapportDepenseAbonnementBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Projet3.rapportDepenseAbonnement.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(792, 383);
            this.reportViewer2.TabIndex = 0;
            // 
            // RapportDepenseAbonnementBindingSource
            // 
            this.RapportDepenseAbonnementBindingSource.DataMember = "RapportDepenseAbonnement";
            this.RapportDepenseAbonnementBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // RapportDepenseAbonnementTableAdapter
            // 
            this.RapportDepenseAbonnementTableAdapter.ClearBeforeFill = true;
            // 
            // frmRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRapports";
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.frmRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RapportDEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDepenseEmploye.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RapportDepenseAbonnementBindingSource)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource RapportDepenseAbonnementBindingSource;
        private BDClubDeGolfBDataSetTableAdapters.RapportDepenseAbonnementTableAdapter RapportDepenseAbonnementTableAdapter;
    }
}