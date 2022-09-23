using System.ComponentModel.DataAnnotations;

namespace KonusarakOgrenUILayer.Models;

public class UserSignupViewModel
{
    public List<Role>? RoleList { get; set; }
    
    [Display(Name="Ad Soyad")]
    [Required(ErrorMessage = "Lütfen ad soyad giriniz")]
    public string NameSurname { get; set; }
    
    [Display(Name="Şifre")]
    [Required(ErrorMessage = "Lütfen Şifre giriniz")]
    public string Password { get; set; }
    
    [Display(Name="Şifre tekrar")]
    [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
    public string ConfirmPassword { get; set; }
    
    [Display(Name="Mail Adresi")]
    [Required(ErrorMessage = "Lütfen mail giriniz")]
    public string Mail { get; set; }

    [Display(Name = "Rol")]
    [Required(ErrorMessage = "Lütfen rol giriniz")]
    public string Role { get; set; }
    
   
}

public class Role
{
    public string RoleName { get; set; }
}