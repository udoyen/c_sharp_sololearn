using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Person
    {

        private int age;
        private string name;

        public Person()
        {

        }

        public Person(string nm)
        {
            Console.WriteLine("Person constructor");

            name = nm;

        }


        public string GetName()
        {
            return name;
        }

        public string Name//property
        {
            get { return name; }
            set { name = value; }
        }


        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }
        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
