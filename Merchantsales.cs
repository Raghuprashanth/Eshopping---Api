using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShopping_Wallet.Models
{
    public class Marchent
    {
        [Key]
        public int Salesid { get; set; }   
        public float salestotalEarning { get; set; }
        public int? Userid { get; set; }
        [ForeignKey("Userid")]
        public User? User { get; set; }

    }
}
