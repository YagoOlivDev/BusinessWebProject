using ProjectWeb.Models.Enums;

namespace ProjectWeb.Models
{
    public class SalesRecord
    {
        public int Id { get; protected set; }
        public DateTime Date { get; protected set; }
        public double Amount { get; protected set; }
        public SaleStatus Status { get; protected set; }
        public Seller Seller { get;  protected set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
