using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using Projet3.Properties;
using System.Windows.Forms;

namespace Projet3
{
    public static class Email
    {
        public static bool SendGMail(String sujet, String body, String nomEmploye, String courrielAbonne, String nomAbonne)
        {
            bool reussi = false;
            try
            {
                MailMessage msg = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(Resources.AdresseSmtpGMail, 587);
                SmtpServer.Credentials = new NetworkCredential(Resources.AdresseGMail, Resources.MotDePasseGMail);
                SmtpServer.EnableSsl = true;

                msg.Subject = sujet;
                msg.Body = body;
                msg.From = new MailAddress(Resources.AdresseGMail, nomEmploye);
                msg.To.Add(new MailAddress(courrielAbonne, nomAbonne));

                SmtpServer.Send(msg);
            }
            catch (Exception k)
            {
                MessageBox.Show(Resources.EchecEnvoisCourriel + k.ToString());
            }
            return reussi;
        }
    }
}
