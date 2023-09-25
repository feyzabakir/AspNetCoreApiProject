﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Adınız Giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre Giriniz")]
        public string Password { get; set; }
    }
}
