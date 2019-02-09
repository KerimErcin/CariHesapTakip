using CariHesapTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.DataAccsess.Concrete
{
    public class NoteDal
    {
        public List<Note> GetAll()
        {
            using (NoteContext context = new NoteContext())
            {
                return context.Note.ToList();
            }
        }

        public Note Get(int id)
        {
            using (NoteContext context = new NoteContext())
            {
                return context.Note.SingleOrDefault(p => p.Id == id);
            }
        }

        public void Add(Note borcluFirma)
        {
            using (NoteContext context = new NoteContext())
            {
                context.Note.Add(borcluFirma);
                context.SaveChanges();
            }
        }

        public void Update(Note borcluFirma)
        {
            using (NoteContext context = new NoteContext())
            {

            }
        }

        public void Delete(Note borcluFirma)
        {

        }
    }
}
