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
    /// Interaction logic for Exo7.xaml
    /// </summary>
    public partial class Exo7 : UserControl
    {
        public Exo7()
        {
            InitializeComponent();
            TextBlock txtb1 = new TextBlock();
            txtb1.Text = "Afficher une listebox en XAML rempli par le C#";
            txtb1.FontSize = 32;
            listPays.Items.Add("France");
            listPays.Items.Add("Espagne");
            listPays.Items.Add("Tunisie");
           
            GridExo7.Children.Add(txtb1);
        }
    }
}
