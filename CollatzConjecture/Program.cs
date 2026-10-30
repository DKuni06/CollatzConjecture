Console.WriteLine("Welcome to the Collatz Conjecture console application!\nThis app will take a given or randomized number above 4 and print each number until the loop.\nWould you like to choose a number (c) or have a number randomly chosen? (r)");
char choice = Convert.ToChar(Console.ReadLine);
int number = 0;

// I couldn't find how to do an equalsIgnoreCase kind of method like java
if (choice == 'r' || choice == 'c' )
{
    choice = char.ToUpper(choice);
}

// checks which choice user made
if (choice == 'R')
{
    Random rand = new Random();
    number = rand.Next();
    while (number < 5)
    {
        number = rand.Next();
    }
    Console.WriteLine("The randomly chosen number is: " + number);
}  else if (choice == 'C')
{
    Console.WriteLine("Enter a positive number above 4. ");
    number = Convert.ToInt32(Console.ReadLine());

    // checks if number is below 5 and repeatedly requests a number
    while (number < 5)
    {
        Console.WriteLine("That number will lead to the loop and stop the application. Please enter a positive number above 4.");
        number = Convert.ToInt32(Console.ReadLine());
    }
    
}