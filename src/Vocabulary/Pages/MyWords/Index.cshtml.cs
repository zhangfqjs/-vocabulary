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
    public class IndexModel : PageModel
    {
        private readonly Vocabulary.Models.WordsDatabaseContext _context;

        public IndexModel(Vocabulary.Models.WordsDatabaseContext context)
        {
            _context = context;
        }

        public IList<MyWord> MyWord { get;set; }

        public async Task OnGetAsync()
        {
            MyWord = await _context.MyWords.ToListAsync();
        }
    }
}
