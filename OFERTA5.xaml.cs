﻿using System;
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
    /// Logika interakcji dla klasy OFERTA5.xaml
    /// </summary>
    public partial class OFERTA5 : Window
    {
        public OFERTA5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Oferta5.txt"))
            {

                writer.WriteLine(tb_Name.Text);
                writer.WriteLine(tb_SurName.Text);
                writer.WriteLine(tb_NrTelefonu.Text);
                writer.WriteLine(tb_AdresEmail.Text);
            }
        }
    }
}
