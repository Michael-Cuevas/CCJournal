namespace Domain
{
    public class Meal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Calories { get; set; }
        public int OrderNumber { get; set; }
        public Weekdays Weekday  { get; set; }
        public DateOnly MealDate { get; set; }
        public int Frequency { get; set; }
        public ICollection<MealItem> MealItems { get; set; } = new List<MealItem>();

        public Meal() {
            Name = "";
        }

        public enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

    }
}
