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
    public partial class frmAjoutEmploye : Form
    {
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        public frmAjoutEmploye()
        {
            InitializeComponent();
        }

        private void frmAjoutEmploye_Load(object sender, EventArgs e)
        {
            Employes emp = new Employes();
            provincesBindingSource.DataSource = from uneProvince in dataContexteProjet1.Provinces
                                                select uneProvince;
            typesEmployeBindingSource.DataSource = from unType in dataContexteProjet1.TypesEmploye
                                                   select unType;
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
