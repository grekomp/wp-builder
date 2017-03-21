using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PersonBuilder
    {
        public Template template;
        public Person person;
        public Phone phone;

        public PersonBuilder build()
        {
            if (template == null || person == null || phone == null) throw new Exception("Error: Missing data or template");

            string builtString = template.templateString;

            builtString = builtString.Replace("<<Person.firstName>>", person.firstName);
            builtString = builtString.Replace("<<Person.lastName>>", person.lastName);

            Console.WriteLine(builtString);

            return this;
        }
    }
}
