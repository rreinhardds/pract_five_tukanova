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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<SolidColorBrush> brushes;
        private Random rnd; 
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Туканова Елизавета", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Click_exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rnd = new Random();
            brushes = new List<SolidColorBrush> 
            {
              Brushes.LawnGreen,
              Brushes.Pink,
              Brushes.Violet,
              Brushes.Aquamarine
              };
            window.Background = brushes[rnd.Next(brushes.Count)];
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Colors.Green);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Colors.Red);
        }
    }
}
