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
            var retValue = "There was an error submitting the form, please try again later.";
            if (!ModelState.IsValid)
            {
                return Content(retValue);
            }

            if (!ModelState.IsValid) return Content(retValue);

            //Update your SMTP server credentials
            using (var client = new SmtpClient
            {
                Host = "mail.yaredtn.com",
                Port = 587,
                EnableSsl = false,
                Credentials = new NetworkCredential("yared@yaredtn.com", "YT892013"),
                DeliveryMethod = SmtpDeliveryMethod.Network
            })
            {
                var mail = new MailMessage();
                mail.To.Add("yared@yaredtn.com"); // Update your email address
                mail.From = new MailAddress(form.Email, form.Name);
                mail.Subject = String.Format("Request to Contact from {0}", form.Subject);
                mail.Body = form.Message + "<br/><br/>" + form.Email;
                mail.IsBodyHtml = true;
                client.Send(mail);
                retValue = "Message Sent. I will contact you ASAP. Thanks.";
            }
            return Content(retValue);
        }

    }
}
