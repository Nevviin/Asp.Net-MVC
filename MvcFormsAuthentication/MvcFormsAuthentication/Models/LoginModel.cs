using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcFormsAuthentication.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage="UserName Required",AllowEmptyStrings=false)]
        public string UserName { get; set; }

        [Required(ErrorMessage="Password Required", AllowEmptyStrings=false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    
    }

    

}