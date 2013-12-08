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
            // TODO: cette ligne de code charge les données dans la table 'BDClubDeGolfBDataSet.StatsAbonnementAnneeType'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.StatsAbonnementAnneeTypeTableAdapter.Fill(this.BDClubDeGolfBDataSet.StatsAbonnementAnneeType);

            this.reportViewer1.RefreshReport();
        }
    }
}
