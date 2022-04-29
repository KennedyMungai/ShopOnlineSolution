namespace ShopOnline.Api.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }

        //This represents a foreign key. The relationship is with the Cart class
        public int CartId { get; set; }
    }
}
