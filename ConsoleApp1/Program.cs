namespace Distinct_Division_Of_numbers
{

    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the Numerator");
            string upnum = Console.ReadLine();

            bool num1 = int.TryParse(upnum, out int number);
            while (num1 == false)
            {
                Console.WriteLine("Please Input an integar");
                upnum = Console.ReadLine();
                num1 = int.TryParse(upnum, out number);
            }


            Console.WriteLine("Enter the Denominator");
            string dwnnum = Console.ReadLine();

            bool num2 = int.TryParse(dwnnum, out int number2);
            while (num2 == false)
            {
                Console.WriteLine("Please Input an integar");
                dwnnum = Console.ReadLine();
                num2 = int.TryParse(dwnnum, out number2);
            }




            if (number2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            {

                float ans = (float)number / (float)number2;
                Console.WriteLine($"The division of {upnum} and {dwnnum} = {ans}");

            }
            



           


        }
    }
}