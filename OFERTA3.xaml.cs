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
    /// Logika interakcji dla klasy OFERTA3.xaml
    /// </summary>
    public partial class OFERTA3 : Window
    {
        public OFERTA3()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OFERTA1_Click(object sender, RoutedEventArgs e)
        {
            OFERTA4 sw = new OFERTA4();
            sw.Show();
        }

        private void OFERTA2_Click(object sender, RoutedEventArgs e)
        {
            OFERTA5 sw = new OFERTA5();
            sw.Show();
        }
    }
}
