using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.EntityLayer.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}