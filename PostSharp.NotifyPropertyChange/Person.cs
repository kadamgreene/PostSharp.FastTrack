using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using PostSharp.Patterns.Model;

namespace PostSharp.NotifyPropertyChange
{
    [NotifyPropertyChanged]
    public class Person
    {
        public Person()
        {
        }

        public string LastName
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
