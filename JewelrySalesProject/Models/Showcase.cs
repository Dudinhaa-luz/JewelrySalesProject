namespace JewelrySalesProject.Models
{
    public class Showcase
    {
        public Showcase(string code)
        {
            Code = code;
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }
        public double TotalSaleValue { get; set; }
        public double CommissionPercentage { get; set; }
        public double TotalProfit { get; set; }
        public double TotalCost { get; set; }
        public List<Sale>? Sales { get; set; }
    }
}
