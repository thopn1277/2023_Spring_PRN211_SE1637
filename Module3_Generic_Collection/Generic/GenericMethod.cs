using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class GenericMethod
    {
        public void Display<A, B>(A p1, B p2)
        {
            Console.WriteLine($"{p1} : {p2}");
        }
    }
}
