using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDesignFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestPerson();

            Console.ReadKey();

        }

        private static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Person p = new Person()
                {
                    FirstName = "Julie",
                    LastName = "Andrew",
                    MidleName = "T",
                    TelephonNumber = "1234567890"
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }

    }
}
