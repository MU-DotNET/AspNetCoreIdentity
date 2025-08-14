using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentityApp.Web.Models;

public sealed class AppUser : IdentityUser
{
    public string City { get; set; }
}