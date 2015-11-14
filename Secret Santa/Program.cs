using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>()
            {
                new Person() { Name = "Tich Showers" },
                new Person() { Name = "Adria Storm" },
                new Person() { Name = "Rayne Flash" },
                new Person() { Name = "Mist Showers" },
                new Person() { Name = "Altich Showers" },
            };

            list.ShuffleAssignees();

            foreach (var person in list)
            {
                Console.WriteLine("{0} was assigned {1}", person.Name, person.Assigned.Name);
            }

            Console.ReadKey();
        }
    }
}
