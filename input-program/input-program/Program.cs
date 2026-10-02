Console.WriteLine("what is your name?");
String name = Console.ReadLine();

Console.WriteLine("What is your age?");
int age = Convert.ToInt32(Console.ReadLine());

int futureAge = age + 5;
Console.WriteLine($"hello {name} and in 5 years u will be {futureAge} years old");

Console.ReadKey();