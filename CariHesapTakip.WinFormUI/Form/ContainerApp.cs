using CariHesapTakip.WinFormUI.Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariHesapTakip.WinFormUI
{
    public partial class ContainerApp : Form
    {
        public ContainerApp()
        {
            InitializeComponent();

        }

        HomePage homePage = new HomePage();
        CompanyPage companyPage = new CompanyPage();
        SettingsPage settingsPage = new SettingsPage();

        private void ContainerApp_Load(object sender, EventArgs e)
        {
            //Load İşlemi
            SelectIndicator(btnHome);
            pnlContainer.Controls.Add(homePage);
        }

        public void SelectIndicator(object sender)
        {
            //Menüden seçilen işlemin yanına gelen panel
            pnlIndıcator.Top = ((Control)sender).Top;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            MenuHideAndShow(pnlMenu.Width);
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            //Şirket
            SelectIndicator(sender);
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(companyPage);
        }

        public void MenuHideAndShow(int width)
        {
            //Menu animasyon
            if (width == 52)
            {
                pnlMenu.Visible = false;
                pnlMenu.Width = 208;
                anmMenu.Show(pnlMenu);
            }
            else
            {
                pnlMenu.Visible = false;
                pnlMenu.Width = 52;
                anmMenu.Show(pnlMenu);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Ayarlar Penceresi
            SelectIndicator(sender);
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(settingsPage);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Anasayfa
            SelectIndicator(sender);
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(homePage);
        }
    }
}
