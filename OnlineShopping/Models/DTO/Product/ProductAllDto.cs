using OnlineShopping.Data.Entity;
namespace OnlineShopping.Models.DTO.Product
{
    public class ProductAllDto : Data.Entity.Product
    {
        public int IsFavorite { get; set; }
    }
}
