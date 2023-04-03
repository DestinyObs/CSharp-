namespace Explicit_Interface_Implimentation
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2 
    { 
        void InterfaceMethod();
    }
    internal class Program : I1, I2
    {
        public void InterfaceMethod() 
        {
            Console.WriteLine("Marry Me, Will You?");
        }
        //to make default just impliment that method normally
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I love you very much!!!");
        }
        static void Main(string[] args)
        {
            //program here is just an object reference varialble

            //can do that using method interfaces 

            Program p = new Program();
            p.InterfaceMethod();
            ((I2)p).InterfaceMethod();
            //I1 i1 = new Program();
            //I2 i2 = new Program();


            //i1.InterfaceMethod();
            //i2.InterfaceMethod();



            //((I1)program).InterfaceMethod();
            //((I2)program).InterfaceMethod();
            //type casting the interface name throught the instance 

        }
    }
}