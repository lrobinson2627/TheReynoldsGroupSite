﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TheReynoldsGroupSite.Data;

namespace TheReynoldsGroupSite.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly TheReynoldsGroupSite.Data.TheReynoldsGroupSiteContext _context;

        public DetailsModel(TheReynoldsGroupSite.Data.TheReynoldsGroupSiteContext context)
        {
            _context = context;
        }

        public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FirstOrDefaultAsync(m => m.ClientId == id);

            if (Client == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
