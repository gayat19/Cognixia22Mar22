using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShoppingGatewayAPI.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public byte[] PassKey { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        [ForeignKey("Location")]
        public ShipLocation ShipLocation { get; set; }
    }
}
