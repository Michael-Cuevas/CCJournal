using Domain;
using static Domain.Meal;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Meals.Any()) return;

            var meals = new List<Meal>
            {
                new Meal
                {
                    Name = "Breakfast",
                    Description = "My breakfast",
                    Calories = 500,
                    OrderNumber = 0,
                    Weekday = Weekdays.Monday,
                    MealDate = new DateOnly(2023,10,1),
                    Frequency = 1,
                    MealItems = new List<MealItem>
                    {
                        new MealItem
                        {
                            Name = "Egg",
                            Description = "its an egg",
                            ServingSize = "Each",
                            Quantity = 2,
                            ServingSizeCalories = 100,
                            TotalCalories = 200
                        },
                        new MealItem
                        {
                            Name = "Bacon",
                            Description = "its bacon",
                            ServingSize = "Each",
                            Quantity = 2,
                            ServingSizeCalories = 150,
                            TotalCalories = 300
                        }
                    }
                },
                new Meal
                {
                    Name = "Lunch",
                    Description = "My lunch",
                    Calories = 600,
                    OrderNumber = 1,
                    Weekday = Weekdays.Monday,
                    MealDate = new DateOnly(2023,10,1),
                    Frequency = 1,
                    MealItems = new List<MealItem>
                    {
                        new MealItem
                        {
                            Name = "SmartOne frozen meal",
                            Description = "A microwaveable frozen meal",
                            ServingSize = "Each",
                            Quantity = 1,
                            ServingSizeCalories = 450,
                            TotalCalories = 450
                        },
                        new MealItem
                        {
                            Name = "Banana",
                            Description = "its a banana",
                            ServingSize = "Each",
                            Quantity = 1,
                            ServingSizeCalories = 150,
                            TotalCalories = 150
                        }
                    }
                },
                new Meal
                {
                    Name = "Dinner",
                    Description = "My dinner",
                    Calories = 824,
                    OrderNumber = 2,
                    Weekday = Weekdays.Monday,
                    MealDate = new DateOnly(2023,10,1),
                    Frequency = 1,
                    MealItems = new List<MealItem>
                    {
                        new MealItem
                        {
                            Name = "Rice",
                            Description = "its rice",
                            ServingSize = "1 Cup",
                            Quantity = 2,
                            ServingSizeCalories = 206,
                            TotalCalories = 412
                        },
                        new MealItem
                        {
                            Name = "Salmon",
                            Description = "its salmon",
                            ServingSize = "0.5 fillet",
                            Quantity = 1,
                            ServingSizeCalories = 412,
                            TotalCalories = 412
                        }
                    }
                },
                new Meal
                {
                    Name = "Breakfast",
                    Description = "My breakfast",
                    Calories = 500,
                    OrderNumber = 0,
                    Weekday = Weekdays.Tuesday,
                    MealDate = new DateOnly(2023, 10, 2),
                    Frequency = 1,
                    MealItems = new List<MealItem>
                    {
                        new MealItem
                        {
                            Name = "Item 1 for Tuesday's Breakfast",
                            Description = "Description for Item 1",
                            ServingSize = "Each",
                            Quantity = 2,
                            ServingSizeCalories = 100,
                            TotalCalories = 200
                        },
                        new MealItem
                        {
                            Name = "Item 2 for Tuesday's Breakfast",
                            Description = "Description for Item 2",
                            ServingSize = "Each",
                            Quantity = 1,
                            ServingSizeCalories = 150,
                            TotalCalories = 150
                        }
                    }
                },
                new Meal
                {
                    Name = "Lunch",
                    Description = "My lunch",
                    Calories = 600,
                    OrderNumber = 1,
                    Weekday = Weekdays.Tuesday,
                    MealDate = new DateOnly(2023, 10, 2),
                    Frequency = 1,
                    MealItems = new List<MealItem>
                    {
                        new MealItem
                        {
                            Name = "Item 1 for Tuesday's Lunch",
                            Description = "Description for Item 1",
                            ServingSize = "Each",
                            Quantity = 1,
                            ServingSizeCalories = 450,
                            TotalCalories = 450
                        },
                        new MealItem
                        {
                            Name = "Item 2 for Tuesday's Lunch",
                            Description = "Description for Item 2",
                            ServingSize = "Each",
                            Quantity = 1,
                            ServingSizeCalories = 150,
                            TotalCalories = 150
                        }
                    }
                },
                new Meal
                {
                    Name = "Dinner",
                    Description = "My dinner",
                    Calories = 800,
                    OrderNumber = 2,
                    Weekday = Weekdays.Tuesday,
                    MealDate = new DateOnly(2023, 10, 2),
                    Frequency = 1,
                    MealItems = new List<MealItem>
                    {
                        new MealItem
                        {
                            Name = "Item 1 for Tuesday's Dinner",
                            Description = "Description for Item 1",
                            ServingSize = "Each",
                            Quantity = 1,
                            ServingSizeCalories = 400,
                            TotalCalories = 400
                        },
                        new MealItem
                        {
                            Name = "Item 2 for Tuesday's Dinner",
                            Description = "Description for Item 2",
                            ServingSize = "Each",
                            Quantity = 1,
                            ServingSizeCalories = 400,
                            TotalCalories = 400
                        }
                    }
                }
            };
            await context.Meals.AddRangeAsync(meals);
            await context.SaveChangesAsync();
        }
    }
}
