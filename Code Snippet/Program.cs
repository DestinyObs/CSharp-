
namespace Dictionaries
{
    using Microsoft.VisualBasic;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                ID = 152,
                Name = "Mark",
                Salary = 400,
                Type = "Retail Customer"
            };

            Customer customer2 = new Customer()
            {
                ID = 199,
                Name = "Destiny",
                Salary = 5500,
                Type = "Wholesale Customer"
            };

            Customer customer3 = new Customer()
            {
                ID = 201,
                Name = "Obs",
                Salary = 23400,
                Type = "Retail Customer"
            };

            Customer customer4 = new Customer()
            {
                ID = 211,
                Name = "Shegs",
                Salary = 9850,
                Type = "Wholesale Customer"
            };

            Customer customer5 = new Customer()
            {
                ID = 301,
                Name = "ChiChi",
                Salary = 2000,
                Type = "Wholesale Customer"
            };

            List<Customer> list = new List<Customer>();
            list.Add(customer4);
            list.Add(customer2);
            list.Add(customer5);

            List<Customer> listRetail = new List<Customer>();
            listRetail.Add(customer);
            listRetail.Add(customer3);

            listRetail.RemoveAll(x => x.Type == "Wholesale Customer");
            foreach(Customer cust in list)
            {
                Console.WriteLine($"ID = {cust.ID}\t Name = {cust.Name}\t Salary = {cust.Salary}\t Job-type = {cust.Type}");

            }


            //List<Customer> custo = list.GetRange(0, 3);

            //foreach (Customer cust in custo)
            //{
            //    Console.WriteLine($"ID = {cust.ID}\t Name = {cust.Name}\t Salary = {cust.Salary}\t Job-type = {cust.Type}");

            //}

            //Console.WriteLine("-----------------------------------------------------------------------------------------------------------");


            //list.AddRange(listReatil);
            //foreach(Customer cust in list)
            //{
            //    Console.WriteLine($"ID = {cust.ID}\t Name = {cust.Name}\t Salary = {cust.Salary}\t Job-type = {cust.Type}");

            //}

            //Customer[] cust =  list.ToArray();

            //foreach (Customer c in list)
            //{
            //    Console.WriteLine($"ID = {c.ID}\t Name = {c.Name}\t Salary {c.Salary}");

            //}

            /*
            Customer[] customers = new Customer[3];
            customers[0] = customer;
            customers[1] = customer2;
            customers[2] = customer3;

            List<Customer> ListCustomers = new List<Customer>();
            ListCustomers.Add(customer);
            ListCustomers.Add(customer2);
            ListCustomers.Add(customer3);


            int index = ListCustomers.FindLastIndex(cust => cust.Salary > 500);

            Console.WriteLine("Index = " + index);
            */
            //if(ListCustomers.Exists(cust => cust.Name.StartsWith("D")))
            //{
            //    Console.WriteLine("Customer3 object exits in the lsit");
            //}
            //else
            //{ 
            //    Console.WriteLine("Customer3 object does not exits in the lsit");

            //}


            //to change an array to lisgt w we use what is called to list
            //converting arry to list
            /*
            Customer[] customerArray = new Customer[3];
            customerArray[0] = customer;
            customerArray[1] = customer2;
            customerArray[2] = customer3;

            List<Customer> ListCustomer = customerArray.ToList();

            foreach(Customer c in ListCustomer)
            {
                Console.WriteLine($"ID = {c.ID}\t Name = {c.Name}\t Salary {c.Salary}");

            }
            */



            //conversion to dictionary
            //Dictionary<int, Customer> dict = customers.ToDictionary(cust => cust.ID, cust => cust);

            //foreach(KeyValuePair<int, Customer> kvp in dict)
            //{
            //    Console.WriteLine(kvp.Key);
            //    Customer cust = kvp.Value;
            //    Console.WriteLine(cust.Name);
            //    Console.WriteLine(cust.Salary);
            //    Console.WriteLine("----------------------------------------");

            //}

            //Dictionary<int, Customer> dictionariesCustomer = new Dictionary<int, Customer>();
            //dictionariesCustomer.Add(customer.ID, customer);
            //dictionariesCustomer.Add(customer2.ID, customer2);
            //dictionariesCustomer.Add(customer3.ID, customer3);

            //Console.WriteLine($"{dictionariesCustomer.Count(kvp => kvp.Value.Salary > 5000)}");

            //Customer cust;
            //if( dictionariesCustomer.TryGetValue(199, out cust))
            //{
            //    Console.WriteLine($"ID = {cust.ID}, Name = {cust.Name}, Salary {cust.Salary}");
            //}
            //else
            //{
            //    Console.WriteLine("Key Does not exits");
            //}




            //if (!dictionariesCustomer.ContainsKey(customer.ID))
            //{
            //    dictionariesCustomer.Add(customer.ID, customer3);
            //}

            //Customer customer119 = dictionariesCustomer[199];

            //foreach (Customer cust in dictionariesCustomer.Values)
            //{
            //    //Console.WriteLine(Keys);
            //    //Console.WriteLine( "ID = " + CustomerKeyValuePair.Key);
            //    //Customer cust = CustomerKeyValuePair.Value;
            //    Console.WriteLine($"ID = {cust.ID}, Name = {cust.Name}, Salary = {cust.Salary}");
            //    Console.WriteLine("-------------------------------------------------------------");
            //}
            //keys must be unique
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int ID { get; set; }
        public string Type { get; set; }
    }
}