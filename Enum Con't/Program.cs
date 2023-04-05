namespace Enum_Con_t
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Enum = class
            //enum = is a keyword to create enumerations
            //trying to convert enum type

            //Type casting and conversion


            Gender gender = (Gender)3;
            int Num = Convert.ToInt32( Gender.Unkown);
            //explicit casting
            gender = (Gender)Season.winter;

            short[] Values = (short[])Enum.GetValues(typeof(Gender));

            foreach (short value in Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine($"\n");

            string[] Names = (string[])Enum.GetNames(typeof(Gender));
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            
        }
    }

    public enum Gender : short
    {
        //hidden type is int
        //it is possible to change the underlying type
        Unkown = 1,
        Female = 2,
        Male = 3
    }

    public enum Season
    {
        winter = 1,
        spring = 2,
        summer = 3
    }
}