using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace YaredPersonalWebSite.Controllers
{
    public class CommonController : Controller
    {
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
            retValue = "There was an error submitting the form, please try again later.";
            using (var client = new SmtpClient
            {
                Host = ConfigurationManager.AppSettings["SmtpServerName"],
                Port = 25,
                EnableSsl = false,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network
            })
            {
                var mail = new MailMessage();
                mail.To.Add(ConfigurationManager.AppSettings["ToEmailAddress"]);
                mail.From = new MailAddress(form.Email, form.Name);
                mail.Subject = String.Format(form.Subject);
                mail.Body = form.Message + "<br/><br/>" + form.Email;
                mail.IsBodyHtml = true;
                client.Send(mail);
                retValue = "Message Sent. We will contact you ASAP. Thanks.";
            }
            return Content(retValue);

        }

    }
}
