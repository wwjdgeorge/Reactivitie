using MYTest;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MYTest
{
    delegate bool IsYoungerthan(Student student, int age);
    public class lamdaexpression
    {
        public void getage()
        {
            IsYoungerthan iy = (s, age) => s.Age < age;
            IsYoungerthan iy1 = (s, age) =>
            {
                Console.WriteLine("LAmda");
                return s.Age <= age;
            };

            Student std = new Student() { Age = 45 };
            //  () => Console.WriteLine("Parameter less lambda expression")
            Console.WriteLine(iy(std, 26));
        }

        public void getageFunc()
        {
            Func<Student, bool> isStudent = s => s.Age > 12;
            Student sdf = new Student() { Age = 11 };
            bool isTeen = isStudent(sdf);
            Console.WriteLine(isTeen);
        }

        public void getageAction()
        {
            Action<Student> isStudent = s => { Console.WriteLine(s.Name); };
            Student sdf = new Student() { Age = 11, Name = "Asas" };
            isStudent(sdf);

        }
        public void getageLamdadefault()
        {
            var IncrementBy = (int Source, int increment = 1) => Source + increment;
            Console.WriteLine(IncrementBy(1));
            Console.WriteLine(IncrementBy(2, 100));
        }
        public void getageLamdadefault1()
        {
            var sum = (params int[] values) =>
            {
                int sum = 0;
                foreach (int value in values)
                    sum += value;
                return sum;
            };
            var sequence = new int[] { 1, 2, 3 };
            Console.WriteLine(sum(sequence));
        }
        //Async Lamda
        //  button1.Click+==async (sender,e) =>{Await Ec(); };
    }
}