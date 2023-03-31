namespace Structure_in_C_and_above
{
    internal class Program
    {
        public struct Customer
        {
            private int _id;
            private string _name;

            public string Name
            {
                set 
                { 
                    if(value == null || value == String.Empty)
                    {
                        throw new ArgumentNullException("value");
                    }
                    _name = value;
                }
                get
                { 
                    return string.IsNullOrEmpty(this._name) ? "No Name werey!" : this._name;
                }
            }
            public int ID
            {
                get
                {
                    return _id;

                }
                set
                {
                    _id = value;
                }
            }
            public Customer(int ID, string Name)
            {
                _id = ID;
                _name = Name;

            }

            public void printDetails()
            {
                Console.WriteLine($"Id - {ID} \nName - {Name}");
            }
        }
            static void Main(string[] args)
            {
            Customer customer = new Customer(1001, "Destiny Obs \n");
            customer.printDetails();

            //oject init syntax

            Customer customer2 = new Customer();
            customer2.ID = 1002;
            customer2.Name = "Young Cho \n";
            customer2.printDetails();

            //obj init syntax

            Customer customer3 = new Customer()
            {
                ID = 1003,
                Name = "Onye Bobo"
            };
            customer3.printDetails();

                /*structures in C
                 * justblike classes constructors can also have 
                 * private fields
                 * public properties
                 * constructors 
                 * methods
                 * creating a class use class keyword
                 * creating a structure use struct key word
                 */
            }
        }
    }