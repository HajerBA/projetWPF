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
    /// Interaction logic for Exo6.xaml
    /// </summary>
    public partial class Exo6 : UserControl
    {
        public Exo6()
        {
            InitializeComponent();
            StackPanel stck1 = new StackPanel();
            TextBlock txtb1 = new TextBlock();
            txtb1.Text = "refaire 1 en c#";
            txtb1.FontSize = 32;
            stck1.Children.Add(txtb1);
            Button button = new Button();
            button.Content = "Go";
            button.Click += Button_Click;//add event
            stck1.Children.Add(button);
            maGrid.Children.Add(stck1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world!");
        }
    }
}
