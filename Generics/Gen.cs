﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Gen
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    public class Stack<T>
    {
        int index = 0;
        T[] innerArray = new T[100];

        public void Push(T item)
        {
            innerArray[index++] = item;
        }

        public T Pop()
        {
            return innerArray[-index];
        }

        public T Get(int k)
        {
            return innerArray[k];
        }
    }
}
