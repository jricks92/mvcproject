using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Email
    {
        [Required(ErrorMessage = "Please enter a subjet in the 'Subject' line.")]
        [StringLength(100,MinimumLength = 3)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter a message in the 'Body' area.")]
        public string Body { get; set; }

        [Required(ErrorMessage = "Please enter who this message is from in the 'From' line.")]
        public string From { get; set; }
    }
}