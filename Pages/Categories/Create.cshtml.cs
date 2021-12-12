using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Harangus_Maria_Lab9.Data;
using Harangus_Maria_Lab9.Models;

namespace Harangus_Maria_Lab9.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Harangus_Maria_Lab9.Data.Harangus_Maria_Lab9Context _context;

        public CreateModel(Harangus_Maria_Lab9.Data.Harangus_Maria_Lab9Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
