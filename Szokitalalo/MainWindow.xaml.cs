using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Szokitalalo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String[] feladvanyok = {"ALMA", "KÖRTE", "DIÓ"};
        public MainWindow()
        {
            InitializeComponent();
            Random r = new Random();
            String feladvany = feladvanyok[r.Next(feladvanyok.Length)];
            foreach (char c in feladvany)
            {
               kartyak.Children.Add(new Betuk(c.ToString(), feladvany));
            }
        }

        private void ujszo(object sender, RoutedEventArgs e)
        {
            kartyak.Children.Clear();
            Random r = new Random();
            String feladvany = feladvanyok[r.Next(feladvanyok.Length)];
            foreach (char c in feladvany)
            {
                kartyak.Children.Add(new Betuk(c.ToString(), feladvany));
            }
        }

        private void ellenorzes(object sender, RoutedEventArgs e)
        {
            bool kitalalt = true;
            foreach (Betuk betu in kartyak.Children)
            {
                if (!betu.jo() == false)
                {
                    kitalalt = false;
                    break;
                }
            }
            MessageBox.Show(kitalalt ? "Kitaláltad!" : "Még nem találtad ki!");
        }
    }
}