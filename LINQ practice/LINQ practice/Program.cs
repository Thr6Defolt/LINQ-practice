using System;

namespace LINQ_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LINQ test = new LINQ();

            test.Numbers();

            List<Person> people = new List<Person>();

            for (int i = 1; i <= 20; i++)
            {
                people.Add(new Person { Name = $"Person{i}", Age = new Random().Next(18, 60), Id = i });
            }

            var filteredPeople = people.Where(p => p.Age > 20).ToList();

            foreach (var p in filteredPeople)
            {
                Console.WriteLine(p.Name);
            }

            var penultimateElement = GetPenultimateElement(filteredPeople);
        }

        static T GetPenultimateElement<T>(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            return collection.Skip(Math.Max(0, collection.Count() - 2)).Take(1).FirstOrDefault();
        }
    }
}