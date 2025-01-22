// Food Bank Simulator
string userInput = "";
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

// Start the program
Console.WriteLine("Welcome to the Food Bank!");
userInput = foodBankChoices();

while (userInput != "4")
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("Time to Add a Food Item");
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

