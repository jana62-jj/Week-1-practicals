Console.WriteLine("Enter a year:");

int year = Convert.ToInt16(Console.ReadLine());

if (year <= 0)
{
    Console.WriteLine("please enter a year greater than 0");
}

else if( year %400==0 ||(year %4==0 && year %100 !=0))
    {
    Console.WriteLine($"{year} is a leap year");

}

else
{
    Console.WriteLine($"{year} is not a leap year");
}

Console.ReadKey();