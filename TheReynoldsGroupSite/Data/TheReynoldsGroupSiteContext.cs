using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheReynoldsGroupSite.Data;

namespace TheReynoldsGroupSite.Data
{
    public class TheReynoldsGroupSiteContext : DbContext
    {
        public TheReynoldsGroupSiteContext (DbContextOptions<TheReynoldsGroupSiteContext> options)
            : base(options)
        {
        }

        public DbSet<TheReynoldsGroupSite.Data.Coach> Coach { get; set; }

        public DbSet<TheReynoldsGroupSite.Data.Client> Client { get; set; }

        public DbSet<TheReynoldsGroupSite.Data.Question> Question { get; set; }

        public DbSet<TheReynoldsGroupSite.Data.Category> Category { get; set; }
    }
}
