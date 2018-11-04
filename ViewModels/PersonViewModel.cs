using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LocalizationDemo.ViewModels
{
    public class PersonViewModel
    {
        [Display(Name="Name")]
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name="Height")]
        [Range(1, 180)]
        public int Height { get; set; }
        
        [Display(Name="Code")]
        [RegularExpression("^[0-9]{5}$")]
        public string Code { get; set;  }
        
        [Display(Name="Birthdate")]
        public DateTime Birthdate { get; set; }

        [Display(Name="Blog")]
        [Url]
        public string BlogUrl { get; set; }

        [Display(Name="Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name="Phone")]
        [Phone]
        public string Phone { get; set; }

        [Display(Name="CreditCard")]
        [CreditCard]
        public string CreditCard{ get; set; }

        [Display(Name="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name="Repassword")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }

    }
}
