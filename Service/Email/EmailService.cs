using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Service.Email
{
    public static class EmailService
    {
        public async static Task SendEmail(string subject,string body,string email)
        {
            var fromAddress = new MailAddress("firsttimers007@gmail.com", subject);
            var toAddress = new MailAddress(email, "Admin");
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "knnstjchijkzgpve")
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                await smtp.SendMailAsync(message);
            }


        }
    }
}
