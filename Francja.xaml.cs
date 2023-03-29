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
    /// Logika interakcji dla klasy Francja.xaml
    /// </summary>
    public partial class Francja : Window
    {
        public Francja()
        {
            InitializeComponent();
            opis();
        }

        private void opis()
        {
            string plik = File.ReadAllText("Francja.txt");

            plik1.Text = plik;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Francjawindow = new MainWindow();
           Francjawindow.Show();
            this.Close();
        }

        private void OFERTA_Click(object sender, RoutedEventArgs e)
        {
            OFERTA3 sw = new OFERTA3();
            sw.Show();
        }
    }
}
