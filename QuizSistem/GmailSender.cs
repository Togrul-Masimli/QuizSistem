using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSistem
{
    public class GmailSender
    {
        public static void SendGmail(string MessageTo, string UserName, string Password)
        {
            string to, from, pass, messageBody;
            MailMessage message = new MailMessage();
            to = MessageTo;
            from = "quizsystemform@gmail.com";
            pass = "Quizsystemform1";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "Hi, " + UserName + "! <br>This is your password: " + Password;
            message.Subject = "Sign Up to QuizSystem";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Email Sent Succesfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
