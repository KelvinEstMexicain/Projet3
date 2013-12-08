using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet3
{
    public partial class frmStatistique : Form
    {
        public frmStatistique()
        {
            InitializeComponent();
        }

        private void frmStatistique_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.DepenseParMoisAnneeAbonnement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.DepenseParMoisAnneeAbonnementTableAdapter.Fill(this.BDClubDeGolfBDataSet.DepenseParMoisAnneeAbonnement);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.DepenseParAnneeAbonnement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.DepenseParAnneeAbonnementTableAdapter.Fill(this.BDClubDeGolfBDataSet.DepenseParAnneeAbonnement);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.statsPartieJoueeMoisAnnee'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.statsPartieJoueeMoisAnneeTableAdapter.Fill(this.BDClubDeGolfBDataSet.statsPartieJoueeMoisAnnee);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.statsPartieJoueeAnnee'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.statsPartieJoueeAnneeTableAdapter.Fill(this.BDClubDeGolfBDataSet.statsPartieJoueeAnnee);
            // TODO: cette ligne de code charge les données dans la table 'bDClubDeGolfBDataSet1.statsReabonnementMoisAnnee'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.statsReabonnementMoisAnneeTableAdapter.Fill(this.bDClubDeGolfBDataSet1.statsReabonnementMoisAnnee);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.ReabonnementAnneeType'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ReabonnementAnneeTypeTableAdapter.Fill(this.BDClubDeGolfBDataSet.ReabonnementAnneeType);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.statsAbonnementMoisAnnee'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.statsAbonnementMoisAnneeTableAdapter.Fill(this.BDClubDeGolfBDataSet.statsAbonnementMoisAnnee);
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.StatsAbonnementAnneeType'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.StatsAbonnementAnneeTypeTableAdapter.Fill(this.BDClubDeGolfBDataSet.StatsAbonnementAnneeType);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
            this.reportViewer7.RefreshReport();
            this.reportViewer8.RefreshReport();
            this.reportViewer7.RefreshReport();
        }

        private void frmStatistique_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
            reportViewer2.LocalReport.ReleaseSandboxAppDomain();
            reportViewer3.LocalReport.ReleaseSandboxAppDomain();
            reportViewer4.LocalReport.ReleaseSandboxAppDomain();
            reportViewer5.LocalReport.ReleaseSandboxAppDomain();
            reportViewer6.LocalReport.ReleaseSandboxAppDomain();
            reportViewer7.LocalReport.ReleaseSandboxAppDomain();
            reportViewer8.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
