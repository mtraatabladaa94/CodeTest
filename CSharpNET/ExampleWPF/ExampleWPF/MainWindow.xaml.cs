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

namespace ExampleWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Saludar(string Nombre = "")
        {
            MessageBox.Show("Hola como estas" + (!String.IsNullOrWhiteSpace(Nombre) ? (" " + Nombre) : "") +"?", "Prueba WPF", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            this.Saludar(TestTextBox.Text);
        }
    }
}
