using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using DirectList__Backend_Project_.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccountController(AppDbContext appDbContext,SignInManager<IdentityUser> signInManager ,UserManager<IdentityUser> userManager,IWebHostEnvironment webHostEnvironment)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(VmRegister vmRegister)
        {
            if (ModelState.IsValid)
            {
                if (vmRegister.ImageFile != null)
                {
                    string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + vmRegister.ImageFile.FileName;
                    string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        vmRegister.ImageFile.CopyTo(stream);
                    }
                    CustomUser newUser = new CustomUser()
                    {
                        FullName = vmRegister.Name + " "+vmRegister.SurName,
                        Text = vmRegister.Text,
                        CreatedDate = DateTime.Now,
                        Email = vmRegister.Email,
                        UserName = vmRegister.Email,
                        Image = fileName
                    };

                    var result = await _userManager.CreateAsync(newUser, vmRegister.Password);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(newUser, false);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                        return View(vmRegister);
                    }
                }

            }
            return View(vmRegister);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(VmRegister vmRegister)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(vmRegister.Email)|| !string.IsNullOrEmpty(vmRegister.Password))
                {
                    var result = await _signInManager.PasswordSignInAsync(vmRegister.Email, vmRegister.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Username or password is not correct");
                        return View(vmRegister);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Please , fill in the blanks");
                    return View(vmRegister);
                }
                
            }

            return View(vmRegister);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        public IActionResult Users()
        {
            List<CustomUser> model = _appDbContext.CustomUsers.ToList();

            return View(model);
        }
        public IActionResult UpdateUser(string id)
        {
            CustomUser user= _appDbContext.CustomUsers.Find(id);

            return View(user);
        }
        [HttpPost]
        public IActionResult UpdateUser(CustomUser user)
        {
            if (ModelState.IsValid)
            {
                CustomUser user1 = _appDbContext.CustomUsers.Find(user.Id);

                user1.FullName = user.FullName;
                user1.Text = user.Text;

                _appDbContext.SaveChanges();
                return RedirectToAction("Users");
            }
            return View(user);
        }
    }
}
