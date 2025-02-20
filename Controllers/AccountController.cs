using Microsoft.AspNetCore.Mvc;
using MetalUniverse.Models;
using MetalUniverse.Data;

public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Създаваме нов потребител
                var user = new User
                {
                    Username = model.Username,
                    Email = model.Email,
                    RegistrationDate = DateTime.Now,
                    PasswordHash = HashPassword(model.Password), // Ръчно хеширане
                    Role = "client"
                };

                // Добавяме потребителя в базата данни
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                // Пренасочваме към началната страница
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        private string HashPassword(string password)
        {
            // Ръчно хеширане на паролата (за простота)
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }


/*
    // Логин страница
    public IActionResult Login()
        {
            return View();
        }

        // Логин логика
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Username);
                if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, "Невалидни данни за вход.");
            }
            return View(model);
        }

        // Изход
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}*/

