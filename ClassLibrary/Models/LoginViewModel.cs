using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Models
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide a username")]
        public string? Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide a password")]
        public string? Password { get; set; }
    }
}
