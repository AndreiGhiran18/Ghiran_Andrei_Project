using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ghiran_Andrei_Project.Models
{
    public class Game
    {
        public int ID { get; set; }
        [Display(Name = "Game Title")]
        public string Title { get; set; }
        public int? DeveloperID { get; set; }
        public Developer? Developer { get; set; }
        public string Genre { get; set; }
        public int? PlatformID { get; set; }
        public Platform? Platform { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        [Display(Name = "Purchase Date")]
        [DataType (DataType.Date)]
        public DateTime PurchaseDate { get; set; }

    }
}
