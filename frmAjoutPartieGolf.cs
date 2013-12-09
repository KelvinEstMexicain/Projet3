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
    public partial class frmAjoutPartieGolf : Form
    {
        Employes employe;
        public frmAjoutPartieGolf(Employes employe)
        {
            InitializeComponent();
            this.employe = employe;
        }
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        private void frmAjoutPartieGolf_Load(object sender, EventArgs e)
        {
            noEtNomCompletAbonnementBindingSource.DataSource = from unAbonnement in dataContexteProjet1.Abonnements
                                                               select new
                                                               {
                                                                   noAbonnement = unAbonnement.Id,
                                                                   nomCompletAbonnement = unAbonnement.Prenom + " " + unAbonnement.Nom
                                                               };
            terrainsBindingSource.DataSource = from unTerrain in dataContexteProjet1.Terrains
                                               select unTerrain;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            var partieJoueeAbonne = from unePartie in dataContexteProjet1.PartiesJouees
                                    where unePartie.IdAbonnement == (string)cbAbonnement.SelectedValue
                                    select new {unePartie.DatePartie };

            DateTime maDate;
            bool dateTrouveDuJour=false;

            foreach(var uneDatePartie in partieJoueeAbonne){
                maDate = Convert.ToDateTime(uneDatePartie.DatePartie.Date.ToShortDateString());
                if (maDate.Date.ToShortDateString() == datePartieDateTimePicker.Value.ToShortDateString())
                {
                    dateTrouveDuJour = true;
                }
            }
            if (dateTrouveDuJour)
            {
                MessageBox.Show(Resources.AbonneDejaJouee, Resources.TitreErreur);
            }
            else
            {
                bool abonnementValide = true;

                var abonnementAnnee = from unAbonnement in dataContexteProjet1.Abonnements
                                      where unAbonnement.Id == cbAbonnement.SelectedValue
                                      select new { unAbonnement.DateAbonnement };
                int anneeAbonnement = 2000;

                foreach (var annee in abonnementAnnee)
                {
                    DateTime d = annee.DateAbonnement;
                    anneeAbonnement = d.Year;
                }

                int anneeAbonnementReabonnement = 100;
                if (anneeAbonnement != DateTime.Now.Year)
                {
                    var reabonnementAnnee = from unReabonnement in dataContexteProjet1.Reabonnements
                                            where unReabonnement.IdAbonnement == cbAbonnement.SelectedValue
                                            select new { unReabonnement.DateRenouvellement };
                    foreach (var annee in reabonnementAnnee)
                    {
                        DateTime d = annee.DateRenouvellement;
                        if (anneeAbonnementReabonnement < d.Year)
                        {
                            anneeAbonnementReabonnement = d.Year;
                        }
                    }
                    if (anneeAbonnementReabonnement < DateTime.Now.Year)
                    {
                        abonnementValide = false;
                    }
                }

                if (abonnementValide)
                {
                    PartiesJouees partie = new PartiesJouees();
                    partie.IdAbonnement = (string)cbAbonnement.SelectedValue;
                    partie.NoTerrain = (int)cbTerrain.SelectedValue;
                    partie.DatePartie = datePartieDateTimePicker.Value;
                    partie.Pointage = int.Parse(pointageTextBox.Text);
                    partie.Remarque = remarqueTextBox.Text;
                    try
                    {
                        dataContexteProjet1.PartiesJouees.InsertOnSubmit(partie);
                        dataContexteProjet1.SubmitChanges();
                        string courriel="";
                        string nom="";
                        string prenom="";
                        var courrielAbonnement = from unAbonnement in dataContexteProjet1.Abonnements
                                                 where unAbonnement.Id == cbAbonnement.SelectedValue
                                                 select new { unAbonnement.Courriel, unAbonnement.Nom, unAbonnement.Prenom };

                        foreach (var unCourriel in courrielAbonnement)
                        {
                            courriel = unCourriel.Courriel;
                            nom = unCourriel.Nom;
                            prenom = unCourriel.Prenom;
                        }
                        String mail = "";
                        mail += "------------Partie de golf Effectué---------------\r\n";
                        mail += "Bonjour Monsieur ou Madame  " + prenom+" "+nom+ "\r\n";
                        mail += "La date de la partie effectué: " + datePartieDateTimePicker.Value.ToShortDateString() + "\r\n";
                        mail += "Votre pointage: " + pointageTextBox.Text + "\r\n";
                        mail += "Vous avez été au terrain: " + cbTerrain.Text + "\r\n\r\n";
                        mail += "Pour tout autres problèmes veillez contactez au : 514 888-8275\r\n";
                        Email.SendGMail(Resources.SujetMailAbonnement, mail, employe.Prenom + " " + employe.Nom, courriel, prenom + " " + nom);
                        MessageBox.Show(Resources.EnvoiCourrielMessage, Resources.EnvoieCourrielReussi);
                        this.Close();
                    }
                    catch (DBConcurrencyException erreur)
                    {
                        MessageBox.Show(Resources.ConflitAccesConcurrentiel, Resources.TitreErreur);
                    }
                    catch (Exception errrr)
                    {
                        MessageBox.Show("un probleme!");
                    };
                }
                else {
                    MessageBox.Show(Resources.AbonneReabonnementErreur, Resources.TitreErreur);
                }
            }

        }

        private void pointageTextBox_Validating(object sender, CancelEventArgs e)
        {
            Validation.TextBoxMonnaieValide(sender, errMessage, Resources.PointageNonValide, e);
        }
    }
}
