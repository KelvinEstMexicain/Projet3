﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet3
{
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
			alert("Je suis un mexicain");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionEmployes gestion = new frmGestionEmployes();
            gestion.ShowDialog();
            this.Show();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
