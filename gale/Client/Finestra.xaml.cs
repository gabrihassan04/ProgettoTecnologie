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

namespace Client
{
    /// <summary>
    /// Logica di interazione per Finestra.xaml
    /// </summary>
    public partial class Finestra : Window
    {
        public Finestra()
        {
            InitializeComponent();

        }
        public String nome = "";

        private void Button_Login_Click(object sender, RoutedEventArgs e)

        {
            nome = TxtNome.Text;
            Close();
        }
    }
}
