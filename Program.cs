using Mission03;

// Food Bank Simulator
string userInput = "";
List<FoodItem> foodItems = new List<FoodItem>();

// Userful functions
string FoodBankChoices()
{
    Console.WriteLine("""
                      What would you like to do?
                      1. Add a Food Item
                      2. Delete a Food Item
                      3. List Food Items
                      4. Exit Program
                      """);
    return Console.ReadLine();
}

void AddFoodItem()
{
    string nameInput = "";
    string categoryInput = "";
    int quant = 0;
    DateOnly date = new DateOnly();
    
    // Get User Input for Food Item
    try
    {
        // Get Food Name from User
        Console.Write("Enter a Name: ");
        nameInput = Console.ReadLine();
        Console.WriteLine($"You entered: {nameInput}");
        
        // Get Food Category from User
        Console.Write("Enter a Category: ");
        categoryInput = Console.ReadLine();
        Console.WriteLine($"You entered: {categoryInput}");
        
        // Get Food Quant. from User
        Console.Write("Enter a quantity: ");
        string quantInput = Console.ReadLine();
        while (int.Parse(quantInput) < 0)
        {
            Console.Write($"You Entered: {quantInput}. Enter a positive quantity (i.e. any number > 0): ");
            quantInput = Console.ReadLine();
        }
        quant = int.Parse(quantInput);
        Console.WriteLine($"You entered: {quant}");
        
        // Get Exp. Date from User
        Console.Write("Enter a date (yyyy-MM-dd): ");
        string dateInput = Console.ReadLine();
        date = DateOnly.Parse(dateInput);
        Console.WriteLine($"You entered: {date}");
    }
    catch (FormatException)
    {
        Console.WriteLine("""
                          Invalid input. Please make sure your inputs are correct.
                          For quantity enter a number.
                          For Date enter yyyy-MM-dd.
                          """);
    }

    foodItems.Add(new Mission03.FoodItem(nameInput, categoryInput, quant, date));
}

void DeleteFoodItem()
{
    int itemIndexToDelete = -1;
    PrintFoodItems(numberItems: true);
    Console.WriteLine("Which item would you like to delete?");
    try
    {
        string itemIndexInput = Console.ReadLine();
        while (int.Parse(itemIndexInput) < 0 || int.Parse(itemIndexInput) > foodItems.Count)
        {
            Console.WriteLine($"Invalid Input. You Entered: {itemIndexInput}. Enter a number in the list:");
            PrintFoodItems(numberItems: true);
            itemIndexInput = Console.ReadLine();
        }
        itemIndexToDelete = int.Parse(itemIndexInput);
        Console.WriteLine($"Deleting Item: {itemIndexToDelete}");
    }
    catch (FormatException)
    {
        Console.WriteLine("""
                          Invalid input. Please make sure your inputs are correct.
                          For quantity enter a number.
                          For Date enter yyyy-MM-dd.
                          """);
    }
    
    foodItems.RemoveAt(itemIndexToDelete - 1);
}

void PrintFoodItems(bool numberItems = false)
{
    if (foodItems.Count == 0) Console.WriteLine("No Food Items");
    foreach (FoodItem foodItem in foodItems)
    {
        if (numberItems) Console.Write($"{(foodItems.IndexOf(foodItem) + 1)}. ");
        Console.WriteLine(foodItem.ToString());
    }
}

// Start the program
Console.WriteLine("Welcome to the Food Bank!");
userInput = FoodBankChoices();

// Continue until the user quits the program
while (userInput != "4")
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Time to Add a Food Item");
            AddFoodItem();
            break;
        case "2":
            Console.WriteLine("Time to Delete a Food Item");
            DeleteFoodItem();
            break;
        case "3":
            Console.WriteLine("Time to See Food Items");
            PrintFoodItems();
            break;
        // TODO remove this if not using do/while loop
        // This never runs
        case "4":
            Console.WriteLine("Quitting..");
            break;
        default:
            Console.WriteLine($"{userInput} is an invalid input!");
            break;
    }

    userInput = FoodBankChoices();
}

