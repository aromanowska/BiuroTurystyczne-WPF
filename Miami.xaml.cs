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
    /// Logika interakcji dla klasy Miami.xaml
    /// </summary>
    public partial class Miami : Window
    {
        public Miami()
        {

            InitializeComponent();
            opis();
        }

        private void opis()
        {
            string plik = System.IO.File.ReadAllText("Miami.txt");
            plik2.Text = plik;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Miamiwindow = new MainWindow();
            Miamiwindow.Show();
            this.Close();
        }

        private void OFERTA_Click(object sender, RoutedEventArgs e)
        {
            OFERTA sw = new OFERTA();
            sw.Show();
        }

    }
}
