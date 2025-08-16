using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels;

public record SignUpViewModel(string UserName, string Email, string Phone, string Password, string PasswordConfirm);