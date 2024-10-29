using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdvancedColorPicker
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

        public void ChangeColor(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            colorName.Text = $"Current color: {e.NewValue}";
            this.Background = new SolidColorBrush(e.NewValue ?? Colors.White);
        }

        public void ChangeColor2(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int f1 = rnd.Next(1, 256);
            int f2 = rnd.Next(1, 256);
            int f3 = rnd.Next(1, 256);
            colorName2.Foreground = new SolidColorBrush(Color.FromRgb((byte)f1, (byte)f2, (byte)f3));
        }
    }
}