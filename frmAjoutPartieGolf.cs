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
        }
    }
}
