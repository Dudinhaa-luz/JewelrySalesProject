namespace JewelrySalesProject.Models
{
    public class Sale
    {
        public Guid Id { get; set; }
        public double TotalValue { get; set; }
        public double Discount { get; set; }
        public DateTime Date { get; set; }
        public Client Client { get; set; }
        public List<Product> Products { get; set; }
        public List<Parcel> Parcels { get; set; }
    }
}
