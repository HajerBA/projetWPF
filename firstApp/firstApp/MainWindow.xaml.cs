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

namespace firstApp
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
            MessageBox.Show("XAML cours");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Hidden;
            Main.Content = new Exo1();
        }
        

        private void ImgRetour_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = null;
            MainContent.Visibility = Visibility.Visible;

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Hidden;
            Main.Content = new Exo2();

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Hidden;
            Main.Content = new Exo3();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Hidden;
            Main.Content = new Exo4();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Hidden;
            Main.Content = new Exo6();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Hidden;
            Main.Content = new Exo7();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Hidden;
            Main.Content = new Exo8();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Hidden;
            Main.Content = new Exo9();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Hidden;
            Main.Content = new Exo10();
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            MainContent.Visibility = Visibility.Hidden;
            Main.Content = new Exo10b();
        }
    }
}
