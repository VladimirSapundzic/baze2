using BP2_PR6_2017.repo.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
            db.RecenzijaSet.Add(r);
            db.SaveChanges();
        }

        public Recenzija GetById(int id)
        {
            return db.RecenzijaSet.Find(id) as Recenzija;
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
            try
            {
                //db.SkladisteSet.Remove(db.SkladisteSet.Find(s.IdSkl));
                //db.SkladisteSet.Add(s);
                db.SaveChanges();
            }
            catch (DBConcurrencyException ce)
            {
                Trace.TraceInformation(ce.Message);
            }
        }

        public void ObrisiRecenziju(Recenzija r)
        {
            db.RecenzijaSet.Remove(r);
            db.SaveChanges();
        }

        public IEnumerable<Recenzija> UcitajREcenzije()
        {
            return db.RecenzijaSet;
        }
    }
}
