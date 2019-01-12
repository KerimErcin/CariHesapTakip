using CariHesapTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.DataAccsess.Concrete
{
    public class FirmaBilgileriContext : DbContext
    {
        public DbSet<FirmaBilgileri> FirmaBilgileri { get; set; }
    }
}
