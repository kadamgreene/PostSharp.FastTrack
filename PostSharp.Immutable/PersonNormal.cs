using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharp.Immutable
{
    public class Person
    {
        public readonly string name;
        public readonly int age;

        public readonly Address address;

        public Person()
        {
            name = "Adam";
            age = 39;
            address = new Address { Street = "100 Main St" };
        }
    }

    public class Address
    {
        public string Street { get; set; }
    }
}
