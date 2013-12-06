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
            provincesBindingSource.DataSource = from uneProvince in dataContexteProjet1.Provinces
                                                select uneProvince;
            typesEmployeBindingSource.DataSource = from unType in dataContexteProjet1.TypesEmploye
                                                   where unType.No != 1
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
            Validation.TextBoxValideTextSeulement(sender, errMessage, Resources.PrenomNonValide, e);
        }

        private void nomTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideTextSeulement(sender, errMessage, Resources.NomNonValide, e);
        }

        private void courrielTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideEmail(sender, errMessage, Resources.CourrielNonValide, e);
        }

        private void telTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.MaskedTextBoxValideTel(sender, errMessage, Resources.TelNonValide, e);
        }

        private void motDePasseTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errMessage, Resources.MotDePasseNonValide, e);
        }

        private void cmbSexe_Validating(object sender, CancelEventArgs e)
        {
            Validation.ComboBoxValideNonVide(sender, errMessage, Resources.SexeNonSelectionne, e);
        }

        private void celTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.MaskedTextBoxValideTelOpt(sender, errMessage, Resources.CelNonValide, e);
        }

        private void cbProvince_Validating(object sender, CancelEventArgs e)
        {
            Validation.ComboBoxValideNonVide(sender, errMessage, Resources.ProvinceNonSelectionne, e);
        }

        private void rueTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errMessage, Resources.RueNonValide, e);
        }

        private void villeTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errMessage, Resources.VilleNonValide, e);
        }

        private void codePostalTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideCodePostal(sender, errMessage, Resources.CodePostalNonValide, e);
        }

        private void salaireHoraireTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideArgent(sender, errMessage, Resources.SalaireNonValide, e);
        }

        private void noCiviqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNombres(sender, errMessage, Resources.NoCiviqueNonValide, e);
        }

        private void remarqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errMessage, Resources.RemarquesNonValide, e);
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                Employes emp = new Employes();
                emp.Age = (int)ageNumeric.Value;
                emp.Cellulaire = celTextBox.Text == "(   )    -" ? "" : celTextBox.Text;           
                emp.CodePostal = codePostalTextBox.Text;
                emp.Courriel = courrielTextBox.Text;
                emp.IdProvince = cbProvince.SelectedValue.ToString();
                emp.MotDePasse = motDePasseTextBox.Text;
                emp.No = int.Parse(noTextBox.Text);
                emp.NoCivique = noCiviqueTextBox.Text;
                emp.Nom = nomTextBox.Text;
                emp.NotypeEmploye = (int)cmbTypeEmploye.SelectedValue;
                emp.Prenom = prenomTextBox.Text;
                emp.Remarque = remarqueTextBox.Text;
                emp.Rue = rueTextBox.Text;
                emp.SalaireHoraire = decimal.Parse(salaireHoraireTextBox.Text);
                emp.Sexe = cmbSexe.SelectedItem.ToString();
                emp.Telephone = telTextBox.Text;
                emp.Ville = villeTextBox.Text;
                dataContexteProjet1.Employes.InsertOnSubmit(emp);
                dataContexteProjet1.SubmitChanges();
                this.Close();
            }
        }
        
    }
}
