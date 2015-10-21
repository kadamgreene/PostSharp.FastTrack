using PostSharp.Patterns.Recording;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PostSharp.UndoRedo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ViewModel viewModel = new ViewModel();

        public ViewModel ViewModel
        {
            get { return viewModel; }
        } 


        public MainWindow()
        {
            InitializeComponent();
            RecordingServices.DefaultRecorder.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var scope = RecordingServices.DefaultRecorder.OpenScope("Info Changed"))
            {
                ViewModel.FirstName = "Atomic";
                ViewModel.LastName = "Change";
                ViewModel.Address.Street = "200 New St";
                scope.Complete();
            }
        }
    }
}
