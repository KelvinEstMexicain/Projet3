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
    public partial class frmMiseAJourAbonnes : Form
    {
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        public frmMiseAJourAbonnes()
        {
            InitializeComponent();
        }

        private void abonnementsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if(abonnementsBindingSource.Current!=null){
                dependantsBindingSource.DataSource = from unDependant in dataContexteProjet1.Dependants
                                                     where unDependant.Abonnements == (Abonnements)abonnementsBindingSource.Current
                                                     select unDependant;
            }
        }

        private void frmMiseAJourAbonnes_Load(object sender, EventArgs e)
        {
            abonnementsBindingSource.DataSource = from unAbonnement in dataContexteProjet1.Abonnements
                                                  select unAbonnement;
        }
    }
}
