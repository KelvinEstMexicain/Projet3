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
            var employes = from unEmploye in dataContexteProjet1.Employes
                            select unEmploye;
            var max = employes.Max(x => x.No);
            var resultat = employes.First(x => x.No == max);
            noTextBox.Text = (resultat.No + 1).ToString();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prenomTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideTextSeulement(sender, errMessage, Resources.PrenomNonValide);
        }

        private void nomTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideTextSeulement(sender, errMessage, Resources.NomNonValide);
        }

        private void courrielTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideEmail(sender, errMessage, Resources.CourrielNonValide);
        }

        private void telTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.MaskedTextBoxValideTel(sender, errMessage, Resources.TelNonValide);
        }

        private void motDePasseTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errMessage, Resources.MotDePasseNonValide);
        }

        
    }
}
