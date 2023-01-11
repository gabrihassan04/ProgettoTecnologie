using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            Finestra f = new Finestra();
            f.ShowDialog();
            String s= f.nome;
            
        }

        private void Btn_1_Click(object sender, RoutedEventArgs e) // evento bottone 1 
        {
                
            
            
               
        }

        private void Btn_2_Click(object sender, RoutedEventArgs e) // evento bottone 1 
        {
                 Connessione connessione = new Connessione();
        }

        private void Btn_3_Click(object sender, RoutedEventArgs e) // evento bottone 1 
        {
                Connessione connessione = new Connessione();
        }

        private void Btn_4_Click(object sender, RoutedEventArgs e) // evento bottone 1 
        {
                Connessione connessione = new Connessione();
        }

        private void Btn_5_Click(object sender, RoutedEventArgs e) // evento bottone 1 
        {
                Connessione connessione = new Connessione();
        }

        private void Btn_6_Click(object sender, RoutedEventArgs e) // evento bottone 1 
        {
                Connessione connessione = new Connessione();
        }
    }
}
