using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP2_PR6_2017.repo.interfaces
{
    public interface ISkladiste
    {
        IEnumerable<Skladiste> UcitajSkladista();
        Skladiste GetById(int id);
        void DodajSkladiste(Skladiste s);
        void IzmeniSkladiste(Skladiste s);
        void ObrisiSkladiste(Skladiste s);

        IEnumerable<Knjiga> DostupneKnjige();
    }
}
