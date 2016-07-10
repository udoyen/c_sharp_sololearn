using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public class PuppyDog
    {
        public PuppyDog()
        {
            Console.WriteLine("Constructor");
        }

        ~PuppyDog()
        {
            Console.WriteLine("Destructor");
        }

        public static void Bark()
        {
            Console.WriteLine("Woof");
        }

    }
}
