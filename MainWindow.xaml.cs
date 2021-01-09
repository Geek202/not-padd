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

namespace padd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(String message)
        {
            InitializeComponent();
            Console.WriteLine(App.message);
            var box = (this.FindName("text") as TextBox);
            box.Text = message;
            box.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            box.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            box.Focus();
        }

        private void ButtonClicked(object sender, RoutedEventArgs e) {
            MessageBox.Show("hello, world!");
        }
    }
}
