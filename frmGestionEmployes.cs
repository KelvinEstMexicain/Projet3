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
    public partial class frmGestionEmployes : Form
    {
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        private Employes employe;

        public frmGestionEmployes(Employes employe)
        {
            InitializeComponent();
            this.employe = employe;
        }
        private void frmGestionEmployes_Load(object sender,EventArgs e) {
            loadEmployes();
        }

        private void loadEmployes()
        {
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
            loadEmployes();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.Hide();
            var modifierEmploye = new frmModifierEmploye(int.Parse(employesDataGridView.SelectedRows[0].Cells[0].Value.ToString()), dataContexteProjet1);
            modifierEmploye.ShowDialog();
            this.Show();
            loadEmployes();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Employes selectedEmploye = (from unEmploye in dataContexteProjet1.Employes
                                  where unEmploye.No == (int)employesDataGridView.SelectedRows[0].Cells[0].Value
                                  select unEmploye).First();
            var lstServices = from unService in dataContexteProjet1.Services
                              select unService.NoEmploye;

            if (selectedEmploye.No == 1)
            {
                MessageBox.Show(Resources.SupprimerAdmin, Resources.TitreErreur);
            }
            else if(selectedEmploye.No == employe.No)
            {
                MessageBox.Show(Resources.SupprimerSoisMeme, Resources.TitreErreur);
            }
            else if(lstServices.Contains(selectedEmploye.No))
            {
                MessageBox.Show(Resources.SupprimerAdminAvecService, Resources.TitreErreur);
            }
            else if(MessageBox.Show("Êtes-vous sur de vouloir supprimer cet utilisateur?", "Supprimer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dataContexteProjet1.Employes.DeleteOnSubmit(selectedEmploye);
                    dataContexteProjet1.SubmitChanges();
                }
                catch (DBConcurrencyException erreur)
                {
                    MessageBox.Show(Resources.ConflitAccesConcurrentiel, Resources.TitreErreur);
                }
                catch
                {
                    MessageBox.Show(Resources.ErreurBD, Resources.TitreErreur);
                }
                loadEmployes();
            }
        }
    }
}
