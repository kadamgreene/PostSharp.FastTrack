using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Model;
using PostSharp.Patterns.Collections;

namespace PostSharp.Aggregatable
{
    [Disposable]
    public class Person
    {
        public Person()
        {
            Addresses = new AdvisableCollection<Address>();
        }

        public string Name { get; set; }

        [Child]
        public AdvisableCollection<Address> Addresses { get; set; }

        [Reference]
        public Address MainAddress { get; set; }
    }

    [Aggregatable]
    public class Address : Disposable
    {
        private Guid id;
        public Address()
        {
            this.id = Guid.NewGuid();
        }

        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postal { get; set; }

        [Parent]
        public Person Parent { get; set; }

        private bool disposed = false;

        protected override void Dispose(bool dispose)
        {
            Console.WriteLine("Address disposed: {0}", id);
        }
    }
}
