using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheReynoldsGroupSite.Data;

namespace TheReynoldsGroupSite.Pages.Coaches
{
    public class DetailsModel : PageModel
    {
        private readonly TheReynoldsGroupSite.Data.TheReynoldsGroupSiteContext _context;

        public DetailsModel(TheReynoldsGroupSite.Data.TheReynoldsGroupSiteContext context)
        {
            _context = context;
        }

        public Coach Coach { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coach = await _context.Coach.FirstOrDefaultAsync(m => m.CoachId == id);

            if (Coach == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
