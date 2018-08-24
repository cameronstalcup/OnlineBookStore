namespace OnlineBookStore.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }

        public Book Book { get; set; }
        public Order Order { get; set; }
    }
}