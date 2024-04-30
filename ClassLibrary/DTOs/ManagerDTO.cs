﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DTOs
{
    public class ManagerDTO
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide an email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide a username")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide a password")]
        public string Password { get; set; }
    }
}
