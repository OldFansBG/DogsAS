using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
        {
            new Dog("Breed1", "Alice", "Dog1", 10.0),
            new Dog("Breed2", "Bob", "Dog2", 20.0),
            new Dog("Breed3", "Charlie", "Dog3", 30.0),
            new Dog("Breed4", "David", "Dog4", 40.0),
            new Dog("Breed5", "Eve", "Dog5", 50.0)
        };

            // Изведете всички кучета във възходящ ред
            var orderedDogs = dogs.OrderBy(d => d.Name);
            foreach (var dog in orderedDogs)
            {
                Console.WriteLine(dog);
            }

            // Изведете кучетата, които има стопанин, чието име започва с “A”
            var dogsWithOwnerStartingWithA = dogs.Where(d => d.Owner.StartsWith("A"));
            foreach (var dog in dogsWithOwnerStartingWithA)
            {
                Console.WriteLine(dog);
            }

            // Изведете кучетата, чийто собственик има име с повече от четири и по-малко от осем символа
            var dogsWithOwnerNameLengthBetween4And8 = dogs.Where(d => d.Owner.Length > 4 && d.Owner.Length < 8);
            foreach (var dog in dogsWithOwnerNameLengthBetween4And8)
            {
                Console.WriteLine(dog);
            }
        }
    }

}