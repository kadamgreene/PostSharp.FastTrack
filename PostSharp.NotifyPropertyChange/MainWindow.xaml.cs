using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PostSharp.NotifyPropertyChange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Person = new Person() { FirstName = "Adam", LastName = "Greene" };
            InitializeComponent();
        }

        public Person Person { get; set; }

        private void ChangeFirstName_Click(object sender, RoutedEventArgs e)
        {
            Person.FirstName = "Changed";
        }

        private void ChangeLastName_Click(object sender, RoutedEventArgs e)
        {
            Person.LastName = "Changed";
        }
    }
}
