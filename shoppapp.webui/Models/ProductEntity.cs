using System.ComponentModel.DataAnnotations;

namespace shoppapp.webui.Models
{
    public class ProductEntity
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60,MinimumLength=10,ErrorMessage="Ürün ismi 10-60 karakter aralığında olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage="Fiyat girmelisiniz.")]
        [Range(1,100000)]
        public double? Price { get; set; }
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        [Required]
        public int? CategoryId { get; set; }
    }
}