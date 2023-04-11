namespace Students_class
{

    internal class Program
    {
        public static List<StudentClass> ReturnStudent()
        {
            StudentClass student = new StudentClass()
            {
                Id = 1,
                Name = "Ugochukwu",
                Mat_Num = "20CD005829",
                Dept = "Computer"
            };

            StudentClass student1 = new StudentClass()
            {
                Id = 2,
                Name = "Obafemi",
                Mat_Num = "20CD003818",
                Dept = "English"
            };

            StudentClass student2 = new StudentClass()
            {
                Id = 3,
                Name = "Destiny",
                Mat_Num = "20CD003451",
                Dept = "PHd"
            };

            StudentClass student3 = new StudentClass()
            {
                Id = 4,
                Name = "Shola",
                Mat_Num = "20CD007630",
                Dept = "Maths"
            };

            StudentClass student4 = new StudentClass()
            {
                Id = 5,
                Name = "Moyo",
                Mat_Num = "20CD000023",
                Dept = "Computer"
            };

            StudentClass student5 = new StudentClass()
            {
                Id = 6,
                Name = "Stone",
                Mat_Num = "20CD004311",
                Dept = "DataBase"
            };

            StudentClass student6 = new StudentClass()
            {
                Id = 7,
                Name = "Abdul",
                Mat_Num = "20CD007650",
                Dept = "Python"
            };

            List<StudentClass> students = new List<StudentClass>();
            students.Add(student);
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);

            return students;
            //foreach (StudentClass studenclass in students)
            //{
            //    Console.WriteLine($"ID = {studenclass.Id}\t Name = {studenclass.Name}\t Salary = {studenclass.Mat_Num}\t Job-type = {studenclass.Dept}");
            //    Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            //}


        }





        static void Main(string[] args)
        {
           var list = ReturnStudent();
            int i = 0;
            foreach (StudentClass studenclass in list)
            {
                Console.WriteLine($"{i+1}. ID = {studenclass.Id}\t Name = {studenclass.Name}\t Salary = {studenclass.Mat_Num}\t Job-type = {studenclass.Dept}");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                i++;
            }

        }
    }
    public class StudentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mat_Num { get; set; }
        public string Dept { get; set; }
    }

}