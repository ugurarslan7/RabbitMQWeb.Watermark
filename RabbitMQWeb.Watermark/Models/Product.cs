using System.ComponentModel.DataAnnotations;

namespace RabbitMQWeb.Watermark.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(0, 50)]
        public decimal Price { get; set; }

        [Range(0, 50)]
        public int Stock { get; set; }

        [StringLength(50)]
        public string? ImageName { get; set; }
    }
}
