using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Models
{
    public class Users
    {
        [Required(ErrorMessage = "Please Enter your username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter your Password")]
        public string Password { get; set; }
    }
}