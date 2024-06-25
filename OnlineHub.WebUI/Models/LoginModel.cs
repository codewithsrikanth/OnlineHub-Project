﻿using System.ComponentModel.DataAnnotations;

namespace OnlineHub.WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Please Enter Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Please Enter Password")]
        public string Password { get; set; }
    }
}
