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
    public partial class frmAjoutPrixDepenses : Form
    {
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        public frmAjoutPrixDepenses()
        {
            InitializeComponent();
        }

        private void frmAjoutPrixDepenses_Load(object sender, EventArgs e)
        {
            prixDepensesAbonnementsBindingSource.DataSource = from unPrix in dataContexteProjet1.PrixDepensesAbonnements
                                                              orderby unPrix.NoTypeAbonnement
                                                              select unPrix;
        }
    }
}
