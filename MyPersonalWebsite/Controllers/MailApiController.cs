using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using System.Net.Mime;
using System.Web.Configuration;
using System.Web.Mvc;

namespace MyPersonalWebsite.Controllers
{
    public class MailApiController : Controller
    {
        [HttpPost]
        public string PostMail(MailModel mailModel)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(mailModel.SenderEmail))
                {
                    return "email";
                }
                MailAddress m = new MailAddress(mailModel.SenderEmail);
                //return true;
            }
            catch (FormatException)
            {
                return "email";
            }


            try
            {
                MailMessage msg1 = new MailMessage();

                //send the Feedback to Self
                msg1.From = new MailAddress("mail@chinmoymohanty.com", !String.IsNullOrWhiteSpace(mailModel.SenderName) ? mailModel.SenderName : "User");
                msg1.To.Add("chinmoymohanty85@gmail.com");
                msg1.Subject = "Feedback from Visitor";
                msg1.Body = mailModel.MailBody;
                msg1.IsBodyHtml = false;


                //send the Acknowledgement to Visitor
                MailMessage msg2 = new MailMessage();
                msg2.From = new MailAddress("mail@chinmoymohanty.com", "Chinmoy Mohanty");
                msg2.To.Add(mailModel.SenderEmail);
                msg2.Subject = "Thank you for your Feedback";
                msg2.Body = "Hi " + (!String.IsNullOrWhiteSpace(mailModel.SenderName) ? mailModel.SenderName : "User") + "," + Environment.NewLine + Environment.NewLine + "I am very glad that you took the time to provide me feedback and suggestions regarding my website and its deeply appreciated. I'll try to get back to you at the earliest regarding the same." + Environment.NewLine + Environment.NewLine + "Regards," + Environment.NewLine + "Chinmoy Mohanty";
                msg2.IsBodyHtml = false;

                // Init SmtpClient and send
                SmtpClient smtpClient = new SmtpClient("smtp.sendgrid.net", Convert.ToInt32(587));

                //sendgrid creds - get it at runtime from azure config OR override in azure config
                var sgUserName = WebConfigurationManager.AppSettings["SendGridUserName"];
                var sgPassword = WebConfigurationManager.AppSettings["SendGridPassword"];

                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(sgUserName, sgPassword);
                smtpClient.Credentials = credentials;

                smtpClient.Send(msg1);
                smtpClient.Send(msg2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return "Success";
        }
    }

    public class MailModel
    {
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string MailBody { get; set; }

    }
}