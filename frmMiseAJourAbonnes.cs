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
            // TODO: This line of code loads data into the 'bDClubDeGolfBDataSet.TypesAbonnement' table. You can move, or remove it, as needed.
            this.typesAbonnementTableAdapter.Fill(this.bDClubDeGolfBDataSet.TypesAbonnement);
            // TODO: This line of code loads data into the 'bDClubDeGolfBDataSet.Provinces' table. You can move, or remove it, as needed.
            this.provincesTableAdapter.Fill(this.bDClubDeGolfBDataSet.Provinces);
            abonnementsBindingSource.DataSource = from unAbonnement in dataContexteProjet1.Abonnements
                                                  select unAbonnement;
        }

        private void abonnementsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var datagridview = (DataGridView)sender;
            var selectedCell = datagridview.SelectedCells[0];
            switch (selectedCell.ColumnIndex)
            {
                //TextOnly
                case 2:
                    Validation.DataGridTextBoxValideTextSeulement(selectedCell, Resources.NomNonValide, e);
                    break;
                case 3:
                    Validation.DataGridTextBoxValideTextSeulement(selectedCell, Resources.PrenomNonValide, e);
                    break;
                //Non vide
                case 6:
                    Validation.DataGridTextBoxValideNonVide(selectedCell, Resources.NoCiviqueNonValide, e);
                    break;
                case 7:
                    Validation.DataGridTextBoxValideNonVide(selectedCell, Resources.RueNonValide, e);
                    break;
                case 8:
                    Validation.DataGridTextBoxValideNonVide(selectedCell, Resources.VilleNonValide, e);
                    break;
                case 15:
                    Validation.DataGridTextBoxValideNonVide(selectedCell, Resources.RemarquesNonValide, e);
                    break;
                //Code postal
                case 10:
                    Validation.DataGridTextBoxValideCodePostal(selectedCell, Resources.CodePostalNonValide, e);
                    break;
                //Tel
                case 11:
                    Validation.DataGridTextBoxValideTel(selectedCell, Resources.TelNonValide, e);
                    break;
                //Cel
                case 12:
                    Validation.DataGridTextBoxValideTelOpt(selectedCell, Resources.CelNonValide, e);
                    break;
                //Courriel
                case 13:
                    Validation.DataGridTextBoxValideEmail(selectedCell, Resources.CourrielNonValide, e);
                    break;
            }
            
        }

        private void dependantsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var datagridview = (DataGridView)sender;
            var selectedCell = datagridview.SelectedCells[0];
            switch (selectedCell.ColumnIndex)
            {
                //Text only
                case 1:
                    Validation.DataGridTextBoxValideTextSeulement(selectedCell, Resources.NomNonValide, e);
                    break;
                case 2:
                    Validation.DataGridTextBoxValideTextSeulement(selectedCell, Resources.PrenomNonValide, e);
                    break;
                    //Non vide
                case 6:
                    Validation.DataGridTextBoxValideNonVide(selectedCell, Resources.RemarquesNonValide, e);
                    break;

            }
            if (selectedCell.ErrorText.Length > 0)
            {
                e.Cancel = true;
                MessageBox.Show(selectedCell.ErrorText, Resources.TitreErreur);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            if (!HasErrorText())
            {
                try {
                    dataContexteProjet1.SubmitChanges();
                    MessageBox.Show(Resources.ChangementsSauvegarde, Resources.TitreSauvegarde);
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

        private bool HasErrorText()
        {
            bool hasErrorText = false;
            foreach (DataGridViewRow row in this.abonnementsDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ErrorText.Length > 0)
                    {
                        hasErrorText = true;
                        break;
                    }
                }
                if (hasErrorText)
                    break;
            }

            foreach (DataGridViewRow row in this.dependantsDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ErrorText.Length > 0)
                    {
                        hasErrorText = true;
                        break;
                    }
                }
                if (hasErrorText)
                    break;
            }

            return hasErrorText;
        }
    }
}
