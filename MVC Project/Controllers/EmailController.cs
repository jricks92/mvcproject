using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class EmailController : Controller
    {
        //
        // GET: /MailMessaging/

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Sent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact( Email objModelMail, HttpPostedFileBase fileUploader)
        {
            if (ModelState.IsValid)
            {
                string from = "test@jamesonricks.com";
                using (MailMessage mail = new MailMessage( objModelMail.From, from))
            {
        mail.Subject = objModelMail.Subject;
        mail.Body = objModelMail.Body;
            if (fileUploader != null)
            {
              string fileName = Path.GetFileName(fileUploader.FileName);
              mail.Attachments.Add(new Attachment(fileUploader.InputStream, fileName));
            }
        mail.IsBodyHtml = false;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "mail.jamesonricks.com";
        smtp.EnableSsl = false;
        NetworkCredential networkCredential = new NetworkCredential(from, "jameson4president");
        smtp.UseDefaultCredentials = true;
        smtp.Credentials = networkCredential;
        smtp.Port = 26;

        smtp.Send(mail);
        ViewBag.Message = "Sent";
        return View("Sent", objModelMail);
        }
        }
        else
        {
        return View();
        }
        }

}
}