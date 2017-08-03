using System;

namespace BoxAssignment
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Box object
            Box b1 = new Box();

           //Request for user input
            Console.WriteLine("Enter the cost of material per square inch: ");
            double matCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height in inches: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length in inches: ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width in inches: ");
            double w = Convert.ToDouble(Console.ReadLine());

            //Calculation for volume and total surface area
            double v = h * l * w;
            double a1 = h * w;
            double a2 = h * l;
            double a3 = w * l;
            double surfaceArea = 2*(a1) + 2*(a2) + 2*(a3);

              //Display results
               Console.WriteLine("The volume of this box is " + "{0}" + " cubic inches.", v);
               Console.WriteLine("The total surface area " + "{0}" + " sq. inches.", surfaceArea);
               Console.WriteLine("This box costs " + "${0}" + " per sq. inch.", matCost);
        }
    }
}

