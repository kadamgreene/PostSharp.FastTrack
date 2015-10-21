using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using PostSharp.Patterns.Threading;

namespace PostSharp.ReaderWriterLock
{
    public class Calc
    {
        public double FirstNumber { 
            get;
            set; 
        }

        public double SecondNumber {
            get;
            set; 
        }

        public void Add()
        {
            Console.Write("{0}", FirstNumber);
            Console.Write(" + ");
            Console.Write("{0}", SecondNumber);
            Thread.Sleep(50);
            Console.WriteLine(" = {0}", FirstNumber + SecondNumber);
        }
    }
}