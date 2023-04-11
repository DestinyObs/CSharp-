namespace Method_paramters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ways to make method parameters arrays
            //method overlaoding 
            //specify parameter ddefaults
            //use optionalAttributes 

            AddNum(10, 20, new int[] { 30, 50 });

        }
        public static void AddNum(int FNum, int SNum)
        {
            AddNum(FNum, SNum, null);

        }


        public static void AddNum(int FNum, int SNum, params int[] RON)
        {
            int result = FNum + SNum;
            if (RON != null)
            {
                foreach (int i in RON)
                {
                    result += i;

                }

            }
            Console.WriteLine("Sum = " + result);
        }
    }
}