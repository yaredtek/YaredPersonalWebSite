using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;

namespace YaredPersonalWebSite.Models
{
    public class MailModel
    {

        public  string Subject { get; set; }

        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [Email(ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required]
        public  string Message { get; set; }

 
    }
}