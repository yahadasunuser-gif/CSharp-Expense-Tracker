decimal budget;
decimal remainingBudget;
string expenseName = "";
decimal expense;
decimal halfWay;
decimal totalExpense = 0;


while (true) // ensuring the entered total budget is a positive and nonZero value
{
    Console.WriteLine("Enter Total budget: ");
    string stringBudget = Console.ReadLine();
    budget = decimal.Parse(stringBudget);
    if (budget < 0)
    {
        Console.WriteLine("Please enter a positive number");
    }
    else if (budget == 0)
    {
        Console.WriteLine("Please enter a number greater than zero");
    }
    else
    {
        break;
    }
}

while (true)  //Main loop
{
 
    while (true)
    {
        Console.Write("Enter you expenxce name(e to exit): ");
        expenseName = Console.ReadLine();

        if (expenseName.ToLower() == "e") break;  // exting the inner loop

        if (decimal.TryParse(expenseName, out decimal num))  // checking id the user has input of number insted of a string
        {
            Console.WriteLine("Please enter a name not a value");
        }
        else
        {
            break;
        }
    }

    
    if (expenseName.ToLower() == "e") break;  // exting the main loop

  
    while (true)
    {
        Console.Write("Enter you expenxce value(e to exit): ");
        string expensestring = Console.ReadLine();

        if (expensestring.ToLower() == "e") break;  // exting the inner loop

        
        if (decimal.TryParse(expensestring, out expense))
        {
            if (expense < 0)
            {
                Console.WriteLine("Please enter a positive number");
            }
            else if (expense == 0)
            {
                Console.WriteLine("Please enter a number greater than zero");
            }
            else
            {
                totalExpense = totalExpense + expense;  //  calculating the total expenses
                break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }


   
}




remainingBudget = budget - totalExpense;
if (remainingBudget <= budget * 0.5m && remainingBudget > 0)  // m for the decimal division
{
    Console.Write("Your are reaching halfwat of your budget");
}
else if (remainingBudget < 0)
{
    Console.WriteLine("ALERT: You are over budget!");
}

Console.WriteLine($"Your remaining budget is {remainingBudget}");  // output







