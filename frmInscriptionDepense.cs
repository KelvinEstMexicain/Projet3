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

                int anneeAbonnementReabonnement = 100;
                if(anneeAbonnement!=DateTime.Now.Year){
                    var reabonnementAnnee = from unReabonnement in dataContexteProjet1.Reabonnements
                                            where unReabonnement.IdAbonnement == cbAbonnement.SelectedValue
                                            select new { unReabonnement.DateRenouvellement };
                    foreach(var annee in reabonnementAnnee){
                        DateTime d = annee.DateRenouvellement;
                        if (anneeAbonnementReabonnement < d.Year)
                        {
                            anneeAbonnementReabonnement = d.Year;
                        }
                    }
                    if (anneeAbonnementReabonnement < DateTime.Now.Year)
                    {
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

                        if (anneeAbonnement != DateTime.Now.Year) {
                            decimal montant = 0;
                        var depenseFaite= from uneDepense in dataContexteProjet1.Depenses
                                          where uneDepense.IdAbonnement==cbAbonnement.SelectedValue && uneDepense.DateDepense.Year==anneeAbonnementReabonnement
                                          group uneDepense by uneDepense.No
                                          into lesDepenses
                                          let depenseTotal = lesDepenses.Sum(x=>x.Montant)
                                          select new{depenseTotal};

                            foreach(var maDepenseTotal in depenseFaite){
                                montant += maDepenseTotal.depenseTotal;
                            }

                        int monTypeAbonnement = 0;
                        var typeAbonnement = from unAbonnement in dataContexteProjet1.Abonnements
                                             where unAbonnement.Id == cbAbonnement.SelectedValue
                                             select new { unAbonnement.NoTypeAbonnement };

                            foreach(var unAbonnement in typeAbonnement){
                                monTypeAbonnement = unAbonnement.NoTypeAbonnement;
                            }

                            var prixAbonnement = from depenseAbonnement in dataContexteProjet1.PrixDepensesAbonnements
                                                 where depenseAbonnement.NoTypeAbonnement == monTypeAbonnement
                                                 orderby depenseAbonnement.Annee descending
                                                 select new { depenseAbonnement.DepensesObligatoires };
                            decimal prixDepensesObligatoire = prixAbonnement.First().DepensesObligatoires;

                            decimal montantDepenseRestantAFaire = 0;
                            if(prixDepensesObligatoire>montant){
                                montantDepenseRestantAFaire = prixDepensesObligatoire - montant;
                            }
                            string courriel="";
                            string nom = "";
                            string prenom = "";
                            var courrielAbonnement = from unAbonnement in dataContexteProjet1.Abonnements
                                                     where unAbonnement.Id == cbAbonnement.SelectedValue
                                                     select new { unAbonnement.Courriel,unAbonnement.Nom,unAbonnement.Prenom};

                            foreach (var unCourriel in courrielAbonnement)
                            {
                                courriel = unCourriel.Courriel;
                                nom = unCourriel.Nom;
                                prenom = unCourriel.Prenom;
                            }
                            String mail = "";
                            mail += "------------Depense Effectué---------------\r\n";
                            mail += "La date de la dépense effectué: "+dateDepenseDateTimePicker.Value.ToString()+"\r\n";
                            mail += "Montant total des dépenses déjà effectué: "+montant.ToString("0.00")+"$\r\n";
                            mail += "Montant qu'il reste à faire des dépenses qu'il reste à faire cette année: " + montantDepenseRestantAFaire.ToString("0.00") + "$\r\n\r\n";
                            mail += "Vous avez été servi par : "+employe.Prenom+" "+employe.Nom+"\r\n";
                            mail += "Le service rendu : "+txtService.Text+"\r\n";
                            mail += "Pour tout autres problèmes veillez contactez au : 514 888-8275\r\n";
                            Email.SendGMail(Resources.SujetMailAbonnement, mail, employe.Prenom + " " + employe.Nom, courriel, prenom + " " +nom);
                        }
                        MessageBox.Show("Ajout faite et l'Envoi du courriel faite");
                        this.Close();
                        
                    }
                    catch (DBConcurrencyException erreur)
                    {
                        MessageBox.Show(Resources.ConflitAccesConcurrentiel, Resources.TitreErreur);
                    }
                    catch(Exception errrr){
                        MessageBox.Show("un probleme!");
                    };
                }
                else {
                    MessageBox.Show("N'a pas été rajouté, car l'abonné ne s'est pas réabonné");
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
