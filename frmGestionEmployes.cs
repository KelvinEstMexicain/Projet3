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
    public partial class frmGestionEmployes : Form
    {
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        public frmGestionEmployes()
        {
            InitializeComponent();
        }
        private void frmGestionEmployes_Load(object sender,EventArgs e) {
            employesBindingSource.DataSource = from unEmploye in dataContexteProjet1.Employes
                                               orderby unEmploye.No
                                               select unEmploye;
        }

        private void btnAjoutEmployer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ajoutEmploye = new frmAjoutEmploye();
            ajoutEmploye.ShowDialog();
            this.Show();
            employesBindingSource.DataSource = from unEmploye in dataContexteProjet1.Employes
                                               orderby unEmploye.No
                                               select unEmploye;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
        }
    }
}
