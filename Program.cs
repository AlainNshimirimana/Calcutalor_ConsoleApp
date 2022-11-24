decimal num1;
decimal num2;
decimal result = 0.00m;
int numGames = 0;
string selection;

Console.WriteLine(" CALCULATOR APP ");
Console.WriteLine(" ------------- ");
Console.WriteLine("Welcome to the console Calculator App.");
MainMenu();
Console.WriteLine($"The number of oparetions performed is {numGames}");
Console.WriteLine("\nGoodbye!");

void MainMenu()
{
    Console.WriteLine("\nWhat would you like to do?: ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("A. Addition");
    Console.WriteLine("S. Subtraction");
    Console.WriteLine("D. Division");
    Console.WriteLine("M. Multiplication");
    Console.WriteLine("E. Exit");
    Console.Write("> ");
    Console.ResetColor();
    selection = Console.ReadLine().Trim().ToUpper();
    Console.WriteLine();

    while (selection != "A" && selection != "S" &&  selection != "D" && selection != "M" && selection != "E")
    {
        Console.WriteLine("Invalid selection. Please enter A, S, D, M, or E to exit");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("> ");
        Console.ResetColor();
        selection = Console.ReadLine().ToUpper();
    }

    Console.Clear();

    switch (selection)
    {
        case "A":
            Addition();
            break;
        case "S":
            Subtraction();
            break;
        case "D":
            Division();
            break;
        case "M":
            Multiplication();
            break;
        default:
            break;
    }
}

void Multiplication()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("MULTIPLICATION");
    Console.ResetColor();
    Console.WriteLine("--------");
    Console.Write("First number: ");
    num1 = decimal.Parse(Console.ReadLine());
    Console.Write("Second number: ");
    num2 = decimal.Parse(Console.ReadLine());
    Console.WriteLine($"{num1} × {num2} = {num1 * num2}");
    numGames++;
    MainMenu();
}

void Division()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("DIVISION");
    Console.ResetColor();
    Console.WriteLine("--------");
    Console.Write("First number: ");
    num1 = decimal.Parse(Console.ReadLine());
    Console.Write("Second number: ");
    num2 = decimal.Parse(Console.ReadLine());
    Console.WriteLine($"{num1} ÷ {num2} = {num1 / num2}");
    numGames++;
    MainMenu();
}

void Subtraction()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("SUBTRACTION");
    Console.ResetColor();
    Console.WriteLine("--------");
    Console.Write("First number: ");
    num1 = decimal.Parse(Console.ReadLine());
    Console.Write("Second number: ");
    num2 = decimal.Parse(Console.ReadLine());
    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    numGames++;
    MainMenu();
}

void Addition()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("ADDITION");
    Console.ResetColor();
    Console.WriteLine("--------");
    Console.Write("First number: ");
    num1 = decimal.Parse(Console.ReadLine());
    Console.Write("Second number: ");
    num2 = decimal.Parse(Console.ReadLine());
    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    numGames++;
    MainMenu();
}