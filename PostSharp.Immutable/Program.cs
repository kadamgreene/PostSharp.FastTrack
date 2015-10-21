using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharp.Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.address.Street = "new st";
        }
    }
}
