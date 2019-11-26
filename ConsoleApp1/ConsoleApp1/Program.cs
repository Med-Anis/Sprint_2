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

namespace Sprint2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_ende_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            double zahl;

            if (Double.TryParse(tb.Text, out zahl))
            {
                tb.Background = Brushes.Green;
                tb.Foreground = Brushes.Black;
                // alles gut
            }

            else
            {
                tb.Foreground = Brushes.Red;
                tb.Background = Brushes.White;
                MessageBox.Show("Bitte geben sie nur Zahlen ein!", "Fehler");
                // Fehler
            }
        }

        private void Txb_breiterechteck_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Foreground = Brushes.Black;
        }
        private void trv_rechteck_Selected(object sender, RoutedEventArgs e)
        {
            // Schaltet die Sichtbarkeit des MB Grid an und Meer ab
            grid_Rechteck.Visibility = Visibility.Visible;

        }

        private void Txb_breiterechteck_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
    }
}