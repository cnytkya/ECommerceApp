using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.EntityLayer.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public string Role { get; set; }
    }
}