using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PostSharp.Custom.Services
{
    public class GreetingsService
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name);
            Thread.Sleep(1000);
        }

        public void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye, " + name);
            Thread.Sleep(1000);
        }
    }
}
