namespace Proiect_Dicui_Florin.Models
{
    public class Network
    {
        public int ID { get; set; }
        public string NetworkName { get; set; }
        public ICollection<Shop>? Shops { get; set; } //navigation property
    }
}