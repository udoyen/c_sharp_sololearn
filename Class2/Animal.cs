using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal created");
        }

        ~Animal()
        {
            Console.WriteLine("Animal deleted");
        }
    }
}
