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
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ComboBoxItem_Selected_Red(object sender, RoutedEventArgs e)
        {
            InCnvs.DefaultDrawingAttributes.Color = Colors.Red;
        }
        private void ComboBoxItem_Selected_Green(object sender, RoutedEventArgs e)
        {
            InCnvs.DefaultDrawingAttributes.Color = Colors.Green;
        }
        private void ComboBoxItem_Selected_Blue(object sender, RoutedEventArgs e)
        {
            InCnvs.DefaultDrawingAttributes.Color = Colors.Blue;
        }
        private void ComboBoxItem_Selected_Purple(object sender, RoutedEventArgs e)
        {
            InCnvs.DefaultDrawingAttributes.Color = Colors.Purple;
        }

        private void ComboBoxItem_Selected_Yellow(object sender, RoutedEventArgs e)
        {
            InCnvs.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void ComboBoxItem_Selected_Grey(object sender, RoutedEventArgs e)
        {
            InCnvs.DefaultDrawingAttributes.Color = Colors.Gray;
        }


        private void ComboBoxItem_Selected_BlueLig(object sender, RoutedEventArgs e)
        {
            InCnvs.DefaultDrawingAttributes.Color = Colors.LightBlue;
        }
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            if (sizeLable == null) return;
            sizeLable.Text = slider.Value.ToString();
            InCnvs.DefaultDrawingAttributes.Width = slider.Value;
            InCnvs.DefaultDrawingAttributes.Height = slider.Value;
        }
        private void RadioButton_Boot3_Click_Edit(object sender, RoutedEventArgs e)
        {
            InCnvs.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
        private void RadioButton_Boot3_Click_Delete(object sender, RoutedEventArgs e)
        {
            InCnvs.Strokes.Clear();
        }

        private void Rb1_Click(object sender, RoutedEventArgs e)
        {
            InCnvs.EditingMode = InkCanvasEditingMode.InkAndGesture;
        }
    }
}
