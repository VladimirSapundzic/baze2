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
    public class IzdavacCRUD : IIzdavac
    {
        private ModelProjContainer db;

        public IzdavacCRUD()
        {
            db = new ModelProjContainer();
        }

        public void DodajIzdavace(Izdavac r)
        {
            db.IzdavacSet.Add(r);
            db.SaveChanges();
        }

        public Izdavac GetById(int id)
        {
            return db.IzdavacSet.Find(id) as Izdavac;
        }

        public void IzmeniIzdavace(Izdavac r)
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

        public void ObrisiIzdavace(Izdavac r)
        {
            db.IzdavacSet.Remove(r);
            db.SaveChanges();
        }

        public IEnumerable<Izdavac> UcitajIzdavace()
        {
            return db.IzdavacSet;
        }
    }
}
