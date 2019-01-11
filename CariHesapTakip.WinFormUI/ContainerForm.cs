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
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();

        }

        #region Instance
        StartPage startPage = new StartPage();
        LoginAndSignUp loginAndSignUp = new LoginAndSignUp();
        #endregion

        private void Container_Load(object sender, EventArgs e)
        {
            //Açıldığı zaman Start page sayfasını yüklüyor
            //bunifuFormFadeTransition1.ShowAsyc(this);
            startPage.Visible = false;
            this.Controls.Add(startPage);           
            anmPageChange.Show(startPage);
        }

        public void GetStartPage()
        {
            
        }
    }
}
