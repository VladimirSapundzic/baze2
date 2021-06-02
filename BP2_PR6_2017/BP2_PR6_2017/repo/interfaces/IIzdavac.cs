using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP2_PR6_2017.repo.interfaces
{
    public interface IIzdavac
    {
        IEnumerable<Izdavac> UcitajIzdavace();
        Izdavac GetById(int id);
        void DodajIzdavace(Izdavac r);
        void IzmeniIzdavace(Izdavac r);
        void ObrisiIzdavace(Izdavac r);
    }
}
