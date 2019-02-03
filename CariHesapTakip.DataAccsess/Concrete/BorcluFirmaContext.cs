using CariHesapTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.DataAccsess.Concrete
{
    class BorcluFirmaContext : DbContext
    {
        public DbSet<BorcluFirma> BorcluFirma { get; set; }
    }
}
