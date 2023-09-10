using JewelrySalesProject.Data;
using JewelrySalesProject.Models.Entities;
using JewelrySalesProject.Models.Repositories.Interfaces;

namespace JewelrySalesProject.Models.Repositories
{
    public class ShowcaseRepository : IShowcaseRepository
    {
        private readonly JewelrySalesContext _context;

        public ShowcaseRepository(JewelrySalesContext context)
        {
            _context = context;
        }

        public async Task AddShowcase(Showcase showcase)
        {
            await _context.Showcases.AddAsync(showcase);
        }
    }
}
