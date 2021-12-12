using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Invoice_System.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Please input user name.")]
        public string User_Name { set; get; }

        [Required(ErrorMessage ="Please input password.")]
        public string User_Password { set; get; }
    }
}