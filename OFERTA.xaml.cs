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
using System.IO;

namespace BiuroTurystyczne
{
    /// <summary>
    /// Logika interakcji dla klasy OFERTA.xaml
    /// </summary>
    public partial class OFERTA : Window
    {
        public OFERTA()
        {
            InitializeComponent();
        }

        private void OFERTA1_Click(object sender, RoutedEventArgs e)
        {
            OFERTA1 sw = new OFERTA1();
            sw.Show();
        }

        private void OFERTA2_Click(object sender, RoutedEventArgs e)
        {
            OFERTA2 sw = new OFERTA2();
            sw.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
