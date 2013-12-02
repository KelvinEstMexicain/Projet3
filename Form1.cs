using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Projet3.Properties;

namespace Projet3
{
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
            /* \/ A ENLEVER AVANT DE REMETTRE \/ */
            DateTime remise = new DateTime(2013,12,9,12,0,0);
            if(DateTime.Now < remise)
            {
                txtUsername.Text = "1";
                txtPassword.Text = "Banane123";
            }
            /* /\ A ENLEVER AVANT DE REMETTRE /\ */
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int noEmploye = -1;
            string motDePasse;
            if (int.TryParse(txtUsername.Text, out noEmploye))
            {
                motDePasse = txtPassword.Text;
                DataClasses1DataContext dataClasses = new DataClasses1DataContext();

                IQueryable<int> present = from unEmploye in dataClasses.Employes
                                          where unEmploye.No == noEmploye && unEmploye.MotDePasse == motDePasse
                                          select unEmploye.No;
                if(present.ToArray().Count() == 1)
                {
                    this.Hide();
                    frmMenu gestion = new frmMenu();
                    gestion.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(Resources.UtilisateurOuMotDePasseNonValide, Resources.TitreErreur);
                }
            }
            else
            {
                MessageBox.Show(Resources.NoEmployeInvalide, Resources.TitreErreur);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
            /*asdafa*/
        }
    }
}
