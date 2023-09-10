using JewelrySalesProject.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace JewelrySalesProject.Models.Services.Interfaces
{
    public interface IShowcaseService
    {
        Task AddNewShowcase(Showcase showcase);
    }
}
