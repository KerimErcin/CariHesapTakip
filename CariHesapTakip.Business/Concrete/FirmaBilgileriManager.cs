using CariHesapTakip.DataAccsess.Concrete;
using CariHesapTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.Business.Concrete
{
    public class FirmaBilgileriManager
    {
        FirmaBilgileriDal _firmaBilgileriDal = new FirmaBilgileriDal();
        public List<FirmaBilgileri> GetAl()
        {
            return _firmaBilgileriDal.GetAll();
        }
    }
}
