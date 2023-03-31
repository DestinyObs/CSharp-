using System.Security.Cryptography;

namespace Begin_from_overriding_and_hiding
{
    ////public class BaseClass
    ////{
    ////    public virtual void print()
    ////    {
    ////        Console.WriteLine("I'm, the base class");
    ////    }
    ////}

    ////public class Class1 : BaseClass
    ////{
    ////    //mathod hiding uses new void while overriding uses overide
    ////    public new void print()
    ////    {
    ////        Console.WriteLine("I am a derived class print method");
    ////    }
    //}

    internal class Program
    {
        public class student
        {
            private int _id;
            private string _Name;
            private int _Age;
            private int _PassMark = 45;
            //private string _city;
            //private string _email;
            public string Email
            {
                //auto implementation property
                get; set;
                //get 
                //{ 
                //    return _email; 
                //}
                //set 
                //{ 
                //    _email = value; 
                //}
            }
            //allows multiple types of object to be used interchangeably
            public string City
            {
                get; set;
                //get
                //{
                //    return _city;
                //}
                //set
                //{
                //    _city = value;
                //}

            }

            public int Passmark 
            {
                get 
                { 
                    return _PassMark; 
                }
            }


            public string Name

            {
               set
                    {
                    if (value == null || value == string.Empty)
                    {
                        throw new ArgumentNullException("Name should not be empty");
                    }
                    this._Name = value;

                }
                get 
                {
                    return string.IsNullOrEmpty(this._Name) ? "No Name werey!" : this._Name;
                    
                }
                
            }



            public int Id
            {
                set { 
                    //build in keyword
                    if (value <= 0)
                    {
                        throw new Exception("Student ID cannot be negative");

                    }
                    //value keyword will recive the value
                    this._id = value;
                }
                get
                {
                    return this._id;
                }
                
            }

        }
        static void Main(string[] args)
        {
            //encapsulation using c# properties //set and get properties
            //property with both get and set is a read/write property
            //property with only get accessor is a read only property
            //propery will only the set accessor is a write only property.
            student s = new student();
            s.Id = 1001;
            s.Name = "Mark";
            s.Email = "destinyobueh14@gmail.com";
            s.City = "Lagos";
            //encapsulation 

            Console.WriteLine($"Student ID - {s.Id}");
            Console.WriteLine($"Student Name - {s.Name}");
            Console.WriteLine($"Student Pass Mark - {s.Passmark}");
            Console.WriteLine($"Student City - {s.City}");
            Console.WriteLine($"Student Email - {s.Email}");




            //Console.WriteLine($"Id - {s.id} \nName - {s.name} \nAge - {s.age} \nPass Mark - {s.PassMark}");


            //BaseClass B = new Class1();
            //B.print();

            //Class1 C = new Class1();
            //C.print();



        }

        //value paramter = int FN3
        //signature method = name of the method type of parameter, number and kind of parameter 
        /* public static void Add(int FN, int FN2, int sum)
        {
            Console.WriteLine($"Sum - {FN + FN2}");
        }


        public static void Add(int FN, int FN2, out int sum)
            //out is output parameter... you can also override based on output parameter 
      {
            Console.WriteLine($"Sum - {FN + FN2}");
           //output parameters
           sum = FN + FN2;
            
      */
    }
    //method overloading allows aclass to have multiple methods with the same name but with a diff signature
    //you can onverload function based on the number of parameter and it's types
    //method can also be overloaded based on kind of paramters
    //it is not possible to overload based on return type, it is not also possible to change based on the params keyword


}