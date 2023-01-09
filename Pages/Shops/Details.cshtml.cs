using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Dicui_Florin.Data;
using Proiect_Dicui_Florin.Models;

namespace Proiect_Dicui_Florin.Pages.Shops
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Dicui_Florin.Data.Proiect_Dicui_FlorinContext _context;

        public DetailsModel(Proiect_Dicui_Florin.Data.Proiect_Dicui_FlorinContext context)
        {
            _context = context;
        }

      public Shop Shop { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Shop == null)
            {
                return NotFound();
            }

            var shop = await _context.Shop.FirstOrDefaultAsync(m => m.ID == id);
            if (shop == null)
            {
                return NotFound();
            }
            else 
            {
                Shop = shop;
            }
            return Page();
        }
    }
}
