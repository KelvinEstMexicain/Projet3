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
    public partial class frmAjoutPartieGolf : Form
    {
        Employes employe;
        public frmAjoutPartieGolf(Employes employe)
        {
            InitializeComponent();
            this.employe = employe;
        }
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        private void frmAjoutPartieGolf_Load(object sender, EventArgs e)
        {
            noEtNomCompletAbonnementBindingSource.DataSource = from unAbonnement in dataContexteProjet1.Abonnements
                                                               select new
                                                               {
                                                                   noAbonnement = unAbonnement.Id,
                                                                   nomCompletAbonnement = unAbonnement.Prenom + " " + unAbonnement.Nom
                                                               };
            terrainsBindingSource.DataSource = from unTerrain in dataContexteProjet1.Terrains
                                               select unTerrain;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {

        }

        private void pointageTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxMonnaieValide(sender, errMessage, Resources.PointageNonValide, e);
        }
    }
}
