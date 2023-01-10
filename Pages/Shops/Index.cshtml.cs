using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Proiect_Dicui_Florin.Data;
using Proiect_Dicui_Florin.Models;

namespace Proiect_Dicui_Florin.Pages.Shops
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Dicui_Florin.Data.Proiect_Dicui_FlorinContext _context;

        public IndexModel(Proiect_Dicui_Florin.Data.Proiect_Dicui_FlorinContext context)
        {
            _context = context;
        }

        public IList<Shop> Shop { get;set; } = default!;
        public string ShopNameSort { get; set; }
        public string DirectorSort { get; set; }
        public string CurrentFilter { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            if (_context.Shop != null)

            ShopNameSort = String.IsNullOrEmpty(sortOrder) ? "shopname_desc" : "";
            DirectorSort = String.IsNullOrEmpty(sortOrder) ? "director_desc" : "";

            {
                Shop = await _context.Shop
                    .Include(b => b.Network)
                    .ToListAsync();
            }
        }
    }
}
