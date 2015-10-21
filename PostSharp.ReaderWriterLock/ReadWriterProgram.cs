using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostSharp.ReaderWriterLock
{
    class ReadWriterProgram
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            
            Console.Write("Enter First Number: ");
            var num1 = Console.ReadLine();
            c.FirstNumber = Double.Parse(num1);

            Console.Write("Enter Second Number: ");
            var num2 = Console.ReadLine();
            c.SecondNumber = Double.Parse(num2);

            var t1 = Task.Factory.StartNew(() => c.Add());
            var t2 = Task.Factory.StartNew(() => c.SecondNumber /= 2);

            Task.WaitAll(t1, t2);
            Console.ReadLine();
        }
      }
}
