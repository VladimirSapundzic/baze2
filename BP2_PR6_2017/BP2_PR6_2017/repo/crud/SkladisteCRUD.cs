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
    public class SkladisteCRUD : ISkladiste
    {
        private ModelProjContainer db;

        public SkladisteCRUD()
        {
            db = new ModelProjContainer();
        }

        public void DodajSkladiste(Skladiste s)
        {
            db.SkladisteSet.Add(s);
            db.SaveChanges();
        }

        public IEnumerable<Knjiga> DostupneKnjige()
        {
            return db.KnjigaSet;
        }

        public Skladiste GetById(int id)
        {
            return db.SkladisteSet.Find(id) as Skladiste;
        }

        public void IzmeniSkladiste(Skladiste s)
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

        public void ObrisiSkladiste(Skladiste s)
        {

            db.SkladisteSet.Remove(s);
            db.SaveChanges();
        }

        public IEnumerable<Skladiste> UcitajSkladista()
        {
            return db.SkladisteSet;
        }
    }
}
