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
    public partial class frmReabonnement : Form
    {
        DataClasses1DataContext dataContexteProjet1 = new DataClasses1DataContext();
        Employes emp;
        public frmReabonnement(Employes emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void frmReabonnement_Load(object sender, EventArgs e)
        {
            abonnementsBindingSource.DataSource = from unAbonnement in dataContexteProjet1.Abonnements
                                                  orderby unAbonnement.Id
                                                  select new {unAbonnement.Id, nomComplet = unAbonnement.Prenom + " " + unAbonnement.Prenom};
        }

        private void btnReabonnement_Click(object sender, EventArgs e)
        {
            Reabonnements reab = new Reabonnements();
            reab.Remarque = remarqueTextBox.Text;
            reab.IdAbonnement = abonnementsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            reab.DateRenouvellement = DateTime.Now;

            var lstReab = from unReab in dataContexteProjet1.Reabonnements
                          where unReab.IdAbonnement == reab.IdAbonnement && unReab.DateRenouvellement.Year == reab.DateRenouvellement.Year
                          select unReab;
            var lstAbonnement = from unAbonnement in dataContexteProjet1.Abonnements
                                where unAbonnement.Id == reab.IdAbonnement && unAbonnement.DateAbonnement.Year == reab.DateRenouvellement.Year
                                select unAbonnement;

            if (lstReab.Count() == 0 && lstAbonnement.Count() == 0)
            {
                dataContexteProjet1.Reabonnements.InsertOnSubmit(reab);
                try
                {
                    dataContexteProjet1.SubmitChanges();
                    var enumerableAbonnement = from unAbonnement in dataContexteProjet1.Abonnements
                                               where unAbonnement.Id == reab.IdAbonnement
                                               select unAbonnement;
                    var enumerableDependants = from unDependant in dataContexteProjet1.Dependants
                                               where unDependant.IdAbonnement == reab.IdAbonnement
                                               select unDependant;
                    Abonnements abonnement = enumerableAbonnement.First();

                    String mail = "";
                    mail += "-------Abonnement-------\r\n";
                    mail += "Type d'abonnement: " + abonnement.TypesAbonnement.Description + "\r\n";
                    mail += "Coût annuel: " + abonnement.TypesAbonnement.PrixDepensesAbonnements.First().Prix + "\r\n";
                    mail += "Dépenses obligatoires annuelles: " + abonnement.TypesAbonnement.PrixDepensesAbonnements.First().Prix + "\r\n";
                    mail += "Date d'abonnement/du dernier réabonnement: " + reab.DateRenouvellement + "\r\n";
                    mail += "-------Abonné Principal-------\r\n";
                    mail += "Nom: " + abonnement.Prenom + " " + abonnement.Nom + "\r\n";
                    mail += "No d'abonnement: " + abonnement.Id + "\r\n";
                    Dependants conjoint = new Dependants();
                    List<Dependants> enfantList = new List<Dependants>();
                    foreach (Dependants dependant in enumerableDependants)
                    {
                        if (dependant.Id.Substring(dependant.Id.Length - 1) == "0")
                        {
                            conjoint = dependant;
                        }
                        else
                        {
                            enfantList.Add(dependant);
                        }
                    }
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
                    Email.SendGMail(Resources.SujetMailReabonnement, mail, emp.Prenom + " " + emp.Nom, abonnement.Courriel, abonnement.Prenom + " " + abonnement.Nom);
                    MessageBox.Show(Resources.UtilisateurReabonne, Resources.TitreReabonne);
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
            else
            {
                MessageBox.Show(Resources.ClientDejaReabonne, Resources.TitreErreur);
            }


        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
