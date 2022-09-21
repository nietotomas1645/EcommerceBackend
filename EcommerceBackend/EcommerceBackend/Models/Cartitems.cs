namespace EcommerceBackend.Models
{
    public partial class Cartitems
    {
        public int CartItemId   { get; set; }
        public string? Cartid    { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }



    }
}
