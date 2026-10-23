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

namespace OopPrac2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num = 10;
            odemo.changevalue(ref num);
            MessageBox.Show($"After Ref:{num}".ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int nums;
           odemo.getvalue(out nums);
           MessageBox.Show($" After out {nums}".ToString());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int num = 45;
           odemo.readvalue(in num);
           MessageBox.Show($"after IN {num}".ToString());

        }
    }
}