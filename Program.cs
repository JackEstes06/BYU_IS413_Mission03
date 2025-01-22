using Mission03;

// Food Bank Simulator
string userInput = "";
List<FoodItem> foodItems = new List<FoodItem>();

// Userful functions
string foodBankChoices()
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

void addFoodItem()
{
    // Get User Input for Food Item
    try
    {
        // Get Food Name from User
        Console.Write("Enter a Name: ");
        string nameInput = Console.ReadLine();
        Console.WriteLine($"You entered: {nameInput}");
        
        // Get Food Category from User
        Console.Write("Enter a Category: ");
        string categoryInput = Console.ReadLine();
        Console.WriteLine($"You entered: {categoryInput}");
        
        // Get Food Quant. from User
        Console.Write("Enter a quantity: ");
        string quantInput = Console.ReadLine();
        int quant = int.Parse(quantInput);
        Console.WriteLine($"You entered: {quant}");
        
        // Get Exp. Date from User
        Console.Write("Enter a date (yyyy-MM-dd): ");
        string dateInput = Console.ReadLine();
        DateOnly date = DateOnly.Parse(dateInput);
        Console.WriteLine($"You entered: {date}");
    }
    catch (FormatException)
    {
        Console.WriteLine($"""
                          Invalid input. Please make sure your inputs are correct.
                          For quantity enter a number.
                          For Date enter yyyy-MM-dd.
                          """);
    }
}

void deleteFoodItem()
{
}

void printFoodItems()
{
}


// Start the program
Console.WriteLine("Welcome to the Food Bank!");
userInput = foodBankChoices();

while (userInput != "4")
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Time to Add a Food Item");
            addFoodItem();
            break;
        case "2":
            Console.WriteLine("Time to Delete a Food Item");
            break;
        case "3":
            Console.WriteLine("Time to See Food Items");
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

    userInput = foodBankChoices();
}

