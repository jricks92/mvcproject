using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Email
    {
        //Make sure the field is not blank and that it's a valid email address
        [Required(ErrorMessage = "Please enter your email address so we can reply to your message.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string From { get; set; }

        //Require a subject
        [Required(ErrorMessage = "Please enter a subject in the 'Subject' line.")]
        [StringLength(100,MinimumLength = 3)]
        public string Subject { get; set; }

        //Require an actual message
        [Required(ErrorMessage = "Please enter a message in the 'Message' area.")]
        public string Body { get; set; }
    }
}