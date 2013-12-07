using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Projet3.Properties;

namespace Projet3
{
    public partial class frmAbonnementPrincipal : Form
    {
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        string suffixeId = "";
        public frmAbonnementPrincipal()
        {
            InitializeComponent();
        }

        private void frmAbonnementPrincipal_Load(object sender, EventArgs e)
        {
            this.typesAbonnementTableAdapter.Fill(this.bDClubDeGolfBDataSet.TypesAbonnement);
            this.provincesTableAdapter.Fill(this.bDClubDeGolfBDataSet.Provinces);

            var idAbonnements = from unAbonnement in dataContexteProjet1.Abonnements
                                select unAbonnement.Id;

            var indexMax = 1;
            foreach (string idAbonnement in idAbonnements)
            {
                Regex rgx = new Regex("[a-zA-Z'àâéèêôùûçÀÂÉÈÔÙÛÇ -]");
                int index = int.Parse(rgx.Replace(idAbonnement, ""));
                if (index >= indexMax)
                {
                    indexMax = index + 1;
                }
            }
            suffixeId = indexMax + "P";
            idTextBox.Text = suffixeId;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nomTextBox_TextChanged(object sender, EventArgs e)
        {
            idTextBox.Text = ((TextBoxBase)sender).Text + suffixeId;
        }

        private void prenomTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideTextSeulement(sender, errProvider, Resources.PrenomNonValide, e);
        }

        private void nomTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideTextSeulement(sender, errProvider, Resources.NomNonValide, e);
        }

        private void cmbSexe_Validating(object sender, CancelEventArgs e)
        {
            Validation.ComboBoxValideNonVide(sender, errProvider, Resources.SexeNonSelectionne, e);
        }

        private void telephoneMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.MaskedTextBoxValideTel(sender, errProvider, Resources.TelNonValide, e);
        }

        private void cellulaireMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.MaskedTextBoxValideTelOpt(sender, errProvider, Resources.CelNonValide, e);
        }

        private void codePostalTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideCodePostal(sender, errProvider, Resources.CodePostalNonValide, e);
        }

        private void courrielTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideEmail(sender, errProvider, Resources.CourrielNonValide, e);
        }

        private void provincesComboBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.ComboBoxValideNonVide(sender, errProvider, Resources.ProvinceNonSelectionne, e);
        }

        private void noCiviqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errProvider, Resources.NoCiviqueNonValide, e);
        }

        private void typesAbonnementComboBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.ComboBoxValideNonVide(sender, errProvider, Resources.TypeAbonnementNonValide, e);
        }

        private void rueTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errProvider, Resources.RueNonValide, e);
        }

        private void villeTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errProvider, Resources.VilleNonValide, e);
        }

        private void remarqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errProvider, Resources.RemarquesNonValide, e);
        }

        private void dateNaissanceDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if ((int)typesAbonnementComboBox.SelectedValue == 2)
            {
                Validation.DateTimePickerValideAgeDor(sender, errProvider, Resources.PasAgeDor, e);
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Abonnements abonnement = new Abonnements();
                abonnement.Cellulaire = cellulaireMaskedTextBox.Text == "(   )    -" ? "" : cellulaireMaskedTextBox.Text;      
                abonnement.CodePostal = codePostalTextBox.Text;
                abonnement.Courriel = courrielTextBox.Text;
                abonnement.DateAbonnement = dateAbonnementDateTimePicker.Value;
                abonnement.DateNaissance = dateNaissanceDateTimePicker.Value;
                abonnement.Id = idTextBox.Text;
                abonnement.IdProvince = provincesComboBox.SelectedValue.ToString();
                abonnement.NoCivique = noCiviqueTextBox.Text;
                abonnement.Nom = nomTextBox.Text;
                abonnement.NoTypeAbonnement = (int)typesAbonnementComboBox.SelectedValue;
                abonnement.Prenom = prenomTextBox.Text;
                abonnement.Remarque = remarqueTextBox.Text;
                abonnement.Rue = rueTextBox.Text;
                abonnement.Sexe = cmbSexe.SelectedItem.ToString();
                abonnement.Telephone = telephoneMaskedTextBox.Text;
                abonnement.Ville = villeTextBox.Text;
            }
        }
    }
}
