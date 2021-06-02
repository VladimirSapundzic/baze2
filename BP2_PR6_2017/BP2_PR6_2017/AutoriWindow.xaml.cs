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
    /// Interaction logic for AutoriWindow.xaml
    /// </summary>
    public partial class AutoriWindow : Window
    {
        public BindingList<Autor> Autori { get; set; }
        private int editId = -1;
        private IAutor _aut;

        public AutoriWindow()
        {
            InitializeComponent();
            _aut = new AutorCRUD();
            //Ugovori = new BindableCollection<Ugovor>(_repository.GetUgovori());
            UcitajAutore();
        }

        public void UcitajAutore()
        {
            Autori = new BindingList<Autor>(_aut.UcitajAutore().ToList());
            AutoriList.ItemsSource = Autori;
        }

        public void ButtonDelete_Click(object s, RoutedEventArgs e)
        {
            var sk = ((FrameworkElement)s).DataContext as Autor;
            if (sk != null)
            {
                _aut.ObrisiAutora(sk);
                UcitajAutore();
            }
        }

        public void ButtonCancel_Click(object s, RoutedEventArgs e)
        {
            ClearForm();

        }

        public void ClearForm()
        {
            ImeTextBox.Text = String.Empty;
            PrezimeTextBox.Text = String.Empty;
        }

        public void ButtonEdit_Click(object s, RoutedEventArgs e)
        {
            var sk = ((FrameworkElement)s).DataContext as Autor;
            
            if (sk != null)
            {
                ImeTextBox.Text = sk.ImeAutora;
                PrezimeTextBox.Text = sk.PrezAutora;
                
                this.editId = sk.IdAut;
            }
        }

        public void ButtonSave_Click(object s, RoutedEventArgs e)
        {
            if (ImeTextBox.Text == String.Empty || PrezimeTextBox.Text == String.Empty)
                return;
            Autor autor;
            if (this.editId == -1)
            {
                autor = new Autor();
                autor.ImeAutora = (ImeTextBox.Text);
                autor.PrezAutora = (PrezimeTextBox.Text);

                _aut.DodajAutora(autor);
            }
            else
            {
                autor = _aut.GetById(this.editId);

                _aut.ObrisiAutora(autor);

                Autor s_updated = new Autor();
                s_updated.ImeAutora = ImeTextBox.Text;
                s_updated.PrezAutora = PrezimeTextBox.Text;
                s_updated.IdAut = editId;
                _aut.DodajAutora(s_updated);
            }
            UcitajAutore();
            //ClearForm();
        }
    }
}
