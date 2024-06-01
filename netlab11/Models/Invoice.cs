namespace netlab11.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceName { get; set; }
        public decimal Total { get; set; }

        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
    }
}
