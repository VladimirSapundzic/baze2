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
    public class AutorCRUD : IAutor
    {
        private ModelProjContainer db;

        public AutorCRUD()
        {
            db = new ModelProjContainer();
        }

        public void DodajAutora(Autor r)
        {
            db.AutorSet.Add(r);
            db.SaveChanges();
        }

        public Autor GetById(int id)
        {
            return db.AutorSet.Find(id) as Autor;
        }

        public void IzmeniAutora(Autor r)
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

        public void ObrisiAutora(Autor r)
        {
            db.AutorSet.Remove(r);
            db.SaveChanges();
        }

        public IEnumerable<Autor> UcitajAutore()
        {
            return db.AutorSet;
        }
    }
}
