using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public class MyDog : Animal
    {
        public MyDog()
        {
            Console.WriteLine("MyDog created");
        }

        ~MyDog()
        {
            Console.WriteLine("MyDog deleted");
        }
    }
}
