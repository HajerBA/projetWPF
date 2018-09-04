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
    /// Interaction logic for Exo8.xaml
    /// </summary>
    public partial class Exo8 : UserControl
    {
        public Exo8()
        {
            InitializeComponent();
           
            txtb2.Text = "Afficher une combobox en XAML rempli par le C#";
            txtb2.FontSize = 32;
            Listderolant.Items.Add("Faire l'exo");
            Listderolant.Items.Add("Reviser pour la certif");
            Listderolant.Items.Add("Avoir Mon CDI");
           
        }
    }
}
