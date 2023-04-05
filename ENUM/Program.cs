namespace ENUM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //it makes your program more maintainable
            //strictly typed
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Mary",
                Gender = Gender.Unkown
            };

            customers[1] = new Customer
            {
                Name = "Sam",
                Gender = Gender.Female
            };

            customers[2] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Name - {customer.Name} \tGender - {customer.Gender}");

            }

        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unkown:
                    return "Unkown";
                case Gender.Female:
                    return "Female";
                case Gender.Male:
                    return "Male";
                default:
                    return "Invalid Data Detected";
            }
        }
    }


    //ENUMS arw value types 
    //ENUMS help your code to be readable

    //enums keyword will all be in small letter, it is used to 
    public enum Gender
    {
        Unkown,
        Female,
        Male,
    }

    //defaulted type for Enums is int

    //0 - Gender is Uknown
    //1 - Female
    //2 - Male
    public class Customer
    {
        public string ?Name { get; set; }
        public Gender Gender { get; set; }

    }
}