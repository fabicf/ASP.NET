using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Blog.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ILogger<RegisterModel> logger;

        [BindProperty]
        public InputModel Input { get; set; }

        public RegisterModel(UserManager<IdentityUser> userManager,
            ILogger<RegisterModel> logger) {
            this.userManager = userManager;
            this.logger = logger;
        }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync() {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded) {
                    logger.LogInformation($"User {Input.Email} create a new account with password");
                    return RedirectToPage("RegisterSuccess", new { email = Input.Email });
                }
                foreach (var error in result.Errors) {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Page();
        }

    }
}
