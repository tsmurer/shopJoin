using System.ComponentModel.DataAnnotations.Schema;

namespace ShopJoin.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name {get ; set;}
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
    }
}