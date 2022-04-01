using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShoppingGatewayAPI.Models
{
    public class ShipLocation
    {
        [Key]
        public string Location { get; set; }
        public int ProductId { get; set; }
        public int ShipDuration { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
