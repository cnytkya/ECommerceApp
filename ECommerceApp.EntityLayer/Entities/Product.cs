using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.EntityLayer.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name = "1-50 Adet Fiyatı")]
        [Range(1, 1000)]
        public double Price { get; set; }

        [Display(Name = "50+ Adet Fiyatı"), Required, Range(1, 1000)]
        public double Price50 { get; set; } // Ürünün 50 adetten fazla satıldığında uygulanan fiyatı temsil ediyor.

        [Display(Name = "100+ Adet Fiyatı"), Required, Range(1, 1000)]
        public double Price100 { get; set; } // Ürünün 100 adetten fazla satıldığında uygulanan fiyatı temsil ediyor.

        [Display(Name = "Liste Fiyatı"), Required]
        public double ListPrice { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<ProductImage> ProductImages { get; set; }
    }
}