using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoloLearn;
using SoloLearn_Arrays_Strings;

namespace MainEntry
{
    
    /// <summary>
    /// Main entry point for the projects
    /// in SoloLearn solution
    /// </summary>
    class Program
    {
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


            Console.ReadKey();
        }
    }
}
