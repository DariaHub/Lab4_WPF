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

namespace Lab4_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbVsp.Text = "";
            
        }
        string One = "";
        private void tbMain_Initialized(object sender, EventArgs e)

        {
            One += "Initialized\n";
            
        }

        private void tbMain_Loaded(object sender, RoutedEventArgs e)
        {
            One += "Loaded\n";
        }

        private void tbVsp_Loaded(object sender, RoutedEventArgs e)
        {
            tbVsp.Text += One;
        }

        private void tbMain_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            tbVsp.Text += "MouseDoubleClick\n";
        }

        private void tbMain_MouseDown(object sender, MouseButtonEventArgs e)
        {
            tbVsp.Text += "MouseDown\n";
        }


        private void tbMain_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbVsp.Text += "TextChanged\n";
        }

        private void tbMain_Unloaded(object sender, RoutedEventArgs e)
        {
            tbVsp.Text += "Unloaded\n";
        }

        private void tbMain_GotFocus(object sender, RoutedEventArgs e)
        {
            tbVsp.Text += "GotFocus\n";
        }

        private void tbMain_LostFocus(object sender, RoutedEventArgs e)
        {
            tbVsp.Text += "LostFocus\n";
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            tbVsp.Visibility = Visibility.Hidden;
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            tbVsp.Visibility = Visibility.Visible;
        }
    }
}
