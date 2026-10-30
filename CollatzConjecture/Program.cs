Console.WriteLine("Welcome to the Collatz Conjecture console application!\nThis app will take a given or randomized number above 4 and print each number until the loop.\nWould you like to choose a number (c) or have a number randomly chosen? (r)");
char choice = Convert.ToChar(Console.ReadLine());
int number = 0;

// I couldn't find how to do an equalsIgnoreCase kind of method like java

while (choice == 'r' || choice == 'c')
{
    Console.WriteLine("Please choose random (R) or chosen (C) for a number.");
}
// uppercases choice
choice = char.ToUpper(choice);

// checks which choice user made
if (choice == 'R')
{

    // choose random number 1 - 200
    Random rand = new Random();
    number = rand.Next(1, 201);
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

    Console.WriteLine("Your chosen number is: " + number);
}

Console.WriteLine("Please enter Y to continue");
// my original code would not work, so I asked AI to assist, and it showed me how to ignore case and trim any whitespace
while (!string.Equals(Console.ReadLine()?.Trim(), "Y", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Please enter Y to continue");
}
while (number != 1)
{
    Console.WriteLine(number);

    if ((number & 1) == 0)
    {
        number = number / 2;
    }
    else
    {
        number = number * 3 + 1;
    }
}

Console.WriteLine(number);
Console.WriteLine("The Collatz loop has finished.");