using Microsoft.EntityFrameworkCore;
using MvcRuler.Models;

namespace MvcRuler.Data
{
 
        public class MvcRulerContext : DbContext
        {
            public MvcRulerContext(DbContextOptions<MvcRulerContext> options)
                : base(options)
            {
            }

            public DbSet<Ruler> Ruler { get; set; }
        }
    }

