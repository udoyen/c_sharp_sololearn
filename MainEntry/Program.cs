using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoloLearn;
using SoloLearn_Arrays_Strings;
using Class2;

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
            //Person p = new Person("George");
            //Console.WriteLine(p.GetName());

            //Person v = new Person();
            //v.Name = "Thomas";

            //Console.WriteLine(v.Name);

            //SecondPerson sp = new SecondPerson();
            //sp.Name = "July";
            //Console.WriteLine(sp.Name);

            //MyLoops mlp = new MyLoops();
            //mlp.GetDnum();

            //MyLoops mp = new MyLoops();
            //mp.GetRank();

            //PuppyDog d = new PuppyDog();

            //Cat c1 = new Cat();

            //Console.WriteLine(Cat.count);

            //PuppyDog.Bark();

            //Console.WriteLine(MathClass.ONE);

            //Clients c = new Clients();

            //c[0] = "George";
            //c[1] = "Uduak";

            //Console.WriteLine(c[1]);

            //Box b = new Box(14, 3);
            //Box b2 = new Box(5, 7);

            //Box b3 = b + b2;

            //Console.WriteLine(b3.Height);
            //Console.WriteLine(b3.Width);


            Student s = new Student("George");
            s.Speak();
            
            

            Console.ReadKey();
        }
    }
}
