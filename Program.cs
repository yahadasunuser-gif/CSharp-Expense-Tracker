decimal budget;
decimal remainingBudget;
string expenseName;
decimal expense;
while (true)
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
while (true)
    {
        Console.WriteLine("Enter you expenxce name: ");
        Console.WriteLine("Enter you expenxce value: ");
        expenseName = Console.ReadLine();
        string expensestring = Console.ReadLine();
        expense = decimal.Parse(expensestring);
        
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
            break;
        }
        
    }
   

