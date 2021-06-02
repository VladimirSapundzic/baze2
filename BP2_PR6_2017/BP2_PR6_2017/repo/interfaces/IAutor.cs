using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP2_PR6_2017.repo.interfaces
{
    public interface IAutor
    {
        IEnumerable<Autor> UcitajAutore();
        Autor GetById(int id);
        void DodajAutora(Autor r);
        void IzmeniAutora(Autor r);
        void ObrisiAutora(Autor r);
    }
}
