namespace Inner_Exception
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //inner excpetion property returns the exception instance that caused the current exception
                try
                {
                    Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    double Result = FN / SN;

                    Console.WriteLine($"Result = {Result}");

                }
                catch (Exception ex)
                {
                    string filePath = @"C:\\Users\\USER\\Desktop\\c# tutorial.txt";
                    if (File.Exists(filePath))
                    {

                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().FullName);
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem please try later");
                    }
                    else
                    {
                        //throw an exception we use the throw keyword
                        throw new FileNotFoundException(filePath + "Isnot present", ex);

                    }

                }
            }
            catch(Exception exx) 
            {
                Console.WriteLine($" Current Exception =  {exx.GetType()}");
                if (exx.InnerException != null)
                {

                    Console.WriteLine($" Inner Exception =  {exx.InnerException.GetType().Name}");
                }

            }

            }

        }    
}