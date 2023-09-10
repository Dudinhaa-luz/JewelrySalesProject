using JewelrySalesProject.Models.Entities;

namespace JewelrySalesProject.Models.Repositories.Interfaces
{
    public interface IShowcaseRepository
    {
        Task AddShowcase(Showcase showcase);
    }
}
