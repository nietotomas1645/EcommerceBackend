namespace EcommerceBackend.Models
{
    public partial class Cart
    {
        public string? Cartid { get; set; }
        public int Userid { get; set; }
        public DateTime DateCreated     { get; set; }
    }
}
