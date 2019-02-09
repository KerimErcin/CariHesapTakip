using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariHesapTakip.WinFormUI.Components
{
    public partial class NoteCard : UserControl
    {
        public NoteCard()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 5);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
