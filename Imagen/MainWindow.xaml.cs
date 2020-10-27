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

namespace Imagen
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


        private void fillBoton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
            
        }

        private void uniformBoton_Checked(object sender, RoutedEventArgs e)
        {

            imagen.Stretch = Stretch.Uniform;
            
        }

        private void ufillBoton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.UniformToFill;
        }

        private void noneBoton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }

        private void altaBoton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 1.0;
        }

        private void mediaBoton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.6;
        }

        private void bajaBoton_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.3;
        }
    }
}
