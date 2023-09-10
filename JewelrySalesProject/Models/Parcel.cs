using JewelrySalesProject.Models.Enums;

namespace JewelrySalesProject.Models
{
    public class Parcel
    {
        public Guid Id { get; set; }
        public PaymentFormEnum PaymentForm { get; set; }
        public DateTime PrevisionDatePayment { get; set; }
        public bool IsPaid { get; set; }
        public Client Client { get; set; }
    }
}
