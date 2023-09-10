using System.ComponentModel.DataAnnotations;

namespace JewelrySalesProject.Models.Entities
{
    public class Sale
    {
        public Sale()
        {
            CalculateTotalValue();
            CalculateFinalValue();
        }

        [Key]
        public Guid Id { get; set; }
        public double TotalValue { get; private set; }
        public double FinalValue { get; private set; }
        public double PercentageDiscount { get; set; }
        public DateTime Date { get; set; }
        public Client? Client { get; set; }
        public List<Product>? Products { get; set; }
        public List<Parcel>? Parcels { get; set; }

        private void CalculateTotalValue()
        {
            if(Products != null)
            {
                foreach (var product in Products)
                    TotalValue += product.SaleValue;
            }
        }

        private void CalculateFinalValue()
        {
            FinalValue -= (FinalValue * PercentageDiscount);
        }
    }
}
