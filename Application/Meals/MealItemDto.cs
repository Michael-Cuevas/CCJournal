using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Meals
{
    public class MealItemDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ServingSize { get; set; }
        public int Quantity { get; set; }
        public int ServingSizeCalories { get; set; }
        public int TotalCalories { get; set; }
    }
}
