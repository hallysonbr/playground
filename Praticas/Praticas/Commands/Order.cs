namespace Praticas.Commands
{
    /// <summary>
    /// Concrete Command
    /// </summary>
    public class Order : RestaurantCommand
    {
        private Chef Chef { get; set; }
        private string Action { get; set; }

        public Order(Chef chef, string action)
        {
            Chef = chef;
            Action = action;
        }
        public override void Execute()
        {
            if (Action == "Meal")
                Chef.Cook();
            else
                Chef.Dessert();
        }
    }
}
