using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_practice
{
    internal class LINQ
    {
        public int Numbers()
        {
            List<int> numbers = Enumerable.Range(1, 100).ToList();

            var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

            foreach (int number in oddNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Конец");

            var squares = numbers.Select(n => n * n).ToList();

            foreach (int number in squares)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Конец");

            int sum = numbers.Sum();

            Console.WriteLine("Сума" + sum);

            return 0;
        }

    }
}
