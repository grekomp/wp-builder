using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = "Haba";
            person1.lastName = "Baba";

            Phone phone1 = new Phone();
            phone1.number = "601234012";
            phone1.area = "032";

            Template template1 = new Template();

            PersonBuilder builder = new PersonBuilder();
            builder.template = template1;
            builder.person = person1;
            builder.phone = phone1;

            builder.build();

            Console.ReadKey();
        }
    }
}
