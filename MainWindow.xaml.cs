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

namespace ValutaOmregner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public float kursUSD = 6.78f;
        public string DKK;
        public MainWindow()
        {
            DKK = input.Text;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //float DKKf = float.Parse(DKK, System.Globalization.NumberStyles.Float);
           //output.Content = DKKf * kursUSD;
        }
    }
}
