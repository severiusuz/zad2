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
using System.Text.RegularExpressions;

namespace zad2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void razy_Click(object sender, RoutedEventArgs e)
        {
            wynik.Text = (double.Parse(var1.Text) * double.Parse(var2.Text)).ToString();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            wynik.Text = (double.Parse(var1.Text) - double.Parse(var2.Text)).ToString();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            wynik.Text = (double.Parse(var1.Text) + double.Parse(var2.Text)).ToString();
        }

        private void dziel_Click(object sender, RoutedEventArgs e)
        {
            var value1 = double.Parse(var1.Text);
            var value2 = double.Parse(var2.Text);
            if(value1 != 0 && value2 != 0)
            {
                wynik.Text = (value1 / value2).ToString();
            }
            else
            {
                wynik.Text = "Error";
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+(\\,)?([0-9]+)?$");
            e.Handled = !regex.IsMatch(e.Text);
        }
    }
}
