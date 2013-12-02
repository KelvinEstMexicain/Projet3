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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

        }

        private void btnAjoutAbonnement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAbonnementPrincipal abonnement = new frmAbonnementPrincipal();
            abonnement.ShowDialog();
            this.Show();
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReabonnement abonnement = new frmReabonnement();
            abonnement.ShowDialog();
            this.Show();
        }

        private void btnGestionEmployes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionEmployes employe = new frmGestionEmployes();
            employe.ShowDialog();
            this.Show();
        }

        private void btnModifierEmploye_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModifierEmploye employe = new frmModifierEmploye();
            employe.ShowDialog();
            this.Show();
        }

        private void btnAjoutDepenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAjoutPrixDepenses depenses = new frmAjoutPrixDepenses();
            depenses.ShowDialog();
            this.Show();
        }
    }
}
