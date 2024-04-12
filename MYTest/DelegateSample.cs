using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYTest
{
    public class DelegateSample
    {
        //public delegate bool IsEvenDelegate(int x);
        //public static bool getEvenNumber(int num)
        //{
        //    return num % 2 == 0;
        //}
        //IsEvenDelegate isEvenNumber = getEvenNumber;
        //List<int> list123 = new List<int>() { 2,4,6,7,3,7,34};
        //IEnumerable<int> list2 = list123.Where(i => isEvenNumber(i));

        public delegate bool IsEvenDelegate(int number);

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static void IsOdd(int number)
        {
            IsEvenDelegate isEvenDel = IsEven;
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

              IEnumerable<int> evenNumbers = numbers.Where(n => isEvenDel(n));

            List<string> names = new List<string> { "Alice", "Bob", "Carol", "David" };
            IEnumerable<string> numbersEnumerable = names.Where(n => n.StartsWith('c'));

        }
    }
}
