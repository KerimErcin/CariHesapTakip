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
            Bunifu.Framework.Lib.Elipse.Apply(pnlDtwBack, 5);
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

        private void btnMail_Click(object sender, EventArgs e)
        {
            using (SendMail sendMail = new SendMail())
            {
                sendMail.ShowDialog();
                //System.Windows.Media.Effects.BlurEffect myBlur = new System.Windows.Media.Effects.BlurEffect();
                //myBlur.Radius = 5; //Set the radius for the blur - the bigger the number the better the blur
                //this.Effect = myBlur;
            }
        }
    }
}
