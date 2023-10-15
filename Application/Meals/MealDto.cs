using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Meals
{
    public class MealDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Calories { get; set; }
        public int OrderNumber { get; set; }
        public Meal.Weekdays Weekday { get; set; }
        public DateOnly MealDate { get; set; }
        public int Frequency { get; set; }
        public List<MealItemDto> MealItems { get; set; } = new List<MealItemDto>();
    }
}
