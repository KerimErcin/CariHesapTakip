using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CariHesapTakip.WinFormUI.ControlClass;

namespace CariHesapTakip.WinFormUI.Components
{
    public partial class CompanyCard : UserControl
    {
        CompanyCardInfo companyCard = new CompanyCardInfo();

        public CompanyCard()
        {
            InitializeComponent();
            Random r = new Random();
            Color red = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            Color blue = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            Color green = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            pnlBackColor.GradientBottomLeft = red;
            pnlBackColor.GradientBottomRight = blue;
            pnlBackColor.GradientTopLeft = green;
            pnlBackColor.GradientTopRight = red;
        }

        private void CompanyCard_Load(object sender, EventArgs e)
        {
            lblId.Text = companyCard.id.ToString();
            txtCompanyName.Text = companyCard.CompanyName;
            txtGsm.Text = companyCard.Gsm.ToString();
            txtPhone.Text = companyCard.Telephone.ToString();
            txtMail.Text = companyCard.Mail;
        }
    }
}
