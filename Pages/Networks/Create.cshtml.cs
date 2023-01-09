using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Dicui_Florin.Data;
using Proiect_Dicui_Florin.Models;

namespace Proiect_Dicui_Florin.Pages.Networks
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Dicui_Florin.Data.Proiect_Dicui_FlorinContext _context;

        public CreateModel(Proiect_Dicui_Florin.Data.Proiect_Dicui_FlorinContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Network Network { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Network.Add(Network);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
