using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    /// <summary>
    /// operator overloading class
    /// example
    /// </summary>
    public class Box
    {
        public int Height { get; set; }
        public int Width { get; set; }


        public Box(int h, int w)
        {
            Height = h;
            Width = w;
        }

        public static Box operator+(Box a, Box b)
        {
            int h = a.Height + b.Height;
            int w = a.Width + b.Width;

            Box res = new Box(h, w);

            return res;
        }
    }
}
