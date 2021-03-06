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
    public class IndexModel : PageModel
    {
        private readonly TheReynoldsGroupSite.Data.TheReynoldsGroupSiteContext _context;

        public IndexModel(TheReynoldsGroupSite.Data.TheReynoldsGroupSiteContext context)
        {
            _context = context;
        }

        public IList<Coach> Coach { get;set; }

        public async Task OnGetAsync()
        {
            Coach = await _context.Coach.ToListAsync();
        }
    }
}
