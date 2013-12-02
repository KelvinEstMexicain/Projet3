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
    public partial class frmReabonnement : Form
    {
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        public frmReabonnement()
        {
            InitializeComponent();
        }

        private void frmReabonnement_Load(object sender, EventArgs e)
        {
            abonnementsBindingSource.DataSource = from unAbonnement in dataContexteProjet1.Abonnements
                                                  orderby unAbonnement.Id
                                                  select unAbonnement;
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

        }
    }
}
