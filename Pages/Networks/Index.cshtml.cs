using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Dicui_Florin.Data;
using Proiect_Dicui_Florin.Models;
using Proiect_Dicui_Florin.Models.ViewModels;

namespace Proiect_Dicui_Florin.Pages.Networks
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Dicui_Florin.Data.Proiect_Dicui_FlorinContext _context;

        public IndexModel(Proiect_Dicui_Florin.Data.Proiect_Dicui_FlorinContext context)
        {
            _context = context;
        }

        public IList<Network> Network { get; set; } = default!;

        public NetworkIndexData NetworkData { get; set; }
        public int NetworkID { get; set; }
        public int ShopID { get; set; }
        public async Task OnGetAsync(int? id, int? shopID)
        {
            NetworkData = new NetworkIndexData();
            NetworkData.Networks = await _context.Network
            .Include(i => i.Shops)
            .OrderBy(i => i.NetworkName)
            .ToListAsync();
            if (id != null)
            {
                NetworkID = id.Value;
                Network publisher = NetworkData.Networks
                .Where(i => i.ID == id.Value).Single();
                NetworkData.Shops = publisher.Shops;
            }
        }
    }
}
