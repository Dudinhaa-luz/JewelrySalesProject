using JewelrySalesProject.Models.Entities;
using JewelrySalesProject.Models.Repositories.Interfaces;
using JewelrySalesProject.Models.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JewelrySalesProject.Models.Services
{
    public class ShowcaseService : IShowcaseService
    {
        private readonly IShowcaseRepository _showcaseRepository;

        public ShowcaseService(IShowcaseRepository showcaseRepository)
        {
            _showcaseRepository = showcaseRepository;
        }

        public async Task AddNewShowcase(Showcase showcase)
        {
           await _showcaseRepository.AddShowcase(showcase);
        }
    }
}
