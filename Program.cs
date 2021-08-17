using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee<string>
            {
                Id = "id",
                FirstName = "Fazrin",
                LastName = "Farook",
                Salary = "Monthly"
            };

            Console.WriteLine("Employee Id : " + emp.Id + ", First Name : " + emp.FirstName + ", Last Name : " + emp.LastName + ", Salary : " + emp.Salary);
            Console.ReadLine();
        }  
    }


    public class Employee<T> where T : class
    {
        public T Id { get; set; }
        public T FirstName { get; set; }
        public T LastName { get; set; }
        public T Salary { get; set; }
    }

}
