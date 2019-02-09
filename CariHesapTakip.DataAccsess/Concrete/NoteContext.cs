using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CariHesapTakip.Entities.Concrete;

namespace CariHesapTakip.DataAccsess.Concrete
{
    class NoteContext : DbContext
    {
        public DbSet<Note> Note { get; set; }
    }
}
