using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
using System.Collections;
using System.Configuration; 

namespace FirstMain_1
{
    class Customer
    {
        string firstName;
        string lastName;

        public Customer() 
            : this("No firstName Provided", "No firstName Provided")
        { 

        }
        //contructor - used the initialize your class fields
        //are called automatically wil you create an instance of a class.... can take parameter
        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        //Method - represent the behavoiur!
        public void getFullName()
        {
            Console.WriteLine($"Full Name = {firstName} {lastName}");

        }
        //a class can also have destructors to clean up resources your class was holding it its life time.
        // cannot take paramters and also has a tilled before the class name
        ~Customer()
        {
            //clean up code
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.getFullName();

            Customer C2 = new Customer("Destiny", "Obs");
            C2.getFullName();
            //overloading contructors

            PATA.ClassA.print();
            PATB.ClassB.print();
            // namespaces are used to organize your program.... 

             int Total = 0;
             int Product = 0;

             Add(10, 20, out Total, out Product);

             Console.WriteLine($"sunans = {Total} && Product = {Product}");
            

            int[] num = new int[7];
            num[0] = 101;
            num[1] = 102;
            num[2] = 103;
            num[3] = 104;
            num[4] = 105;
            num[5] = 106;
            num[6] = 107;

            //ParamsMethod();
            //ParamsMethod(num);
            ParamsMethod(1, 2, 3, 4, 5);
            //invoking method paramters are called arguments

            

        }

        public static void Add(int x, int y, out int sum, out int Product) 
        { 
            sum = x + y;
            Product = x * y;
        }

        //Value paramter
        //ref paramter
        //output paramter
        
        public static void ParamsMethod(params int[] num)
            //params as to be the last
        {
            Console.WriteLine($"There are  {num.Length} elements");
            foreach (int i in num) 
            { 
                Console.WriteLine(i);
            }

        }
        

    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void print()
            {
                Console.WriteLine("Yo Yo ");
            }
        }
    }

    namespace TeamB
    {
        class ClassB
        {
            public static void print()
            {
                Console.WriteLine("How are you my friend");
            }
        }
    }
}
