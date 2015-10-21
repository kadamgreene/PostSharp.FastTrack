using PostSharp.Patterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharp.Aggregatable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Name = "Adam Greene" };
            var addr1 = new Address() { Street = "100 Main St" };
            var addr2 = new Address() { Street = "200 Left St" };
            var addr3 = new Address() { Street = "300 Right St" };

            p.Addresses.Add(addr1);
            p.Addresses.Add(addr2);
            p.MainAddress = addr3;

            // Show that parent is automatically set
            Console.WriteLine("Parent Name: {0}", addr1.Parent.Name);

            //VisitChildren(p);

            ((IDisposable)p).Dispose();
        }

        private static void VisitChildren(Person p)
        {
            // Visit all Children
            IAggregatable agg = p as IAggregatable;
            agg.VisitChildren((child, childinfo, state) =>
            {
                if (child is Address)
                {
                    Console.WriteLine("Address is: {0}", ((Address)child).Street);
                }
                return true;
            });
        }
    }
}
