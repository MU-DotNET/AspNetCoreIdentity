using AspNetCoreIdentityApp.Web.Models;
using AspNetCoreIdentityApp.Web.ViewModels;
using Riok.Mapperly.Abstractions;

namespace AspNetCoreIdentityApp.Web.Mappers;

[Mapper]
public partial class AppUserMapper
{
    public partial AppUser SignUpViewModelToAppUser(SignUpViewModel model);
}