using System.ComponentModel.DataAnnotations;

namespace JewelrySalesProject.Models.Entities
{
    public class Client
    {
        public Client(string name, string cellPhone)
        {
            Name = name;
            CellPhone = cellPhone;
        }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
    }
}
