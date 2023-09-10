using JewelrySalesProject.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace JewelrySalesProject.Models.Entities
{
    public class Product
    {
        public Product(string code, string description)
        {
            Code = code;
            Description = description;
        }

        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public JewelryTypeEnum ProductType { get; set; }
        public double SaleValue { get; set; }
    }
}
