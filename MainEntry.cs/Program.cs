using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoloL

namespace MainEntry.cs
{
    class Program
    {


        static int Pow(int x, int y = 2)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }

            return result;

        }


        static int calc(int from, int to, int step = 1)
        {
            int res = 0;
            for (int i = from; i < to; i += step)
            {
                res += i;
            }

            return res;
        }

        static void Main(string[] args)
        {

            Person p = new Person("George");
            Console.WriteLine(p.GetName());

            Person v = new Person();
            v.Name = "Thomas";

            Console.WriteLine(v.Name);

            SecondPerson sp = new SecondPerson();
            sp.Name = "July";
            Console.WriteLine(sp.Name);

            MyLoops mlp = new MyLoops();
            mlp.GetDnum();
        }
    }
}
