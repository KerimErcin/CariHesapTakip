using CariHesapTakip.DataAccsess.Concrete;
using CariHesapTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.Business.Concrete
{
    public class BorcluFirmaManager
    {
        BorcluFirmaDal _borcluFirmaDal = new BorcluFirmaDal();
        public List<BorcluFirma> GetAll()
        {
            return _borcluFirmaDal.GetAll();
        }
    }
}
