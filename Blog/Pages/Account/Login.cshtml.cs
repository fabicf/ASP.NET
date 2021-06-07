using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Blog.Pages
{
    public class LoginModel : PageModel
    {

        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ILogger<RegisterModel> logger;

        public LoginModel(SignInManager<IdentityUser> signInManager, ILogger<RegisterModel> logger) {
            this.signInManager = signInManager;
            this.logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public async Task<IActionResult> OnPostAsync() {
            if (ModelState.IsValid)
            {
                
                var result = await signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, true);
                if (result.Succeeded) {
                    logger.LogInformation($"User {Input.Email} logged in");
                    return RedirectToPage("LoginSuccess");
                } else { // user does not exist, password invalid, account locked out
                    ModelState.AddModelError(string.Empty, "Login failed (user does not exist, password invalid, or account locked out)");
                }
            }
            return Page();
        }

        public void OnGet()
        {
        }
    }
}
