using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Press 'enter' and follow the instructions below.");
        Console.ReadLine();
        Console.WriteLine("Please enter the package weight:");
        int packageWeight = Convert.ToInt32(Console.ReadLine());
        if (packageWeight > 50)
        {
            Console.WriteLine("Your package is too heavy to be shipped via Package Express. Have a good day!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package height");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package length");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            int dimensionsTotal = packageWidth * packageHeight * packageLength;

            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Your package is too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: {0:C}", Convert.ToDecimal(dimensionsTotal) * packageWeight / 100);
            }
            Console.ReadLine();
        }
    }
    
}
