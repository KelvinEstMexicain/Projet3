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
    public partial class frmInscriptionDepense : Form
    {
        int noEmploye;
        int nombreMax = 0;
        int nbServiceID = 0;
        Employes employe;
        public frmInscriptionDepense(Employes employe)
        {
            InitializeComponent();
            //Testy test
            this.noEmploye = employe.No;
            this.employe = employe;
        }
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        private void frmInscriptionDepense_Load(object sender, EventArgs e)
        {
            noEtNomCompletAbonnementBindingSource.DataSource = from unAbonnement in dataContexteProjet1.Abonnements
                                                               select new
                                                               {
                                                                   noAbonnement = unAbonnement.Id,
                                                                   nomCompletAbonnement = unAbonnement.Prenom + " " + unAbonnement.Nom
                                                               };
            if(noEmploye==5){
                txtService.Text = "Magasin Pro Shop";
                txtService.Enabled = false;
            }
            else if(noEmploye==6){
                txtService.Text = "Restaurant";
                txtService.Enabled = false;
            }
            else if (noEmploye == 7)
            {
                txtService.Text = "Leçon de golf";
                txtService.Enabled = false;
            }
            else{
                txtService.Text = "";
                txtService.Enabled = true;
            }
            var nombre = from uneDepense in dataContexteProjet1.Depenses
                         group uneDepense by uneDepense.No 
                                               into lesDepenses
                                               let nbMax=lesDepenses.Max(x=>x.No)
                                               select new{nbMax};

            foreach (var unChiffre in nombre)
            {
                nombreMax = unChiffre.nbMax+1;
            }
            noTextBox.Text = nombreMax.ToString();
            noTextBox.Enabled = false;

        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            bool ajouterReabonnement=true;
            if (this.ValidateChildren())
            {
                int trouver=0;
                var service = from unService in dataContexteProjet1.Services
                              where unService.NoEmploye == noEmploye && unService.TypeService == txtService.Text
                              group unService by unService.No
                                  into serviceTrouver
                                  let nb = serviceTrouver.Count()
                                  select new {nb};

                foreach (var unChiffre in service)
            {
                trouver = unChiffre.nb;
            }
                if (trouver == 0)
                {
                    var serviceM = from unService in dataContexteProjet1.Services
                                   group unService by unService.No
                                       into toutServices
                                       let nb = toutServices.Max(x => x.No)
                                       select new { nb };
                    foreach (var unChiffre in serviceM)
                    {
                        nbServiceID = unChiffre.nb + 1;
                    }

                    Services services = new Services();
                    services.No = nbServiceID;
                    services.NoEmploye = employe.No;
                    services.TypeService = txtService.Text;
                    dataContexteProjet1.Services.InsertOnSubmit(services);
                }
                else {
                    var noService = from unService in dataContexteProjet1.Services
                                    where unService.TypeService == txtService.Text && unService.NoEmploye == employe.No
                                    select new {unService.No};
                    foreach (var unChiffre in noService)
                    {
                        nbServiceID = unChiffre.No;
                    }
                }

                var abonnementAnnee = from unAbonnement in dataContexteProjet1.Abonnements
                                      where unAbonnement.Id == cbAbonnement.SelectedValue
                                      select new { unAbonnement.DateAbonnement };
                int anneeAbonnement = 2000;

                foreach(var annee in abonnementAnnee){
                    DateTime d = annee.DateAbonnement;
                    anneeAbonnement = d.Year;
                }

                if((anneeAbonnement==DateTime.Now.Year)==false){
                    var reabonnementAnnee = from unReabonnement in dataContexteProjet1.Reabonnements
                                            where unReabonnement.IdAbonnement == cbAbonnement.SelectedValue
                                            select new { unReabonnement.DateRenouvellement };
                    int tempo=100;
                    foreach(var annee in reabonnementAnnee){
                        DateTime d = annee.DateRenouvellement;
                        if(tempo<d.Year){
                            tempo = d.Year;
                        }
                    }
                    if (tempo < DateTime.Now.Year) {
                        ajouterReabonnement = false;
                    }
                }

                if (ajouterReabonnement)
                {
                    Depenses depense = new Depenses();
                    depense.No = int.Parse(noTextBox.Text);
                    depense.NoService = nbServiceID;
                    depense.IdAbonnement = cbAbonnement.SelectedValue.ToString();
                    depense.Montant = decimal.Parse(montantTextBox.Text);
                    depense.DateDepense = dateDepenseDateTimePicker.Value;
                    depense.Remarque = remarqueTextBox.Text;

                    dataContexteProjet1.Depenses.InsertOnSubmit(depense);
                    
                    try
                    {
                        dataContexteProjet1.SubmitChanges();
                        MessageBox.Show("ajout faite");
                        
                    }
                    catch (DBConcurrencyException erreur)
                    {
                        MessageBox.Show(Resources.ConflitAccesConcurrentiel, Resources.TitreErreur);
                    }
                }
                else {
                    MessageBox.Show("n'a pas été rajouter");
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void montantTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxMonnaieValide(sender, errMessage, Resources.MontantNonValide, e);
        }

        private void txtService_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxValideNonVide(sender,errMessage,Resources.TypeService_Invalide,e);
        }
    }
}
