using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariHesapTakip.Entities.Concrete
{
    public class Note
    {
        public int Id { get; set; }
        public string NoteSubject { get; set; }
        public string NoteBody { get; set; }
        public DateTime NoteReminders { get; set; }
    }
}
