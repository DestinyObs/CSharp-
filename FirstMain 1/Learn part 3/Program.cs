namespace Learn_part_3
{
   /* public class parentClass
    {
        public parentClass()
        {
            Console.WriteLine("ParentClass Constructor Called");
        }

        public parentClass(string Msg)
        {
            Console.Write(Msg);
        }

        public class Childclass : parentClass
        {
            public Childclass() : base("message derivded control parent class\n")
            {
                Console.WriteLine("ChildClass Constructor called");
            }
        }
   */

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
            /*
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
            */

        public class empolyee
        {
            //inheritance
            //fields
            public string FirstName = "FN";
            public string LastName = "LN";

            public virtual void PrintFullName()
            {
                //means any derived class canoverride that method 
                Console.WriteLine(FirstName + " " + LastName);

            }
        }
        //sytanx for inheritance
        public class FullTimeEmployee : empolyee
        {
            public override void PrintFullName()
            {
                //    //base.PrintFullName();
                Console.WriteLine(FirstName + " " + LastName + " - Full Time Emp");

            }


        }

        public class TempEmployee : empolyee
        {
            public override void PrintFullName()
            {
                //    //base.PrintFullName();
                Console.WriteLine(FirstName + " " + LastName + " - Temp Emp");

            }

        }

        public class PartTimeEmployee : empolyee
        {
            //this method hides inherted full name from method employee
            //use the new key word
            public override void PrintFullName()
            {
            //    //base.PrintFullName();
            Console.WriteLine(FirstName + " " + LastName + " - Part Time Emp");

            }
        }


            static void Main(string[] args)
            {
            //polymophism enables us to invoke derived class method using a base class reference variable art run time

            empolyee[] empolyees = new empolyee[4];

            empolyees[0] = new empolyee();
            empolyees[1] = new PartTimeEmployee();
            empolyees[2] = new FullTimeEmployee();
            empolyees[3] = new TempEmployee();

            //looping through
            foreach(empolyee e in empolyees)
            {
                e.PrintFullName();
            }
                //creating obj
                //Childclass CC = new Childclass();

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


                /*Person STD = new Person();
                Console.WriteLine("What is your first name");
                STD.FName = Console.ReadLine();

                Console.WriteLine("What is your last name");
                STD.LName = Console.ReadLine();

                Console.WriteLine("How old are you");
                STD.FName = Console.ReadLine();

                Console.WriteLine("");
                STD.FName = Console.ReadLine();
                */

                //inheritance  allows code reusue 
                /*
                FullTimeEmployee FTE = new FullTimeEmployee();
                FTE.FirstName = "Destiny";
                FTE.LastName = "Obs";
                FTE.PrintFullName();

                empolyee PTE = new PartTimeEmployee();
                PTE.FirstName = "Yong";
                PTE.LastName = "Cho";
                //((empolyee)PTE).PrintFullName();
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