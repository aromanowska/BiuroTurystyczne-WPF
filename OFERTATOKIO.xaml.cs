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
using System.Windows.Shapes;

namespace BiuroTurystyczne
{
    /// <summary>
    /// Logika interakcji dla klasy OFERTATOKIO.xaml
    /// </summary>
    public partial class OFERTATOKIO : Window
    {
        public OFERTATOKIO()
        {
            InitializeComponent();
        }

        private void OFERTA7_Click(object sender, RoutedEventArgs e)
        {
            OFERTA7 sw = new OFERTA7();
            sw.Show();
        }

        private void OFERTA6_Click(object sender, RoutedEventArgs e)
        {
            OFERTA6 sw = new OFERTA6();
            sw.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
