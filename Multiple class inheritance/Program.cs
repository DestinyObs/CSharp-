namespace Multiple_class_inheritance
{
    interface IA
    {
        void AMethod();
    }

    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }

    }

    interface IB
    {
        void BMethod();
    }

    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }

    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AB aB = new AB();
            aB.AMethod();
            aB.BMethod();

        }
    }
}