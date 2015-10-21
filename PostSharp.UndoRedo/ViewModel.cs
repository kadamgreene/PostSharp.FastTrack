using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Model;
using PostSharp.Patterns.Recording;
using System.ComponentModel;

namespace PostSharp.UndoRedo
{
    [Recordable]
    [NotifyPropertyChanged]
    public class ViewModel
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public ViewModel()
        {
            FirstName = "Original";
            LastName = "Name";
            Address = new Address { Street = "100 Main St" };
        }

        [Child]
        public Address Address { get; set; }
    }

    [Recordable]
    [NotifyPropertyChanged]
    public class Address
    {
        public string Street { get; set; }
    }
}
