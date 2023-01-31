using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class MyGeneric<T>
    {
        public T Value { get;set; }

        public override string? ToString()
        {
            return Value.ToString();
        }
    }
}
