﻿using System.ComponentModel.DataAnnotations;

namespace _2.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Password must be at least {2} characters long.", MinimumLength = 6)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }
    }
}



