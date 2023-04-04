namespace Custom_Exception
{
    using System.IO;
    using System.Reflection.PortableExecutable;
    using System.Runtime.Serialization;

    internal class Program
    {
        static void Main(string[] args)
        {
            // you create a custom exception if any of the dotnet exceptions does not adequately descibe your issue
            //an ecpetion is a class on itself
            //system.exception class is the base class for all exception

            try
            {
                throw new UserAlreadyLoggedIn("User is Logged in - No Dupe Session allowed");

            }
            catch(UserAlreadyLoggedIn ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }

    [Serializable]
    public class UserAlreadyLoggedIn : Exception
    {
        public UserAlreadyLoggedIn() 
            : base()
        {
        }
        public UserAlreadyLoggedIn(string message) : base(message)
            //communication from drived class to the base class using the base keyword
        {

        }
        //inner exception basicly allows us to crack original exception

        public UserAlreadyLoggedIn(string message, Exception innerException) : base(message, innerException)
        {

        }

        public UserAlreadyLoggedIn(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

        //i there are two applicationa andtghey want to interwct we use what is called application boudq
        //ry

    }
}