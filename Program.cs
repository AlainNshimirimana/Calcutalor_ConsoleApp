decimal num1 = 0.00m;
decimal num2 = 0.00m;
decimal result = 0.00m;
int numGames = 0;
string selection;

Console.WriteLine(" CALCULATOR APP ");
Console.WriteLine(" ------------- ");
Console.WriteLine("Welcome to the console Calculator App. What maths operation would you like to perform?: ");
MainMenu();


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
    selection = Console.ReadLine().ToUpper();
    Console.WriteLine();

    while (selection.ToUpper() != "A" || selection.ToUpper() != "S" || selection.ToUpper() != "D" || selection.ToUpper() != "M" || selection.ToUpper() != "E")
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
    throw new NotImplementedException();
}

void Division()
{
    throw new NotImplementedException();
}

void Subtraction()
{
    throw new NotImplementedException();
}

void Addition()
{
    throw new NotImplementedException();
}