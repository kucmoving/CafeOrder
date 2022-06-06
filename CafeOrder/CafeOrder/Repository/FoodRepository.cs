using CafeOrder.Data;
using CafeOrder.Interfaces;
using CafeOrder.Modals;
using Microsoft.EntityFrameworkCore;

namespace CafeOrder.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private readonly DataContext _dataContext;

        public FoodRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Food> GetFoodById(int id)
        {
            return await _dataContext.Foods
                .Include(f => f.FoodCategory)
                .Include(f => f.FoodRegion)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<List<Food>> GetFoods()
        {
            return await _dataContext.Foods
                .Include(f => f.FoodCategory)
                .Include(f => f.FoodRegion)
                .ToListAsync();
        }
        public async Task<List<FoodCategory>> GetFoodCategory()
        {
            return await _dataContext.FoodCategories.ToListAsync();
        }

        public async Task<List<FoodRegion>> GetFoodRegion()
        {
            return await _dataContext.FoodRegions.ToListAsync();
        }
    }
}
