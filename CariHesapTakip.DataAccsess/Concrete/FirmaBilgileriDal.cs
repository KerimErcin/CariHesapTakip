using CariHesapTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.DataAccsess.Concrete
{
    public class FirmaBilgileriDal
    {
        public List<FirmaBilgileri> GetAll()
        {
            using (FirmaBilgileriContext context = new FirmaBilgileriContext())
            {
                return context.FirmaBilgileri.ToList();
            }
        }

        public FirmaBilgileri Get(int id)
        {
            using (FirmaBilgileriContext context = new FirmaBilgileriContext())
            {
                return context.FirmaBilgileri.SingleOrDefault(p=>p.Id==id);
            }
        }

        public void Add(FirmaBilgileri firmaBilgileri)
        {
            using (FirmaBilgileriContext context = new FirmaBilgileriContext())
            {
                context.FirmaBilgileri.Add(firmaBilgileri);
                context.SaveChanges();
            }
        }

        public void Update(FirmaBilgileri firmaBilgileri)
        {
            using (FirmaBilgileriContext context = new FirmaBilgileriContext())
            {
                
            }
        }

        public void Delete(FirmaBilgileri firmaBilgileri)
        {

        }
    }
}
