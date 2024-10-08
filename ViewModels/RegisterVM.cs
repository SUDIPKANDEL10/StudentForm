﻿using System.ComponentModel.DataAnnotations;

namespace StudentForm.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string? Name{ get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password{ get; set; }
        [Compare("Password",ErrorMessage ="Password don't match.")]
        [Display(Name = "Conform Password")]
        [DataType(DataType.Password)]
        public string? ConformPassword{ get; set; }

        [DataType(DataType.MultilineText)]
        public string? Address{ get; set; }
    }
}
