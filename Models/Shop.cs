using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Proiect_Dicui_Florin.Models
{
    public class Shop
    {
        public int ID { get; set; }
        public string ShopName { get; set; }
        public string Director { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Sales { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int? NetworkID { get; set; }
        public Network? Network { get; set; }//navigation property
    } 
}