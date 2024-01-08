namespace mod2_les7_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2016;
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}

