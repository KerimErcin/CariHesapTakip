using CariHesapTakip.DataAccsess.Concrete;
using CariHesapTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.Business.Concrete
{
    public class NoteManager
    {
        NoteDal _noteDal = new NoteDal();
        public List<Note> GetAll()
        {
            return _noteDal.GetAll();
        }
    }
}
