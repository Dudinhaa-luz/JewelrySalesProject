namespace JewelrySalesProject.Models
{
    public class Client
    {
        public Client(string name, string cellPhone)
        {
            Name = name;
            CellPhone = cellPhone;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
    }
}
