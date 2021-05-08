using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Additional_buttons
{
    static class SendTableOnEmail
    {
        public static void SendEmail(DataGridView dataGridView, string emailTo)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("Egor.Seven.cafe@gmail.com", "ThisIsMyLife");

            var mail = new MailMessage();
            mail.From = new MailAddress("Egor.Seven.cafe@gmail.com");
            mail.To.Add(emailTo);
            mail.IsBodyHtml = true;
            mail.Subject = "Таблица с данными";

            string mailBody = @"<table width='100%' style='border: 1px solid black;'>"; ;
            mailBody += "<tr>";
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                mailBody += "<td>" + col.HeaderText + "</td>";
            }

            mailBody += "</tr>";
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                mailBody += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    mailBody += "<td>" + cell.Value + "</td>";
                }
                {
                    mailBody += "</tr>";
                }
            }
            mailBody += "</table>";

            mail.Body = mailBody;
            client.Send(mail);
        }
        public static void IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (!(addr.Address == email))
                {
                    throw new Exception();
                }
            }
            catch
            {
                throw new Exception("Неверный адрес");
            }
        }

        public static bool IsConnectedToInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
