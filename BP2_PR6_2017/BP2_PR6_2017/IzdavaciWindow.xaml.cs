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
    /// Interaction logic for IzdavaciWindow.xaml
    /// </summary>
    public partial class IzdavaciWindow : Window
    {
        public BindingList<Izdavac> Izdavaci { get; set; }
        private int editId = -1;
        private IIzdavac _skl;

        public IzdavaciWindow()
        {
            InitializeComponent();
            _skl = new IzdavacCRUD();
            //Ugovori = new BindableCollection<Ugovor>(_repository.GetUgovori());
            UcitajIzdavace();
        }

        public void UcitajIzdavace()
        {
            Izdavaci = new BindingList<Izdavac>(_skl.UcitajIzdavace().ToList());
            IzdavaciList.ItemsSource = Izdavaci;
        }

        public void ButtonDelete_Click(object s, RoutedEventArgs e)
        {
            var sk = ((FrameworkElement)s).DataContext as Izdavac;
            if (sk != null)
            {
                _skl.ObrisiIzdavace(sk);
                UcitajIzdavace();
            }
        }

        public void ButtonCancel_Click(object s, RoutedEventArgs e)
        {
            ClearForm();

        }

        public void ClearForm()
        {
            NazivTextBox.Text = String.Empty;
        }

        public void ButtonEdit_Click(object s, RoutedEventArgs e)
        {
            var sk = ((FrameworkElement)s).DataContext as Izdavac;

            if (sk != null)
            {
                NazivTextBox.Text = sk.NazivIzdavaca;

                this.editId = sk.IdIzd;
            }
        }

        public void ButtonSave_Click(object s, RoutedEventArgs e)
        {
            if (NazivTextBox.Text == String.Empty)
                return;
            Izdavac izdavac;
            if (this.editId == -1)
            {
                izdavac = new Izdavac();
                izdavac.NazivIzdavaca = (NazivTextBox.Text);

                _skl.DodajIzdavace(izdavac);
            }
            else
            {
                izdavac = _skl.GetById(this.editId);

                _skl.ObrisiIzdavace(izdavac);

                Izdavac s_updated = new Izdavac();
                s_updated.NazivIzdavaca = NazivTextBox.Text;
                s_updated.IdIzd = editId;
                _skl.DodajIzdavace(s_updated);
            }
            UcitajIzdavace();
            //ClearForm();
        }
    }
}
