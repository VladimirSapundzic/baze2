using BP2_PR6_2017.repo.crud;
using BP2_PR6_2017.repo.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace BP2_PR6_2017
{
    /// <summary>
    /// Interaction logic for RecenzijeWindow.xaml
    /// </summary>
    public partial class RecenzijeWindow : Window
    {
        

        public BindingList<Recenzija> Recenzije { get; set; }
        private int editId = -1;
        private IRecenzija _rcz;

        public RecenzijeWindow()
        {
            InitializeComponent();
            _rcz = new RecenzijaCRUD();
            //Ugovori = new BindableCollection<Ugovor>(_repository.GetUgovori());
            UcitajRecenzije();
        }

        public void UcitajRecenzije()
        {
            Recenzije = new BindingList<Recenzija>(_rcz.UcitajREcenzije().ToList());
            RecenzijeList.ItemsSource = Recenzije;
        }

        public void ButtonDelete_Click(object s, RoutedEventArgs e)
        {
            var sk = ((FrameworkElement)s).DataContext as Recenzija;
            if (sk != null)
            {
                _rcz.ObrisiRecenziju(sk);
                UcitajRecenzije();
            }
        }

        public void ButtonCancel_Click(object s, RoutedEventArgs e)
        {
            ClearForm();

        }

        public void ClearForm()
        {
            KomTextBox.Text = String.Empty;
            OcenaTextBox.Text = String.Empty;
        }

        public void ButtonEdit_Click(object s, RoutedEventArgs e)
        {
            var sk = ((FrameworkElement)s).DataContext as Skladiste;

            if (sk != null)
            {
                KomTextBox.Text = sk.AdrSkladista;

                this.editId = sk.IdSkl;
            }
        }

        public void ButtonSave_Click(object s, RoutedEventArgs e)
        {
            if (OcenaTextBox.Text == string.Empty || KomTextBox.Text == string.Empty) 
                return;
            Recenzija recenzija;
            if (this.editId == -1)
            {
                recenzija = new Recenzija();
                recenzija.Komentar = (KomTextBox.Text);
                recenzija.Ocena = Int32.Parse(OcenaTextBox.Text);
                //recenzija.Kupac = new Kupac() { };
                _rcz.DodajRecenziju(recenzija);
            }
            else
            {
                recenzija = _rcz.GetById(this.editId);
                
                _rcz.ObrisiRecenziju(recenzija);

                Recenzija s_updated = new Recenzija();
                s_updated.Komentar = KomTextBox.Text;
                s_updated.Id = editId;
                s_updated.Kupac = recenzija.Kupac;
                _rcz.DodajRecenziju(s_updated);
            }
            UcitajRecenzije();
            //ClearForm();
        }
    }
}
