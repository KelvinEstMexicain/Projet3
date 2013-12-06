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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDepenseEmploye = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BDClubDeGolfBDataSet = new Projet3.BDClubDeGolfBDataSet();
            this.RapportDEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RapportDETableAdapter = new Projet3.BDClubDeGolfBDataSetTableAdapters.RapportDETableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabDepenseEmploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapportDEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDepenseEmploye);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // BDClubDeGolfBDataSet
            // 
            this.BDClubDeGolfBDataSet.DataSetName = "BDClubDeGolfBDataSet";
            this.BDClubDeGolfBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RapportDEBindingSource
            // 
            this.RapportDEBindingSource.DataMember = "RapportDE";
            this.RapportDEBindingSource.DataSource = this.BDClubDeGolfBDataSet;
            // 
            // RapportDETableAdapter
            // 
            this.RapportDETableAdapter.ClearBeforeFill = true;
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
            this.tabControl1.ResumeLayout(false);
            this.tabDepenseEmploye.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BDClubDeGolfBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RapportDEBindingSource)).EndInit();
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
    }
}