using JewelrySalesProject.Models.Entities;
using JewelrySalesProject.Models.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JewelrySalesProject.Controllers
{
    [ApiController]
    [Route("api/v1/JewelrySales/[controller]")]
    public class ShowcaseController : Controller
    {
        private readonly IShowcaseService _showcaseService;

        public ShowcaseController(IShowcaseService showcaseService)
        {
            _showcaseService = showcaseService;
        }

        [HttpPost("AddNewShowcase")]
        public async Task AddNewShowcase(Showcase showcase)
        {
            await _showcaseService.AddNewShowcase(showcase);
        }
    }
}
