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

namespace _6_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void красный_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BoxCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
                Matrix m = new Matrix();
                m.Scale(8.1d, 9.1d);
                ((InkCanvas)sender).Strokes.Transform(m, true);

        }

        private void красный_Checked(object sender, RoutedEventArgs e)
        {
            BoxCanvas.DefaultDrawingAttributes.Color = Color.FromRgb(255, 0, 0);
        }

        private void синий_Checked(object sender, RoutedEventArgs e)
        {
            BoxCanvas.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 255);
        }

        private void зеленый_Checked(object sender, RoutedEventArgs e)
        {
            BoxCanvas.DefaultDrawingAttributes.Color = Color.FromRgb(0, 255, 0);
        }

        private void черный_Checked(object sender, RoutedEventArgs e)
        {
            BoxCanvas.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 0);
        }

        private void т1_Checked(object sender, RoutedEventArgs e)
        {
            BoxCanvas.DefaultDrawingAttributes.Width = 1;
            BoxCanvas.DefaultDrawingAttributes.Height = 1;
        }

        private void т2_Checked(object sender, RoutedEventArgs e)
        {
            BoxCanvas.DefaultDrawingAttributes.Width = 2;
            BoxCanvas.DefaultDrawingAttributes.Height = 2;
        }

        private void т4_Checked(object sender, RoutedEventArgs e)
        {
            BoxCanvas.DefaultDrawingAttributes.Width = 4;
            BoxCanvas.DefaultDrawingAttributes.Height = 4;
        }

        private void т8_Checked(object sender, RoutedEventArgs e)
        {
            BoxCanvas.DefaultDrawingAttributes.Width = 8;
            BoxCanvas.DefaultDrawingAttributes.Height = 8;
        }
    }
}
