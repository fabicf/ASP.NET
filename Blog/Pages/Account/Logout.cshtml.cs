using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Blog.Pages
{
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ILogger<RegisterModel> logger;

        public LogoutModel(SignInManager<IdentityUser> signInManager, ILogger<RegisterModel> logger)
        {
            this.signInManager = signInManager;
            this.logger = logger;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            // TODO: log user information if user was logged in
            // if (signInManager.IsSignedIn(User))
            // {
            //     logger.LogInformation($"User {User.Identity.Name} logged out");
            // }
            // FIX ME: This page render as if user was still logged in

            await signInManager.SignOutAsync();
            return Page();
        }
    }
}
