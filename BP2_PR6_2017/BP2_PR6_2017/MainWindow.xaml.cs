using BP2_PR6_2017.Prikazi;
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

namespace BP2_PR6_2017
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void PrikaziSkladista(object s, RoutedEventArgs e)
        {
            //MessageBox.Show("Nije jos uradjeno");
            SkladistaWindow skladistaWindow = new SkladistaWindow();
            skladistaWindow.Show();
        }

        public void PrikaziRecenzije(object s, RoutedEventArgs e)
        {
            //MessageBox.Show("Nije jos uradjeno");
            RecenzijeWindow recenzijeWindow = new RecenzijeWindow();
            recenzijeWindow.Show();
        }

        public void PrikaziIzdavace(object s, RoutedEventArgs e)
        {
            //MessageBox.Show("Nije jos uradjeno");
            IzdavaciWindow izdavaciWindow = new IzdavaciWindow();
            izdavaciWindow.Show();
        }

        public void PrikaziAutore(object s, RoutedEventArgs e)
        {
            //MessageBox.Show("Nije jos uradjeno");
            AutoriWindow autoriWindow = new AutoriWindow();
            autoriWindow.Show();
        }
    }
}
