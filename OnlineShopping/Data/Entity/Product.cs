namespace OnlineShopping.Data.Entity
{
    public class Product : BaseEntity
    {
        public string Image { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
