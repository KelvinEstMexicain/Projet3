using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Projet3.Properties;
using System.Text.RegularExpressions;

namespace Projet3
{
    public partial class frmAjoutDependant : Form
    {
        Dependants dependant;
        int typeDependant;
        string idAbonnement;
        public frmAjoutDependant(out Dependants dependant, int typeDependant, string idAbonnement)
        {
            InitializeComponent();
            dependant = new Dependants();
            this.dependant = dependant;
            this.typeDependant = typeDependant;
            this.idAbonnement = idAbonnement;
        }

        private void frmAjoutDependant_Load(object sender, EventArgs e)
        {
            idAbonnementTextBox.Text = idAbonnement;
            if (typeDependant == 3)
            {
                label1.Text = Resources.TitreAbonnementConjoint;
            }
            else
            {
                label1.Text = Resources.TitreAbonnementEnfant;
            }
            creerId();
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

        private void remarqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender, errProvider, Resources.RemarquesNonValide, e);
        }

        private void creerId()
        {
            String sexe = cmbSexe.SelectedItem == null ? "*" : cmbSexe.SelectedItem.ToString();
            String id = "";
            if (typeDependant == 3)
            {
                id = idAbonnement.Substring(0, idAbonnement.Length - 1) + sexe + 0;
            }
            else
            {
                id = idAbonnement.Substring(0, idAbonnement.Length - 1) + "E" + (typeDependant - 3);
            }
            idTextBox.Text = id;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSexe_SelectedIndexChanged(object sender, EventArgs e)
        {
            creerId();
        }

        private void frmAjoutDependant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ValidateChildren())
            {
                dependant.DateNaissance = dateNaissanceDateTimePicker.Value;
                dependant.Id = idTextBox.Text;
                dependant.IdAbonnement = idAbonnementTextBox.Text;
                dependant.Nom = nomTextBox.Text;
                dependant.Prenom = prenomTextBox.Text;
                dependant.Remarque = remarqueTextBox.Text;
                dependant.Sexe = cmbSexe.SelectedItem.ToString();
            }
            else
            {
                e.Cancel = true;
            }
        }


    }
}
