namespace ShopOnline.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

        //Represents a foreign key from the products category entity
        public int CategoryId { get; set; }
    }
}
