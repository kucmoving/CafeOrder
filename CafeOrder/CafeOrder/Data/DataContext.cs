using CafeOrder.Modals;
using Microsoft.EntityFrameworkCore;

namespace CafeOrder.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Food> Foods { get; set; }

        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<FoodRegion> FoodRegions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Food>().HasData(
                            new Food
                            {
                                Id = 1,
                                Name = "Green Tea",
                                Introduction = "Green tea is a type of tea that is made from Camellia sinensis leaves and buds that have not undergone the same withering.",
                                Rating = 3,
                                Price = (decimal?)1.5,
                                ImgUrl="#",
                                FoodCategoryId=1,
                                FoodRegionId=1,
                            },
                            new Food
                            {
                                Id = 2,
                                Name = "Ramune",
                                Introduction = "Ramune is a Japanese carbonated soft drink. It was introduced in 1884 in Kobe by the British pharmacist Alexander Cameron Sim. ",
                                Rating = 4,
                                Price = (decimal?)1.6,
                                ImgUrl = "#",
                                FoodCategoryId = 1,
                                FoodRegionId = 1,
                            },
                            new Food
                            {
                                Id = 3,
                                Name = "Taiyaki",
                                Introduction = "Taiyaki is a Japanese fish-shaped cake, commonly sold as street food. The most common filling is red bean paste that is made from sweetened adzuki beans.",
                                Rating = 4,
                                Price = (decimal?)1.8,
                                ImgUrl = "#",
                                FoodCategoryId = 2,
                                FoodRegionId = 1,
                            },
                            new Food
                            {
                                Id = 4,
                                Name = "Dorayaki",
                                Introduction = "Dorayaki is a type of Japanese confection. It consists of two small pancake-like patties made from castella wrapped around a filling of sweet azuki bean paste.",
                                Rating = 4,
                                Price = (decimal?)1.8,
                                ImgUrl = "#",
                                FoodCategoryId = 2,
                                FoodRegionId = 1,
                            },
                            new Food
                            {
                                Id = 5,
                                Name = "Dango",
                                Introduction = "Dango is a Japanese dumpling made from rice flour mixed with uruchi rice flour and glutinous rice flour.",
                                Rating = 3,
                                Price = (decimal?)1.6,
                                ImgUrl = "#",
                                FoodCategoryId = 2,
                                FoodRegionId = 1,
                            }, new Food
                            {
                                Id = 6,
                                Name = "Takoyaki",
                                Introduction = "Takoyaki is a ball-shaped Japanese snack made of a wheat flour-based batter and cooked in a special molded pan. ",
                                Rating = 5,
                                Price = (decimal?)2.2,
                                ImgUrl = "#",
                                FoodCategoryId = 2,
                                FoodRegionId = 1,
                            }, new Food
                            {
                                Id = 7,
                                Name = "Banana Flavored Milk",
                                Introduction = "Banana Flavored Milk is a South Korean milk beverage produced by Binggrae in Korea.",
                                Rating = 4,
                                Price = (decimal?)2.2,
                                ImgUrl = "#",
                                FoodCategoryId = 1,
                                FoodRegionId = 2,
                            }, new Food
                            {
                                Id = 8,
                                Name = "Hotteok",
                                Introduction = "Hotteok, sometimes called Hoeddeok, is a type of filled pancake and is a popular street food in South Korea. ",
                                Rating = 5,
                                Price = (decimal?)1.8,
                                ImgUrl = "#",
                                FoodCategoryId = 2,
                                FoodRegionId = 2,
                            }, new Food
                            {
                                Id = 9,
                                Name = "Walnut cookie",
                                Introduction = "walnut cookie is a type of cookie originated from Cheonan, South Korea.",
                                Rating = 3,
                                Price = (decimal?)1.6,
                                ImgUrl = "#",
                                FoodCategoryId = 2,
                                FoodRegionId = 2,
                            }, new Food
                            {
                                Id = 10,
                                Name = "Yuenyeung",
                                Introduction = "The drink is made from a mixture between coffee and tea. It can be served hot or cold.",
                                Rating = 4,
                                Price = (decimal?)2,
                                ImgUrl = "#",
                                FoodCategoryId = 1,
                                FoodRegionId = 3,
                            }, new Food
                            {
                                Id = 11,
                                Name = "Milktea",
                                Introduction = "Milk tea refers to several forms of beverage found in many cultures, containing some combination of tea and milk.",
                                Rating = 4,
                                Price = (decimal?)2,
                                ImgUrl = "#",
                                FoodCategoryId = 1,
                                FoodRegionId = 3,
                            }, new Food
                            {
                                Id = 12,
                                Name = "Eggtart",
                                Introduction = "These Cantonese egg tarts are classic pastry in Hong Kong, with buttery, crisp and crumbly tart shell, silky smooth custard inside.",
                                Rating = 5,
                                Price = (decimal?)1.5,
                                ImgUrl = "#",
                                FoodCategoryId = 2,
                                FoodRegionId = 3,
                            }, new Food
                            {
                                Id = 13,
                                Name = "Egg Waffles ",
                                Introduction = "An egg waffle is a spherical egg-based waffle popular in Hong Kong, consisting of an eggy leavened batter cooked between two plates of semi-spherical cells.",
                                Rating = 4,
                                Price = (decimal?)1.8,
                                ImgUrl = "#",
                                FoodCategoryId = 2,
                                FoodRegionId = 3,
                            }, new Food
                            {
                                Id = 14,
                                Name = "Baked waffles",
                                Introduction = "Peanut butter, butter, sugar and condensed milk are put together in the 2 waffles.",
                                Rating = 3,
                                Price = (decimal?)1.8,
                                ImgUrl = "#",
                                FoodCategoryId = 2,
                                FoodRegionId = 3,

                            });
            modelBuilder.Entity<FoodCategory>().HasData(
                    new FoodCategory { Id = 1, Name = "Drink" },
                    new FoodCategory { Id = 2, Name = "Snack" }
                );
            modelBuilder.Entity<FoodRegion>().HasData(
                new FoodRegion { Id = 1, Name = "Japan" },
                new FoodRegion { Id = 2, Name = "Korea" },
                new FoodRegion { Id = 3, Name = "Hong Kong" }
    );

        }
    }
}

