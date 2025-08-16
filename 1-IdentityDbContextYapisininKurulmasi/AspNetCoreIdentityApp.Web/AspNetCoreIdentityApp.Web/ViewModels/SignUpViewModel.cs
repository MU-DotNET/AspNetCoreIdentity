using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels;

public sealed class SignUpViewModel(string userName, string email, string phone, string password)
{
    [Display(Name = "Kullanıcı Adı : ")]
    public string UserName { get; set; } = userName;
    
    [Display(Name = "Email : ")]
    public string Email { get; set; } = email;
    
    [Display(Name = "Telefon : ")]
    public string Phone { get; set; } = phone;
    
    [Display(Name = "Şifre : ")]
    public string Password { get; set; } = password;
    
    [Display(Name = "Şifre Tekrar : ")]
    public string PasswordConfirm { get; set; } = password;
}