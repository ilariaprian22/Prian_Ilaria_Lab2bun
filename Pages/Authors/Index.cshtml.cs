using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prian_Ilaria_Lab2.Data;
using Prian_Ilaria_Lab2.Models;

namespace Prian_Ilaria_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Prian_Ilaria_Lab2.Data.Prian_Ilaria_Lab2Context _context;

        public IndexModel(Prian_Ilaria_Lab2.Data.Prian_Ilaria_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
