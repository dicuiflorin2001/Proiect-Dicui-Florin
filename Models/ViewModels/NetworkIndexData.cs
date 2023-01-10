using Proiect_Dicui_Florin.Models;
using System.Security.Policy;

namespace Proiect_Dicui_Florin.Models.ViewModels
{
    public class NetworkIndexData
    {
        public IEnumerable<Network> Networks { get; set; }
        public IEnumerable<Shop> Shops { get; set; }
    }
}
