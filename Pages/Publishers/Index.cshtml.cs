using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Harangus_Maria_Lab9.Data;
using Harangus_Maria_Lab9.Models;

namespace Harangus_Maria_Lab9.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Harangus_Maria_Lab9.Data.Harangus_Maria_Lab9Context _context;

        public IndexModel(Harangus_Maria_Lab9.Data.Harangus_Maria_Lab9Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
