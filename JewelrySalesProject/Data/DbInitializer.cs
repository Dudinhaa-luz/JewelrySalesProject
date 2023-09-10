using System.Diagnostics;

namespace JewelrySalesProject.Data
{
    public static class DbInitializer
    {
        public static void Initialize(JewelrySalesContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
