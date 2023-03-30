namespace Learn_part_3
{
    internal class Program
    {
        /*
        class Circle
        {
            
            public static float PI;
            double radius;

            static Circle()
            {
                //static constructor  
                Console.WriteLine("Static Construct Called");
                Circle.PI = 3.142F;
            }
             public Circle(double radius)
            {

                Console.WriteLine("Instance Construct Called");
                this.radius = radius;
            }

            public double CalculateArea()
            {
                return Circle.PI * this.radius * this.radius;

            }
            
        }
        */

        public class Person
        {
            public string FName;
            public string LName;
            public string Gender;
            public string Gge;
            public string Nationality;
            public string Religion;
            public int contactDetails;

            public void PrintPersonAttributes()
            {
                Console.WriteLine("");
            }
        }

        public class Student : Person
        {
            public int STD_ID;
            public string StudentDept;
            public string StudentCollege;
            public string NameOfUni;
            public string STD_MAT_NUM;
            public string CoursesOfStudy;
            public string STD_List_Courses;


        }

        public class Patient : Person
        {
            public int Patient_ID;
            public string PatientCondition;
            public string PatientWard;
        }

        /*
    public class empolyee
    {
        //inheritance
        //fields
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);

        }
    }

    //sytanx for inheritance
    public class FullTimeEmployee : empolyee
    {
        public float YearlySalary;


    }

    public class PartTimeEmployee : empolyee
    {
        public float HourlyRate;
    }
    */

        static void Main(string[] args)
        {

            /* //creating instance of caculateArea 
             Circle C1 = new Circle(5);
             double Area = C1.CalculateArea();
             Console.WriteLine($" area is : {Area}");

             // static are invoke using the name of a class 

             Circle C2 = new Circle(9);
             double Area2 = C2.CalculateArea();
             Console.WriteLine($" area is : {Area2}");
            */

            //Console.WriteLine(Circle.PI);
            //inheritance in CSharp


            Person STD = new Person();
            Console.WriteLine("What is your first name");
            STD.FName = Console.ReadLine();

            Console.WriteLine("What is your last name");
            STD.LName = Console.ReadLine();

            Console.WriteLine("How old are you");
            STD.FName = Console.ReadLine();

            Console.WriteLine("");
            STD.FName = Console.ReadLine();


            //inheritance  allows code reusue 
            /*FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Destiny";
            FTE.LastName = "Obs";
            FTE.YearlySalary = 50000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Yong";
            PTE.LastName = "Cho";
            PTE.HourlyRate = 5000;
            PTE.PrintFullName();
            */

            //inhericance syntax
            //    public class parentclass
            //{
            //    //parent class implementation
            //}

            //    public class derived class: parentclass
            //{

            //}

        }
}
}