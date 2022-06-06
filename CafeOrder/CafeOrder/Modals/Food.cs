using System.ComponentModel.DataAnnotations.Schema;

namespace CafeOrder.Modals
{
    public class Food : BaseModel
    {
        public string Name { get; set; }
        public string? Introduction  { get; set; }
        public int? Rating { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public string? ImgUrl { get; set; }
        public FoodCategory? FoodCategory { get; set; }
        public int? FoodCategoryId { get; set; }
        public FoodRegion? FoodRegion { get; set; }
        public int? FoodRegionId { get; set; }
    }
}
