using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.Entities.Concrete
{
    public class BorcluFirma
    {
        public int Id { get; set; }
        public string FirmaUnvani { get; set; }
        public string FirmaYetkili { get; set; }
        public int FirmaTelefon { get; set; }
        public int FirmaGsm { get; set; }
        public string FirmaAdres { get; set; }
        public string FirmaIl { get; set; }
        public string FirmaIlce { get; set; }
        public int FirmaVergiNumarasi { get; set; }
        public string FirmaVergiDairesi { get; set; }
        public string FirmaMail { get; set; }
        public string FirmaWeb { get; set; }    
        public float FirmaCariLimit { get; set; }
        public string FirmaDurumu { get; set; }
    }
}
