namespace netlab11.Models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }

        public Producto Producto  { get; set; }
        public int ProductoID { get; set; }
        public Invoice Invoice { get; set; }
        public int InvoiceID { get; set; }
    }
}
