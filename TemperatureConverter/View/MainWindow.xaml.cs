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

namespace View
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

        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            var doubleFaren = double.Parse(FahrenheitBox.Text);
            var celsius = (doubleFaren - 32) / 1.8;
            var kelvin = celsius + 273.15;
            CelsiusBox.Text = celsius.ToString();
            KelvinBox.Text = kelvin.ToString();
        }
        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            var doubleCelsius = double.Parse(CelsiusBox.Text);
            var faren = (doubleCelsius * 1.8) + 32;
            FahrenheitBox.Text = faren.ToString();
            KelvinBox.Text = (doubleCelsius+273.15).ToString();
        }
        private void ConvertKelvin(object sender, RoutedEventArgs e) {
            var kelvin = double.Parse(KelvinBox.Text);
            CelsiusBox.Text = (kelvin - 273.15).ToString();
            FahrenheitBox.Text = ((kelvin - 273.15) * 1.8 + 32).ToString();
        }
    }
}
