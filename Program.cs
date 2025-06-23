// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose an operation:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.Write("Enter your choice (1-4): ");
int choice = Convert.ToInt32(Console.ReadLine());
if (choice < 1 || choice > 4)
{
    Console.WriteLine("Invalid choice. Please run the program again.");
    return;
}
Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
double result = 0;
switch (choice)
{
    case 1:
        result = num1 + num2;
        Console.WriteLine($"Result: {num1} + {num2} = {result}");
        break;
    case 2:
        result = num1 - num2;
        Console.WriteLine($"Result: {num1} - {num2} = {result}");
        break;
    case 3:
        result = num1 * num2;
        Console.WriteLine($"Result: {num1} * {num2} = {result}");
        break;
    case 4:
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }
        result = num1 / num2;
        Console.WriteLine($"Result: {num1} / {num2} = {result}");
        break;
}