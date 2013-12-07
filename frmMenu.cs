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
        private Employes employe;
        public frmMenu(Employes employe)
        {
            InitializeComponent();
            this.employe = employe;
            switch(employe.NotypeEmploye)
            {
                case (int)enumTypeEmploye.administrateur:
                    break;
                case (int)enumTypeEmploye.direction:
                    btnAjoutAbonnement.Enabled = false;
                    break;
                case (int)enumTypeEmploye.proprioClub:
                    btnGestionEmployes.Enabled = false;
                    break;
                case (int)enumTypeEmploye.employeClub:
                    btnGestionEmployes.Enabled = false;
                    break;
                case (int)enumTypeEmploye.employeProShop:
                    btnAjoutAbonnement.Enabled = false;
                    btnGestionEmployes.Enabled = false;
                    break;
                case (int)enumTypeEmploye.employeResto:
                    btnAjoutAbonnement.Enabled = false;
                    btnGestionEmployes.Enabled = false;
                    break;
                case (int)enumTypeEmploye.profGolf:
                    btnAjoutAbonnement.Enabled = false;
                    btnGestionEmployes.Enabled = false;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void btnAjoutAbonnement_Click(object sender, EventArgs e)
        {
            this.Hide();
            var abonnement = new frmAbonnementPrincipal();
            abonnement.ShowDialog();
            this.Show();
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {
            this.Hide();
            var abonnement = new frmReabonnement();
            abonnement.ShowDialog();
            this.Show();
        }

        private void btnGestionEmployes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gestion = new frmGestionEmployes(employe);
            gestion.ShowDialog();
            this.Show();
        }

        private void btnAjoutDepenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            var depenses = new frmAjoutPrixDepenses();
            depenses.ShowDialog();
            this.Show();
        }

        private enum enumTypeEmploye
        {
            administrateur = 1,
            direction = 2,
            proprioClub = 3,
            employeClub = 4,
            employeProShop = 5,
            employeResto = 6,
            profGolf = 7
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rapport = new frmRapports();
            rapport.ShowDialog();
            this.Show();
        }
    }
}
