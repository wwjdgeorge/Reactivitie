using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYTest
{
    public class linqSample
    {
        public static void SampleLinq()
        {
            List<int> list = new List<int>() { 1, 2, 3, 5, 7 };
            IEnumerable<int> evenNum = from num in list
                                       where num % 2 == 0
                                       select num;
        }
        public static void SampleLinq1()
        {
            var students = new List<Student>()
            {
                new Student { Id = 1, Name = "John", Age = 20 },
                new Student { Id = 2, Name = "Alice", Age = 19 }
            };
            var result = from student in students
                         where student.Age > 90
                         orderby student.Name ascending
                         select student.Name;
        }

        public static void SampleLinq2()
        {
            var students = new List<Student>()
            {
                new Student { Id = 1, Name = "John", Age = 20, Class ="fdd"},
                new Student { Id = 2, Name = "Alice", Age = 19,Class ="fdd" },
                new Student { Id = 3, Name = "Alice", Age = 19,Class ="edd" }
            };
            var result = from student in students
                         where student.Age > 0
                         group student by student.Class into studentClass
                         select new { Class = studentClass.Key, Students = studentClass };
            foreach (var e in result)
            {
                Console.WriteLine(e.Class);
                //Console.WriteLine(Repeat('-', x));
                foreach (var student in e.Students)
                {
                    Console.WriteLine(student.Name);
                }
            }

            //  var custQuery = from cust in NDC.Customers group cust by cust.City into custGroup where custGroup.Count() > 2 select custGroup;
        }
        public static void SampleLinq3()
        {
            List<Student> students = new List<Student>()
            { new Student { Id = 1, Name = "Abhimanyu K Vatsa", Address = "Bokaro", Marks = new List<int> { 97, 92, 81, 90 } },
                new Student { Id = 2, Name = "Deepak Kumar", Address = "Dhanbad", Marks = new List<int> { 70, 56, 87, 69 } },
                new Student { Id = 3, Name = "Mohit Kumar", Address = "Dhanbad", Marks = new List<int> { 78, 76, 81, 56 } },
                new Student { Id = 4, Name = "Geeta K", Address = "Bokaro", Marks = new List<int> { 95, 81, 54, 67 } }
            };
            List<Teacher> teachers = new List<Teacher>()
            { new Teacher { ID = 1, Name = "Ranjeet Kumar", Address = "Bokaro" },
                new Teacher { ID = 2, Name = "Gopal Chandra", Address = "Dhanbad" }
            };
        }
        public static void SampleLinq4()
        {
            int[] numbers = { 0, 30, 20, 15, 90, 85, 40, 75 };

            IEnumerable<int> query =
                numbers.Where((number, index) => number <= index * 10);

            foreach (int number in query)
            {
                Console.WriteLine(number);
            }
        }
    }
}
//var custQuery = from cust in NDC.Customers
//                join emp in NDC.Employees on cust.City equals emp.City 
//                select new { CityName = cust.City, CustomerName = cust.ContactName, EmployeeName = emp.FirstName };