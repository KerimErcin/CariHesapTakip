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
using CariHesapTakip.Business.Concrete;

namespace CariHesapTakip.WinFormUI.Page
{
    public partial class CompanyPage : UserControl
    {
        public CompanyPage()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(dgwCompany, 5);
        }

        BorcluFirmaManager _borcluFirmaManager = new BorcluFirmaManager();
        DgwDesing _dgwDesing = new DgwDesing();

        private void button1_Click(object sender, EventArgs e)
        {
            //CompanyCard companyCard = new CompanyCard();
            //flwContainer.Controls.Add(companyCard);
        }

        private void CompanyPage_Load(object sender, EventArgs e)
        {
            dgwCompany.DataSource = _borcluFirmaManager.GetAll();
            _dgwDesing.dtwCompany(dgwCompany);
        }
    }
}
