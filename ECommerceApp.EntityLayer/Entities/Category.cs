using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.EntityLayer.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }

        [DisplayName("Kategori Numarası")]
        [Range(1, 100, ErrorMessage = "Kategori numarası 0-100 arasında bir sayı olacak.")] // bu nitelik CategoryNumber ın 1 ile 100 arasında bir sayı olduğunu belirtir. Aksi takdirde hata mesajı verir.
        public int CategoryNumber { get; set; }
    }
}