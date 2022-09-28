using System.ComponentModel.DataAnnotations;

namespace EShopping_Wallet.Models
{
    public class UserType
    {
        [Key]
        public int Usertypeid { get; set; }
        public string Usertype { get; set; }
    }
}
