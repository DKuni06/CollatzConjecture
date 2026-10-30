# Collatz Conjecture

A .NET console application that demonstrates the **Collatz conjecture** by generating and displaying the sequence for a positive integer greater than 4.

## About the Collatz Conjecture

The conjecture applies the following rules to a positive integer:

- If the number is even, divide it by 2.
- If the number is odd, multiply it by 3 and add 1.
- Repeat until the number reaches 1.

For example, starting with `6` produces:

```text
6 → 3 → 10 → 5 → 16 → 8 → 4 → 2 → 1
```

After reaching 1, the sequence enters the repeating cycle `1 → 4 → 2 → 1`. The conjecture states that every positive integer eventually reaches this cycle. Although it has been tested for many numbers, it has not been mathematically proven for all positive integers.

## Features

- Choose a number manually or generate a random number.
- Require manually entered numbers to be greater than 4.
- Display the resulting Collatz sequence.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later

## Running the Application

From the repository directory, run:

```bash
dotnet run --project CollatzConjecture/CollatzConjecture.csproj
```

When prompted:

1. Enter `c` to choose a number manually, or `r` to generate one randomly.
2. If you choose a number manually, enter a positive integer greater than 4.
3. Follow the prompts to continue and view the sequence.

## Algorithm

The application repeatedly applies the following algorithm basen on whether the current number is even:

```text
while number is not one
{
    Console.WriteLine(number);

    if number is even
    {
        number = number / 2;
    }
    else
    {
        number = number * 3 + 1;
    }
}
```



## Project Structure

```text
CollatzConjecture/
├── CollatzConjecture.csproj
└── Program.cs
```
