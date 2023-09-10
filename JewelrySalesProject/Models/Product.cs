using JewelrySalesProject.Models.Enums;

namespace JewelrySalesProject.Models
{
    public class Product
    {
        public Product(string code, string description)
        {
            Code = code;
            Description = description;
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public JewelryTypeEnum ProductType { get; set; }
        public double SaleValue { get; set; }
    }
}
