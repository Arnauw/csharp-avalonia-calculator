// See https://aka.ms/new-console-template for more information

Console.Write("Hello, what's your name: ");
string name = Console.ReadLine() ?? "";

Console.WriteLine();

// Test comment

/*
 * Multiline comment test.
 */
if (string.IsNullOrEmpty(name))
{
    Console.WriteLine("You didn't enter a name... you fucking retard!");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}