using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Harangus_Maria_Lab9.Data;
using Harangus_Maria_Lab9.Models;

namespace Harangus_Maria_Lab9.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Harangus_Maria_Lab9.Data.Harangus_Maria_Lab9Context _context;

        public DetailsModel(Harangus_Maria_Lab9.Data.Harangus_Maria_Lab9Context context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
