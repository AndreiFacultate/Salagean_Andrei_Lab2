using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Salagean_Andrei_Lab2.Data;
using Salagean_Andrei_Lab2.Models;
using Microsoft.AspNetCore.Authorization;


namespace Salagean_Andrei_Lab2.Pages.Publishers
{
    [Authorize(Roles = "Admin")]
    public class DetailsModel : PageModel
    {
        private readonly Salagean_Andrei_Lab2.Data.Salagean_Andrei_Lab2Context _context;

        public DetailsModel(Salagean_Andrei_Lab2.Data.Salagean_Andrei_Lab2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
