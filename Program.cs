Console.WriteLine("C# Conditions");

Console.WriteLine("Enter Student Grade.");
double grade = Double.Parse(Console.ReadLine() ?? "n");
Console.WriteLine("Did Student paid? (y/n)");
bool paid;
string input = Console.ReadLine() ?? "n";
if (input == "y")
{
    paid = true;
} else {
    paid = false;
}

if (grade > 60)
{
   if (paid)
   {
      Console.WriteLine("Congratulations!");
   } else {
    Console.WriteLine("You need to pay graduation fees.");
   }
} else{
    Console.WriteLine("Did not gratuated!");
}

Console.WriteLine("Program ended!");
