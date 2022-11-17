decimal num1 = 0.00m;
decimal num2 = 0.00m;
decimal result = 0.00m;
int numGames = 0;
string selection;

Console.WriteLine(" CALCULATOR APP ");
Console.WriteLine(" ------------- ");
Console.WriteLine("Welcome to the console Calculator App. What maths operation would you like to perform?: ");
MainMenu();
Console.WriteLine($"The number of oparetions performed is {numGames}");
Console.WriteLine("\nGoodbye!");

Console.Read();


void MainMenu()
{
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
}