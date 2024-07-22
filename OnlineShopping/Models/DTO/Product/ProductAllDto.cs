using OnlineShopping.Data.Entity;
namespace OnlineShopping.Models.DTO.Product
{
    public class ProductAllDto : Data.Entity.Product
    {
        public bool IsFavorite { get; set; }
    }
}
