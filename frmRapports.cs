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

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }
    }
}
