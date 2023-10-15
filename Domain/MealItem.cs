namespace Domain
{
    public class MealItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ServingSize { get; set; }
        public int Quantity { get; set; }
        public int ServingSizeCalories { get; set; }
        public int TotalCalories { get; set; }
        public Meal Meal { get; set; } = null!;
        public Guid MealId { get; set; }

        public MealItem() {
            Name = "";
        }
    }
}
