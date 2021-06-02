using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP2_PR6_2017.repo.interfaces
{
    public interface IRecenzija
    {
        IEnumerable<Recenzija> UcitajREcenzije();
        Recenzija GetById(int id);
        void DodajRecenziju(Recenzija r);
        void IzmeniRecenziju(Recenzija r);
        void ObrisiRecenziju(Recenzija r);

        Kupac GetKupac(Recenzija r);
        Knjiga GetKnjiga(Recenzija r);

    }
}
