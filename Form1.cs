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
            MessageBox.Show(Resources.NoEmployeInvalide, Resources.TitreErreur);
            MessageBox.Show("Test");

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
