Console.WriteLine("please enter a number");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("this number is positive");
}

else if (number < 0)
{
    Console.WriteLine("this number is negative");
}

else
{
    Console.WriteLine("this number is zero");
}