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
using System.IO;

namespace BiuroTurystyczne
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Background = Brushes.Purple;
            MessageBox.Show("Numer telefonu 111-222-333 ");
            MessageBox.Show("Adres email biuro.podrozy@gmail.com");

        }

        private void MenuItem_Click (object sender,RoutedEventArgs e)
        {
            MessageBox.Show("Ubezpieczenie podróżne jest zależne od ilości osób oraz ich wieku proszę skonatktuj się z nami telefonicznie");
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kartę podarunkową można kupić na każdą z dostępnych wycieczek. Cena karty podrunkowej zaczyna się od 100 złotych. Do karty powyżej 2500 złotch dołaczana jest zniżka o wartości 10% na kolejną wycieczkę");
        }


        private void zapis_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("zapis_pliku.txt"))
            {
                writer.Write("DZIĘKUJEMY! ZOSTAŁEŚ ZAPISANY DO NEWSLETERA!!! ");
              
                writer.WriteLine(tb_Name.Text);

            }
        }


        private void Francja(object sender, RoutedEventArgs e)
        {
           Francja Francjawindow = new Francja();
            Francjawindow.Show();
            this.Close();
        }

        private void Miami(object sender, RoutedEventArgs e)
        {
            Miami Miamiwindow = new Miami();
            Miamiwindow.Show();
            this.Close();
        }

        private void Tokio(object sender, RoutedEventArgs e)
        {
           Tokio Tokiowindow = new Tokio();
            Tokiowindow.Show();
            this.Close();
        }
    }
}