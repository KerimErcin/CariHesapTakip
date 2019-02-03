using CariHesapTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.DataAccsess.Concrete
{
    public class BorcluFirmaDal
    {
        public List<BorcluFirma> GetAll()
        {
            using (BorcluFirmaContext context = new BorcluFirmaContext())
            {
                return context.BorcluFirma.ToList();
            }
        }

        public BorcluFirma Get(int id)
        {
            using (BorcluFirmaContext context = new BorcluFirmaContext())
            {
                return context.BorcluFirma.SingleOrDefault(p => p.Id == id);
            }
        }

        public void Add(BorcluFirma borcluFirma)
        {
            using (BorcluFirmaContext context = new BorcluFirmaContext())
            {
                context.BorcluFirma.Add(borcluFirma);
                context.SaveChanges();
            }
        }

        public void Update(BorcluFirma borcluFirma)
        {
            using (BorcluFirmaContext context = new BorcluFirmaContext())
            {

            }
        }

        public void Delete(BorcluFirma borcluFirma)
        {

        }

    }
}
