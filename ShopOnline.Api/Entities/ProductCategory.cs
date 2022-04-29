namespace ShopOnline.Api.Entities
{
    //Has a one to any relationship with the product entity (The product class)
    public class ProductCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
