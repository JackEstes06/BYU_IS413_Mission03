namespace Mission03;

public class FoodItem
{
    private string name;
    private string category;
    private int quantity;
    private DateOnly date;

    FoodItem(string name, string category, int quantity, DateOnly date)
    {
        this.name = name;
        this.category = category;
        this.quantity = quantity;
        this.date = date;
    }
}