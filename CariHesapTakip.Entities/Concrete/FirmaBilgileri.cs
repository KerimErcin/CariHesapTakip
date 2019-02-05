using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.Entities.Concrete
{
    public class FirmaBilgileri
    {
        public int Id { get; set; }
        public string FirmaUnvani { get; set; }
        public string FirmaTelefon { get; set; }
        public string FirmaFax { get; set; }
        public string FirmaAdres { get; set; }
        public string FirmaIl { get; set; }
        public string FirmaIlce { get; set; }
        public string FirmaVergiDairesi { get; set; }
        public int FirmaVergiNumarasi { get; set; }
        public int FirmaBorcLimiti { get; set; }
        public string FirmaParaBirimi { get; set; }
    }
}
