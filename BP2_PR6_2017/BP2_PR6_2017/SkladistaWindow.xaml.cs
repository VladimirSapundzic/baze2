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

namespace BP2_PR6_2017.Prikazi
{
    /// <summary>
    /// Interaction logic for SkladistaWindow.xaml
    /// </summary>
    public partial class SkladistaWindow : Window
    {
        public BindingList<Skladiste> Skladista { get; set; }
        private int editId = -1;
        private ISkladiste _skl;

        public SkladistaWindow()
        {
            InitializeComponent();
            _skl = new SkladisteCRUD();
            //Ugovori = new BindableCollection<Ugovor>(_repository.GetUgovori());
            UcitajSkladista();
        }

        public void UcitajSkladista()
        {
            Skladista = new BindingList<Skladiste>(_skl.UcitajSkladista().ToList());
            SkladistaList.ItemsSource = Skladista;
        }

        public void ButtonDelete_Click(object s, RoutedEventArgs e)
        {
            var sk = ((FrameworkElement)s).DataContext as Skladiste;
            if (sk != null)
            {
                _skl.ObrisiSkladiste(sk);
                UcitajSkladista();
            }
        }

        public void ButtonCancel_Click(object s, RoutedEventArgs e)
        {
                ClearForm();
            
        }

        public void ClearForm()
        {
            AdresaTextBox.Text = String.Empty;
        }

        public void ButtonEdit_Click(object s, RoutedEventArgs e)
        {
            var sk = ((FrameworkElement)s).DataContext as Skladiste;

            if (sk != null)
            {
                AdresaTextBox.Text = sk.AdrSkladista;
                
                this.editId = sk.IdSkl;
            }
        }

        public void ButtonSave_Click(object s, RoutedEventArgs e)
        {
            if (AdresaTextBox.Text == String.Empty)
                return;
            Skladiste skladiste;
            if (this.editId == -1)
            {
                skladiste = new Skladiste();
                skladiste.AdrSkladista = (AdresaTextBox.Text);
                
                _skl.DodajSkladiste(skladiste);
            }
            else
            {
                skladiste = _skl.GetById(this.editId);
               
                _skl.ObrisiSkladiste(skladiste);

                Skladiste s_updated = new Skladiste();
                s_updated.AdrSkladista = AdresaTextBox.Text;
                s_updated.IdSkl = editId;
                _skl.DodajSkladiste(s_updated);
            }
            UcitajSkladista();
            //ClearForm();
        }
    }
}
