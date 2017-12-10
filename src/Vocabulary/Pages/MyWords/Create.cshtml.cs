using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vocabulary.Models;

namespace Vocabulary.Pages.MyWords
{
    public class CreateModel : PageModel
    {
        private readonly Vocabulary.Models.WordsDatabaseContext _context;

        public CreateModel(Vocabulary.Models.WordsDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MyWord MyWord { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MyWords.Add(MyWord);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}