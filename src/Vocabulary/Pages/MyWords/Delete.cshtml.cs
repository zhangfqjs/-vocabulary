using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vocabulary.Models;

namespace Vocabulary.Pages.MyWords
{
    public class DeleteModel : PageModel
    {
        private readonly Vocabulary.Models.WordsDatabaseContext _context;

        public DeleteModel(Vocabulary.Models.WordsDatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MyWord MyWord { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyWord = await _context.MyWords.SingleOrDefaultAsync(m => m.Id == id);

            if (MyWord == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyWord = await _context.MyWords.FindAsync(id);

            if (MyWord != null)
            {
                _context.MyWords.Remove(MyWord);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
