using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using Blog.Data;
namespace Blog.Pages
{

    [Authorize]
    public class ArticleAddModel : PageModel
    {
        private BlogDbContext db;

        private readonly ILogger<RegisterModel> logger;
        public ArticleAddModel(BlogDbContext db, ILogger<RegisterModel> logger)
        {
            this.db = db;
            this.logger = logger;
        }

        [BindProperty, Required, MinLength(1), MaxLength(200), Display(Name = "Title")]
        public string Title { get; set; }

        [BindProperty, Required, MinLength(1), MaxLength(2000), Display(Name = "Content")]

        public string Body { get; set; }

        public async Task<IActionResult> OnPostAsync() 
        {
            if (ModelState.IsValid)
            {
                var userName = User.Identity.Name; //userName is email
                var user = db.Users.Where(u => u.UserName == userName).FirstOrDefault(); //find user record
                var newArticle = new Blog.Models.Article { Title = Title, Body = Body, Author = user, Created = DateTime.Now };

                db.Add(newArticle);
                await db.SaveChangesAsync();

                return RedirectToPage("ArticleAddSuccess");
            }
            return Page();
        }


    }
}
