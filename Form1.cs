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
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            MessageBox.Show(Resources.NoEmployeInvalide, Resources.TitreErreur);
            MessageBox.Show("Test");

>>>>>>> 66532c8d96c558ed53a5ef6c04bedfb60a215e10
            this.Hide();
            frmMiseAJourAbonnes gestion = new frmMiseAJourAbonnes();
            gestion.ShowDialog();
            this.Show();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
