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

namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var redCommand = new RoutedCommand();
            var greenCommand = new RoutedCommand();
            var blueCommand = new RoutedCommand();

            CommandBindings.Add(new CommandBinding(redCommand, (sender, e) => button.Background = Brushes.Red));
            CommandBindings.Add(new CommandBinding(greenCommand, (sender, e) => button.Background = Brushes.Green));
            CommandBindings.Add(new CommandBinding(blueCommand, (sender, e) => button.Background = Brushes.Blue));

            InputBindings.Add(new KeyBinding(redCommand, new KeyGesture(Key.R, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(greenCommand, new KeyGesture(Key.G, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(blueCommand, new KeyGesture(Key.B, ModifierKeys.Control)));
        }
    }
}