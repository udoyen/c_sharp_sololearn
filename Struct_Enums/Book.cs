using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Enums
{

    public enum Days
    {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat
    };

    public enum TrafficLights
    {
        Green, Red, Yellow
    };

    /// <summary>
    /// struct object to be created without the 
    /// new keyword.
    /// </summary>
    public struct Book
    {
        public string title;
        public double price;
        public string author;
    }

    /// <summary>
    /// struct object to be created
    /// using the 'new' keyword.
    /// </summary>
    public struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
