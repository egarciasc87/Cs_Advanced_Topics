using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamdomNumberDemo
{
    public class PersonModel
    {
        public string FirstName { get; set; }
    }


    public class RandomNumbers
    {
        public void ListRandomNumbers(Random random)
        {
            Console.WriteLine("How many numbers do you need?");
            string input = Console.ReadLine();
            int count = Int16.Parse(input);

            for (int i = 0; i < count; i++)
            {
                //Console.WriteLine("Number #" + (i + 1) + ": " + 
                //    random.Next(-10, 10));

                //SimpleMethod(random);

                Console.WriteLine(random.NextDouble() * 10);
            }
        }

        private void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next());
        }

        public void ListRandomPeople(Random random)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName = "Erick"},
                new PersonModel{FirstName = "Carlos"},
                new PersonModel{FirstName = "Juan"},
                new PersonModel{FirstName = "Sandra"},
                new PersonModel{FirstName = "Veronica"},
                new PersonModel{FirstName = "Luis"},
                new PersonModel{FirstName = "Lucia"},
                new PersonModel{FirstName = "Ernesto"}
            };

            var sortedPeople = people.OrderBy(p => random.Next());

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }
        }
    }
}
