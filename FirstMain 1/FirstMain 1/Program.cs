namespace FirstMain_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int Total = 0;
             int Product = 0;

             Add(10, 20, out Total, out Product);

             Console.WriteLine($"sunans = {Total} && Product = {Product}");
            */

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

        }

        /*public static void Add(int x, int y, out int sum, out int Product) 
        { 
            sum = x + y;
            Product = x * y;
        }
        */

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