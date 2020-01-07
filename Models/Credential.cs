using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bogoodski2020backend.Models
{
    public class Credential
    {
        public Credential() { }
        public int Id { get; set; }

        [Required(ErrorMessage = "User Name is Required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required.")]
        public string PassWord { get; set; }
    }
}
