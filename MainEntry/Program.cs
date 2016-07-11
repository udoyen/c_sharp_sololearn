using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoloLearn;
using SoloLearn_Arrays_Strings;
using Class2;
using Struct_Enums;
using Files;
using Generics;

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


            //Student s = new Student("George");
            //s.Speak();

            //MyDog md = new MyDog();

            //Shape c = new Circle();
            //c.Draw();

            //Shape r = new Rectangle();
            //r.Draw();

            //IShape ic = new Circle2();
            //ic.Draw();

            //Book b; // instantiatiing struct without the 'new' keyword
            //b.title = "Test";
            //b.price = 5.99;
            //b.author = "George";

            //Console.WriteLine(b.title);

            //Point p = new Point(10, 15);

            //Console.WriteLine(p.x);


            //int x = (int)Days.Tue;

            //Console.WriteLine(x);


            //TrafficLights x2 = TrafficLights.Red;

            //switch (x2)
            //{
            //    case TrafficLights.Green:
            //        Console.WriteLine("Go!");
            //        break;
            //    case TrafficLights.Red:
            //        Console.WriteLine("Stop!");
            //        break;
            //    case TrafficLights.Yellow:
            //        Console.WriteLine("Caution!");
            //        break;

            //}


            //try
            //{
            //    int[] arr = new int[] { 4, 5, 8 };
            //    Console.WriteLine(arr[8]);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("An error occurred: " + e.Message);

            //}


            //int[] arr1 = { 2, 5, 3 };
            //int x3 = 0;
            //try
            //{
            //    x3 = arr1[5];
            //}
            //catch (Exception e)
            //{

            //    x3 = arr1[x3];
            //}


            //int result = 0;
            //int num1 = 8;
            //int num2 = 4;

            //try
            //{
            //    result = num1 / num2;
            //}
            //catch (DivideByZeroException e)
            //{

            //    Console.WriteLine("Error");
            //}
            //finally
            //{
            //    Console.WriteLine(result);
            //}

            //MyFile mf = new MyFile();
            //mf.fileWrite();
            //mf.fileRead();

            
            int a = 4, b = 9;

            Gen.Swap<int>(ref a, ref b);

            string x = "Hello";
            string y = "World";

            Gen.Swap<string>(ref x, ref y);

            Generics.Stack<int> intStack = new Generics.Stack<int>();

            Generics.Stack<string> strStack = new Generics.Stack<string>();

            Generics.Stack<MyPerson> MyPersonStack = new Generics.Stack<MyPerson>();






            



            Console.ReadKey();
        }
    }
}
