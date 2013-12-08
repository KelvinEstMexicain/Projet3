using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Projet3
{
    public partial class frmRapports : Form
    {
        public frmRapports()
        {
            InitializeComponent();
        }

        private void frmRapports_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.PartieJoueeParAnnee'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.PartieJoueeParAnneeTableAdapter.Fill(this.BDClubDeGolfBDataSet.PartieJoueeParAnnee);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.RapportPartieJoueesAbonnement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.RapportPartieJoueesAbonnementTableAdapter.Fill(this.BDClubDeGolfBDataSet.RapportPartieJoueesAbonnement);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.RapportPartieJoueeTerrain'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.RapportPartieJoueeTerrainTableAdapter.Fill(this.BDClubDeGolfBDataSet.RapportPartieJoueeTerrain);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.RapportAnnee'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.RapportAnneeTableAdapter.Fill(this.BDClubDeGolfBDataSet.RapportAnnee);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.RapportDepenseAbonnement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.RapportDepenseAbonnementTableAdapter.Fill(this.BDClubDeGolfBDataSet.RapportDepenseAbonnement);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.RapportDE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.RapportDETableAdapter.Fill(this.BDClubDeGolfBDataSet.RapportDE);

            tabControl1.Enabled = false;
            this.reportViewer1.RefreshReport();
            tabControl1.Enabled = true;
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
            //this.reportViewer4.RefreshReport();
            //this.reportViewer5.RefreshReport();
            //this.reportViewer6.RefreshReport();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabcontrol = (TabControl)sender;
            int selectedIndex = tabcontrol.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    tabcontrol.Enabled = false;
                    this.reportViewer1.RefreshReport();
                    tabcontrol.Enabled = true;
                    break;
                case 1:
                    tabcontrol.Enabled = false;
                    this.reportViewer2.RefreshReport();
                    tabcontrol.Enabled = true;
                    break;
                case 2:
                    tabcontrol.Enabled = false;
                    this.reportViewer3.RefreshReport();
                    tabcontrol.Enabled = true;
                    break;
                case 3:
                    tabcontrol.Enabled = false;
                    this.reportViewer4.RefreshReport();
                    tabcontrol.Enabled = true;
                    break;
                case 4:
                    tabcontrol.Enabled = false;
                    this.reportViewer5.RefreshReport();
                    tabcontrol.Enabled = true;
                    break;
                case 5:
                    tabcontrol.Enabled = false;
                    this.reportViewer6.RefreshReport();
                    tabcontrol.Enabled = true;
                    break;
            }
        }

        private void frmRapports_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
            reportViewer2.LocalReport.ReleaseSandboxAppDomain();
            reportViewer3.LocalReport.ReleaseSandboxAppDomain();
            reportViewer4.LocalReport.ReleaseSandboxAppDomain();
            reportViewer5.LocalReport.ReleaseSandboxAppDomain();
            reportViewer6.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
