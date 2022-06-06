using CafeOrder.Modals;

namespace CafeOrder.Interfaces
{
    public interface IFoodRepository
    {
        Task<Food> GetFoodById(int id);
        Task<List<Food>> GetFoods();
        Task<List<FoodCategory>> GetFoodCategory();
        Task<List<FoodRegion>> GetFoodRegion();
    }
}
