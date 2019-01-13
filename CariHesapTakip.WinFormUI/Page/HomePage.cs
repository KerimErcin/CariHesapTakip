using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariHesapTakip.WinFormUI.Page
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(pnl1, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnl2, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnl3, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnl4, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnlExchanceRate, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnlUsd, 10);
            Bunifu.Framework.Lib.Elipse.Apply(pnlEuro, 10);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
