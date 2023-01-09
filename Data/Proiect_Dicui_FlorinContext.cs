using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Dicui_Florin.Models;

namespace Proiect_Dicui_Florin.Data
{
    public class Proiect_Dicui_FlorinContext : DbContext
    {
        public Proiect_Dicui_FlorinContext (DbContextOptions<Proiect_Dicui_FlorinContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Dicui_Florin.Models.Shop> Shop { get; set; } = default!;

        public DbSet<Proiect_Dicui_Florin.Models.Network> Network { get; set; }
    }
}
