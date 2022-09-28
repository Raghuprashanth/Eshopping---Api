using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShopping_Wallet.Models
{
    public class Ewallet
    {
        [Key]
        public int ewalletid { get; set; }
        public float ewalletbalance { get; set; }
        public int? Userid { get; set; }
        [ForeignKey("Userid")]
        public User? User { get; set; }
    }
}
