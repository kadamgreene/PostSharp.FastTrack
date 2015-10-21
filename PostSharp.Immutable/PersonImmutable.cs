using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Threading;
using PostSharp.Patterns.Model;

namespace PostSharp.Immutable
{
    [Immutable]
    public class Person
    {
        public string name;
        public int age;

        [Child]
        public Address address;

        public Person()
        {
            SetInformation();
        }

        private void SetInformation()
        {
            name = "Adam";
            age = 39;
            address = new Address { Street = "100 Main St" };
        }
    }

    [Freezable]
    public class Address
    {
        public string Street { get; set; }
    }
}
