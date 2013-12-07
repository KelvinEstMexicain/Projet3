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
    public partial class frmAbonnementPrincipal : Form
    {
        public frmAbonnementPrincipal()
        {
            InitializeComponent();
        }

        private void frmAbonnementPrincipal_Load(object sender, EventArgs e)
        {
            this.typesAbonnementTableAdapter.Fill(this.bDClubDeGolfBDataSet.TypesAbonnement);
            this.provincesTableAdapter.Fill(this.bDClubDeGolfBDataSet.Provinces);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
