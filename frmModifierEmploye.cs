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
    public partial class frmModifierEmploye : Form
    {
        private int noEmploye;
        DataClasses1DataContext dataContexteProjet1;
        private Employes emp;

        public frmModifierEmploye(int noEmploye, DataClasses1DataContext dataContexteProjet1)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.noEmploye = noEmploye;
            this.dataContexteProjet1 = dataContexteProjet1;
        }

        private void frmModifierEmploye_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDClubDeGolfBDataSet.TypesEmploye' table. You can move, or remove it, as needed.
            this.typesEmployeTableAdapter.Fill(this.bDClubDeGolfBDataSet.TypesEmploye);
            // TODO: This line of code loads data into the 'bDClubDeGolfBDataSet.Provinces' table. You can move, or remove it, as needed.
            this.provincesTableAdapter.Fill(this.bDClubDeGolfBDataSet.Provinces);
            employesBindingSource.DataSource = from unEmploye in dataContexteProjet1.Employes
                                               where unEmploye.No == noEmploye
                                               select unEmploye;
            emp = (Employes)employesBindingSource.Current;
            cmbSexe.SelectedItem = emp.Sexe;
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

        private void motDePasseTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errMessage, Resources.MotDePasseNonValide, e);
        }

        private void cmbSexe_Validating(object sender, CancelEventArgs e)
        {
            Validation.ComboBoxValideNonVide(sender, errMessage, Resources.SexeNonSelectionne, e);
        }

        private void courrielTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideEmail(sender, errMessage, Resources.CourrielNonValide, e);
        }

        private void telephoneMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.MaskedTextBoxValideTel(sender, errMessage, Resources.TelNonValide, e);
        }

        private void cellulaireMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.MaskedTextBoxValideTelOpt(sender, errMessage, Resources.CelNonValide, e);
        }

        private void provincesComboBox_Validating(object sender, CancelEventArgs e)
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

        private void noCiviqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNombres(sender, errMessage, Resources.NoCiviqueNonValide, e);
        }

        private void salaireHoraireTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideArgent(sender, errMessage, Resources.SalaireNonValide, e);
        }

        private void remarqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errMessage, Resources.RemarquesNonValide, e);
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                emp.Age = (int)ageNumericUpDown.Value;
                emp.Cellulaire = cellulaireMaskedTextBox.Text == "(   )    -" ? "" : cellulaireMaskedTextBox.Text;
                emp.CodePostal = codePostalTextBox.Text;
                emp.Courriel = courrielTextBox.Text;
                emp.IdProvince = provincesComboBox.SelectedValue.ToString();
                emp.MotDePasse = motDePasseTextBox.Text;
                emp.No = int.Parse(noTextBox.Text);
                emp.NoCivique = noCiviqueTextBox.Text;
                emp.Nom = nomTextBox.Text;
                emp.NotypeEmploye = (int)typesEmployeComboBox.SelectedValue;
                emp.Prenom = prenomTextBox.Text;
                emp.Remarque = remarqueTextBox.Text;
                emp.Rue = rueTextBox.Text;
                emp.SalaireHoraire = decimal.Parse(salaireHoraireTextBox.Text);
                emp.Sexe = cmbSexe.SelectedItem.ToString();
                emp.Telephone = telephoneMaskedTextBox.Text;
                emp.Ville = villeTextBox.Text;
                try
                {
                    dataContexteProjet1.SubmitChanges();
                    this.Close();
                }
                catch (DBConcurrencyException erreur)
                {
                    MessageBox.Show(Resources.ConflitAccesConcurrentiel, Resources.TitreErreur);
                }
                catch
                {
                    MessageBox.Show(Resources.ErreurBD, Resources.TitreErreur);
                }
            }
        }
    }
}
