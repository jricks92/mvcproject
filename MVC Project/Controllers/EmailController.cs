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

        //Default Contact page
        public ActionResult Contact()
        {
            return View();
        }

        //Sent confirmation
        public ActionResult Sent()
        {
            return View();
        }

        //Sending the actual message using POST rather than GET
        [HttpPost]
        public ActionResult Contact( Email objModelMail, HttpPostedFileBase fileUploader)
        {
            //Checks to see if model is valid
            if (ModelState.IsValid)
            {
                //Address we want to send this email to
                string to = "test@jamesonricks.com";
                //create message object
                using (MailMessage mail = new MailMessage( objModelMail.From, to))
                {
                        //get subject and body the user typed
                        mail.Subject = objModelMail.Subject;
                        mail.Body = objModelMail.Body;

                    //Check to see if we're uploading a file
                    if (fileUploader != null)
                    {
                        string fileName = Path.GetFileName(fileUploader.FileName);
                        mail.Attachments.Add(new Attachment(fileUploader.InputStream, fileName));
                    }

                    //specify body type
                    mail.IsBodyHtml = false;

                    //outgoing mail settings
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "mail.jamesonricks.com";
                    smtp.EnableSsl = false;
                    NetworkCredential networkCredential = new NetworkCredential(to, "jameson4president");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = networkCredential;
                    smtp.Port = 26;
                    
                    //send the message
                    smtp.Send(mail);

                    //send the user to a confirmation page
                    ViewBag.Message = "Sent";
                    return View("Sent", objModelMail);
                }
            }
            //Don't send if there are errors
            else
            {
                return View();
            }
        }
    }
}