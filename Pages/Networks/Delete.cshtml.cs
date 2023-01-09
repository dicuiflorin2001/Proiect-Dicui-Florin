using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Dicui_Florin.Data;
using Proiect_Dicui_Florin.Models;

namespace Proiect_Dicui_Florin.Pages.Networks
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Dicui_Florin.Data.Proiect_Dicui_FlorinContext _context;

        public DeleteModel(Proiect_Dicui_Florin.Data.Proiect_Dicui_FlorinContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Network Network { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Network == null)
            {
                return NotFound();
            }

            var network = await _context.Network.FirstOrDefaultAsync(m => m.ID == id);

            if (network == null)
            {
                return NotFound();
            }
            else 
            {
                Network = network;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Network == null)
            {
                return NotFound();
            }
            var network = await _context.Network.FindAsync(id);

            if (network != null)
            {
                Network = network;
                _context.Network.Remove(Network);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
