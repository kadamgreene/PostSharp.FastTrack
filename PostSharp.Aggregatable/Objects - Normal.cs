using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Model;
using PostSharp.Patterns.Collections;
using System.Collections.ObjectModel;

namespace PostSharp.Aggregatable
{
    public class Person : IDisposable
    {
        private  List<Address> addresses;

        public Person()
        {
            this.addresses = new List<Address>();
        }

        public string Name { get; set; }

        public ReadOnlyCollection<Address> Addresses { 
            get 
            {
                return new ReadOnlyCollection<Address>(addresses);
            } 
        }

        public Address MainAddress { get; set; }

        public void AddAddress(Address address)
        {
            address.Parent = this;
            addresses.Add(address);
        }

        public void Dispose()
        {
            addresses.ForEach(x => { ((IDisposable)x).Dispose(); });
            MainAddress.Dispose();
        }
    }

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

        public Person Parent { get; set; }

        protected override void Dispose(bool dispose)
        {
            Console.WriteLine("Address disposed: {0}", id);
        }
    }
}
