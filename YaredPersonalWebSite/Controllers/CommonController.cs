using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace YaredPersonalWebSite.Controllers
{
    public class CommonController : Controller
    {
        //
        // GET: /Common/

        [HttpPost]
        public ActionResult SendMail(Models.MailModel form)
        {
            var retValue = string.Empty;
            if (!ModelState.IsValid)
            {
                return Content(retValue);
            }

            if (!ModelState.IsValid) return Content(retValue);

            //Update your SMTP server credentials
            using (var client = new SmtpClient
            {
                Host = "smtp.office365.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("contactus@gradientpowers.com", "YTN892013"),
                DeliveryMethod = SmtpDeliveryMethod.Network
            })
            {
                var mail = new MailMessage();
                mail.To.Add("contactus@gradientpowers.com"); // Update your email address
                mail.From = new MailAddress(form.Email, form.Name);
                mail.Subject = String.Format("Request to Contact from {0}", form.Subject);
                mail.Body = form.Message + "<br/><br/>" + form.Email;
                mail.IsBodyHtml = true;
                client.Send(mail);
                retValue = "Message Sent. I will contact you ASAP. Thanks.";
            }
            return Content(retValue);



            //MailMessage msg = new MailMessage();
            //msg.To.Add(new MailAddress("contactus@gradientpowers.com", "Contact us"));
            //msg.From = new MailAddress(form.Email, form.Name);
            //msg.Subject = String.Format("Request to Contact from {0}", form.Subject);
            //msg.Body = form.Message + "<br/><br/>" + form.Email;
            //msg.IsBodyHtml = true;

            //SmtpClient client = new SmtpClient();
            //client.UseDefaultCredentials = false;
            //client.Credentials = new System.Net.NetworkCredential("contactus@gradientpowers.com", "YTN892013");
            //client.Port = 587; // You can use Port 25 if 587 is blocked (mine is!)
            //client.Host = "smtp.office365.com";
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.EnableSsl = true;
            //try
            //{
            //    client.Send(msg);
            //    retValue = "Message Sent. I will contact you ASAP. Thanks.";
            //}
            //catch (Exception)
            //{
            //    retValue = "There was an error submitting the form, please try again later.";
            //}

            //return Content(retValue);

        }

    }
}
