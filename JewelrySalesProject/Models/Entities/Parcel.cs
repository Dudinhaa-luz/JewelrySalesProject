using JewelrySalesProject.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace JewelrySalesProject.Models.Entities
{
    public class Parcel
    {
        [Key]
        public Guid Id { get; set; }
        public PaymentFormEnum PaymentForm { get; set; }
        public DateTime PrevisionDatePayment { get; set; }
        public bool IsPaid { get; set; }
        public Client? Client { get; set; }
    }
}
