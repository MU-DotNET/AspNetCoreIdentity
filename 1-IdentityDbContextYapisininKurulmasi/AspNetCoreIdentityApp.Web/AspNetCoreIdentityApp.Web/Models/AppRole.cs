using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentityApp.Web.Models;

public sealed class AppRole : IdentityRole
{
    public string City { get; set; }
}