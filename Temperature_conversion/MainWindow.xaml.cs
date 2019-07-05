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

namespace Temperature_conversion
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
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
        }

        private void MyTextbox(object sender, RoutedEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Width = 200;
        }

        private void x(object sender, RoutedEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Width = 200;
        }

        private void Temp_convert(object sender, RoutedEventArgs e)
        {
            double myTemp;
            double fahren_calc;
            double cels_calc;
            if (double.TryParse(tempInput.Text, out myTemp) &&
                (myTemp <= 100) &&
                (myTemp >= -100))
            {
                if (celsius.IsChecked == true)
                {
                    fahren_calc = (1.8 * myTemp) + 32;
                    lblResult.Content = fahren_calc;
                }

                else if (fahrenheit.IsChecked == true)
                {
                    cels_calc = (5f / 9f) * (myTemp - 32);
                    lblResult.Content = cels_calc;
                }

                else
                {
                    lblResult.Content = "Choose 'Celsius to Fahrenheit' or 'Fahrenheit to Celsius'";
                }
            }
            else if (myTemp > 100)
                lblResult.Content = "Molten lava! Choose a lower temperature";
            else if (myTemp < -100)
                lblResult.Content = "Surface of mars! Choose a higher temperature";
            else
                lblResult.Content = "That's not a number! Try again";
        }
    }
}
