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
        Employes emp;
        public frmAbonnementPrincipal(Employes emp)
        {
            InitializeComponent();
            this.emp = emp;
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
            nbEnfantsLabel.Visible = false;
            nbEnfantsNumericUpDown.Visible = false;
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
                dataContexteProjet1.Abonnements.InsertOnSubmit(abonnement);
                List<Dependants> enfantList = new List<Dependants>();
                var conjoint = new Dependants();
                if (abonnement.NoTypeAbonnement >= 3)
                {
                    var ajoutConjoint = new frmAjoutDependant(out conjoint, 3, abonnement.Id);
                    ajoutConjoint.ShowDialog();
                    dataContexteProjet1.Dependants.InsertOnSubmit(conjoint);
                    if (abonnement.NoTypeAbonnement >= 4)
                    {
                        int typeAbonnement = abonnement.NoTypeAbonnement;
                        if (typeAbonnement == 6)
                        {
                            typeAbonnement = 3 + (int)nbEnfantsNumericUpDown.Value;
                        }
                        for (int i = 4; i <= typeAbonnement; i++)
                        {
                            var enfant = new Dependants();
                            var ajoutEnfant = new frmAjoutDependant(out enfant, i, abonnement.Id);
                            enfantList.Add(enfant);
                            ajoutEnfant.ShowDialog();
                            dataContexteProjet1.Dependants.InsertOnSubmit(enfant);
                        }
                    }
                }
                try
                {
                    dataContexteProjet1.SubmitChanges();
                    String mail = "";
                    mail += "-------Abonnement-------\r\n";
                    mail += "Type d'abonnement: " + abonnement.TypesAbonnement.Description + "\r\n";
                    mail += "Coût annuel: " + abonnement.TypesAbonnement.PrixDepensesAbonnements.First().Prix + "\r\n";
                    mail += "Dépenses obligatoires annuelles: " + abonnement.TypesAbonnement.PrixDepensesAbonnements.First().Prix + "\r\n";
                    mail += "Date d'abonnement/du dernier réabonnement: " + abonnement.DateAbonnement + "\r\n";
                    mail += "-------Abonné Principal-------\r\n";
                    mail += "Nom: " + abonnement.Prenom + " " + abonnement.Nom + "\r\n";
                    mail += "No d'abonnement: " + abonnement.Id + "\r\n";
                    if (abonnement.NoTypeAbonnement >= 3)
                    {
                        if (conjoint.Sexe == "H")
                        {
                            mail += "-------Conjoint-------\r\n";
                        }
                        else
                        {
                            mail += "-------Conjointe-------\r\n";
                        }
                        mail += "Nom: " + conjoint.Prenom + " " + conjoint.Nom + "\r\n";
                        mail += "No du conjoint: " + conjoint.Id + "\r\n";
                    }
                    if (abonnement.NoTypeAbonnement >= 4)
                    {
                        int compteur = 1;
                        foreach (Dependants enfant in enfantList)
                        {
                            mail += "-------Enfant #" + compteur + "-------\r\n";
                            mail += "Nom: " + enfant.Prenom + " " + enfant.Nom + "\r\n";
                            mail += "No de l'enfant: " + enfant.Id + "\r\n";
                            compteur++;
                        }
                    }
                    Email.SendGMail(Resources.SujetMailAbonnement, mail, emp.Prenom + " " + emp.Nom, abonnement.Courriel, abonnement.Prenom + " " + abonnement.Nom);
                    MessageBox.Show(Resources.EnregistrementReussi, Resources.TitreReussi);
                    this.Close();
                }
                catch (DBConcurrencyException erreur)
                {
                    MessageBox.Show(Resources.ConflitAccesConcurrentiel, Resources.TitreErreur);
                }
                catch
                {
                    MessageBox.Show(Resources.ErreurEnregistrement, Resources.TitreErreur);
                }
            }
        }

        private void typesAbonnementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = (ComboBox)sender;
            if ((int)combobox.SelectedValue == 6)
            {
                nbEnfantsLabel.Visible = true;
                nbEnfantsNumericUpDown.Visible = true;
            }
            else
            {
                nbEnfantsLabel.Visible = false;
                nbEnfantsNumericUpDown.Visible = false;
            }
        }
    }
}
