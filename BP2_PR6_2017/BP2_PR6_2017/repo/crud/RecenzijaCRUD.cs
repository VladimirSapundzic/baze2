using BP2_PR6_2017.repo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP2_PR6_2017.repo.crud
{
    public class RecenzijaCRUD : IRecenzija
    {
        private ModelProjContainer db;

        public RecenzijaCRUD()
        {
            db = new ModelProjContainer();
        }

        public void DodajRecenziju(Recenzija r)
        {
            throw new NotImplementedException();
        }

        public Recenzija GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Knjiga GetKnjiga(Recenzija r)
        {
            return r.Knjiga;
            
        }

        public Kupac GetKupac(Recenzija r)
        {
            return r.Kupac;
        }

        public void IzmeniRecenziju(Recenzija r)
        {
            throw new NotImplementedException();
        }

        public void ObrisiRecenziju(Recenzija r)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recenzija> UcitajREcenzije()
        {
            return db.RecenzijaSet;
        }
    }
}
