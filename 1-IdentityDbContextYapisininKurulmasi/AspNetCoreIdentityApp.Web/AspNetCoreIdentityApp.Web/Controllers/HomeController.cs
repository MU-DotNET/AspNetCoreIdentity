using System.Diagnostics;
using AspNetCoreIdentityApp.Web.Mappers;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreIdentityApp.Web.Models;
using AspNetCoreIdentityApp.Web.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentityApp.Web.Controllers;

public class HomeController(ILogger<HomeController> _logger,UserManager<AppUser> _userManager, AppUserMapper _mapper) : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult SignUp()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> SignUp(SignUpViewModel request)
    {
        var identityResult = await _userManager.CreateAsync(_mapper.SignUpViewModelToAppUser(request), request.PasswordConfirm);
        if (identityResult.Succeeded)
        {
          TempData["SuccessMessage"] = "Your account has been created successfully!";
          return RedirectToAction(nameof(HomeController.SignUp));
        }

        foreach (IdentityError error in identityResult.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}