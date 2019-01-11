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
    public partial class StartPage : UserControl
    {
        public StartPage()
        {
            InitializeComponent();
        }
        LoginAndSignUp loginAndSignUp = new LoginAndSignUp();
        private void btnStartLearning_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            loginAndSignUp.Visible = false;
            this.Controls.Add(loginAndSignUp);    
            anmPageChange.ShowSync(loginAndSignUp);
        }
    }
}
