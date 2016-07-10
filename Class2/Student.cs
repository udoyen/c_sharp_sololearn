using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public class Student : MyPerson
    {
        public Student(string nm)
        {
            Name = nm;
        }

        public void Speak()
        {
            Console.WriteLine("Name: " + Name);
        }
    }
}
