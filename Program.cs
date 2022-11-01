int amountUsed = 0;
int num1 = 0;
int num2 = 0;
string selection;

Console.WriteLine(" CALCULATOR APP ");
Console.WriteLine(" ------------- ");
Console.WriteLine("Welcome to the console Calculator App. What maths operation would you like to perform?: ");
MainMenu();


void MainMenu()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("A. Addition");
    Console.WriteLine("B. Subtraction");
    Console.WriteLine("C. Division");
    Console.WriteLine("D. Multiplication");
    Console.Write("> ");
    Console.ResetColor();
    selection = Console.ReadLine().ToUpper();
    Console.WriteLine();

    while (selection != "A" || selection != "B" || selection != "C" || selection != "D")
    {
        Console.WriteLine("Invalid selection. Please enter A, B, C, or D");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("> ");
        Console.ResetColor();
        selection = Console.ReadLine().ToUpper();
    }
}