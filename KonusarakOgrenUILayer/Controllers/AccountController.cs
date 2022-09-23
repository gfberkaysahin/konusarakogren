using AspNetCoreHero.ToastNotification.Abstractions;
using EntityLayer;
using KonusarakOgrenUILayer.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project.Models.LoginViewModel;

namespace KonusarakOgrenUILayer.Controllers;

[AllowAnonymous]
public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly INotyfService _notyf;
    
    public AccountController(UserManager<ApplicationUser> userManager, INotyfService notyf,SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _notyf = notyf;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Index(LoginViewModel userData)
    {
        var result = await _signInManager.PasswordSignInAsync(userData.Email, userData.Password, true, lockoutOnFailure: false);
        if (result.Succeeded)
        {
            var loggedUser = await _userManager.FindByEmailAsync(userData.Email);
            var userRole = await _userManager.GetRolesAsync(loggedUser);
            if(userRole[0]=="sysadmin")
            {
                _notyf.Success("Giriş başarılı");
                return RedirectToAction("ProductList", "SysAdmin");
            }
            if(userRole[0]=="customer")
            {
                _notyf.Success("Giriş başarılı");
                return RedirectToAction("ProductList", "Customer");
            }
            if(userRole[0]=="admin")
            {
                _notyf.Success("Giriş başarılı");
                return RedirectToAction("ProductList", "Admin");
            }
            else
            {
                _notyf.Error("Kullanıcının rolü tanımlanmamıştır, lütfen yönetici ile görüşünüz");
            }
        }
        _notyf.Error("Giriş başarısız.");
        return View();
    }
    
    [HttpGet]
    public IActionResult Register()
    {
        List<Role> RoleList = new List<Role>();
        UserSignupViewModel userSignupViewModel = new UserSignupViewModel();
        RoleList.Add(new Role
        {
            RoleName = "customer",
        });
        RoleList.Add(new Role
        {
            RoleName = "admin",
        });
        userSignupViewModel.RoleList = RoleList;
        return View(userSignupViewModel);
    }
    
    [HttpPost]
    public async Task<IActionResult> Register(UserSignupViewModel userData)
    {
        if (ModelState.IsValid)
        {
            ApplicationUser user = new ApplicationUser()
            {
                Email = userData.Mail,
                NameSurname = userData.NameSurname,
                UserName = userData.Mail,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, userData.Password);

            if (result.Succeeded)
            {
                var roleResult = await _userManager.AddToRoleAsync(user, userData.Role);
                if (roleResult.Succeeded)
                {
                   _notyf.Success("Kullanıcı Kaydı başarılı");
                   return RedirectToAction("Index");
                }
                
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }
            }
        }
        _notyf.Error("Kayıt olurken bir hata oluştu.");
        List<Role> RoleList = new List<Role>();
        Role adminRole = new Role();
        Role customerRole = new Role();
        customerRole.RoleName = "customer";
        adminRole.RoleName = "admin";
        RoleList.Add(customerRole);
        RoleList.Add(adminRole);
        userData.RoleList = RoleList;

        return View(userData);
    }
    
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        _notyf.Success("Başarıyla çıkış yaptınız");
        return RedirectToAction("Index","Account");
    }
    
    public IActionResult AccesDenied()
    {
        return View();
    }
    
}