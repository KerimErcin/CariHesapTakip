﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CariHesapTakip.WinFormUI.ControlClass;
using Newtonsoft.Json.Linq;
using CariHesapTakip.Business.Concrete;

namespace CariHesapTakip.WinFormUI.Page
{

    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Bunifu.Framework.Lib.Elipse.Apply(pnl1, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnl2, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnl3, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnl4, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnlExchanceRate, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnlUsd, 10);
            Bunifu.Framework.Lib.Elipse.Apply(pnlEuro, 10);
            Bunifu.Framework.Lib.Elipse.Apply(pnlChar, 5);
        }

        ControlAndSettings _controlAndSettings = new ControlAndSettings();
        FirmaBilgileriManager firmaBilgileriManager = new FirmaBilgileriManager();

        private void HomePage_Load(object sender, EventArgs e)
        {
            lblUsd.Text = _controlAndSettings.ExchanceUSD();
            lblEuro.Text = _controlAndSettings.ExchanceEuro();
            bgWorkerChar.RunWorkerAsync();
            firmaBilgileriManager.GetAl();
        }

        private void dtPicker_onValueChanged(object sender, EventArgs e)
        {
            string gun = dtPicker.Value.Day.ToString();
            string ay = dtPicker.Value.Month.ToString();
            string yil = dtPicker.Value.Year.ToString();
            _controlAndSettings.SelectDateExchance(gun, ay, yil);
        }

        private void bgWorkerChar_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] ay = { "Ocak", "Subat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            Random r = new Random();
            for (int i = 0; i < ay.Length; i++)
            {
                this.ch1.Series["Gelir"].Points.AddXY(ay[i], r.Next(0, 100));
                this.ch1.Series["Gider"].Points.AddXY(ay[i], r.Next(0, 50));
            }
        }

        private void pnlChar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ch1_Click(object sender, EventArgs e)
        {

        }
    }
}
