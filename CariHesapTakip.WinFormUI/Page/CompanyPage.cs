using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CariHesapTakip.WinFormUI.Components;
using CariHesapTakip.WinFormUI.ControlClass;

namespace CariHesapTakip.WinFormUI.Page
{
    public partial class CompanyPage : UserControl
    {
        public CompanyPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyCard companyCard = new CompanyCard();
            flwContainer.Controls.Add(companyCard);
        }

        private void CompanyPage_Load(object sender, EventArgs e)
        {

        }
    }
}
