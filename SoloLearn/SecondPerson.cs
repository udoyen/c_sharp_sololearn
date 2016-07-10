using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    public class SecondPerson
    {
        public SecondPerson()
        {
            Console.WriteLine("Second person");
        }

        // auto-implemented property
        // for quickly creating a class private 
        // field accessed only through
        // this means

        public string Name { get; set; }
    }
}
