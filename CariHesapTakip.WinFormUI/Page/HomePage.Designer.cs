namespace CariHesapTakip.WinFormUI.Page
{
    partial class HomePage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pnl1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlExchanceRate = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUsd = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlEuro = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlExchanceRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUsd.SuspendLayout();
            this.pnlEuro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl1.BackgroundImage")));
            this.pnl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.pnl1.GradientBottomRight = System.Drawing.SystemColors.HotTrack;
            this.pnl1.GradientTopLeft = System.Drawing.Color.IndianRed;
            this.pnl1.GradientTopRight = System.Drawing.Color.CornflowerBlue;
            this.pnl1.Location = new System.Drawing.Point(23, 19);
            this.pnl1.Name = "pnl1";
            this.pnl1.Quality = 10;
            this.pnl1.Size = new System.Drawing.Size(229, 156);
            this.pnl1.TabIndex = 0;
            // 
            // pnl2
            // 
            this.pnl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl2.BackgroundImage")));
            this.pnl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl2.GradientBottomLeft = System.Drawing.Color.OrangeRed;
            this.pnl2.GradientBottomRight = System.Drawing.Color.Peru;
            this.pnl2.GradientTopLeft = System.Drawing.Color.Coral;
            this.pnl2.GradientTopRight = System.Drawing.Color.AliceBlue;
            this.pnl2.Location = new System.Drawing.Point(23, 196);
            this.pnl2.Name = "pnl2";
            this.pnl2.Quality = 10;
            this.pnl2.Size = new System.Drawing.Size(229, 156);
            this.pnl2.TabIndex = 0;
            // 
            // pnl3
            // 
            this.pnl3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl3.BackgroundImage")));
            this.pnl3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl3.GradientBottomLeft = System.Drawing.Color.Magenta;
            this.pnl3.GradientBottomRight = System.Drawing.SystemColors.AppWorkspace;
            this.pnl3.GradientTopLeft = System.Drawing.Color.Crimson;
            this.pnl3.GradientTopRight = System.Drawing.Color.AliceBlue;
            this.pnl3.Location = new System.Drawing.Point(23, 373);
            this.pnl3.Name = "pnl3";
            this.pnl3.Quality = 10;
            this.pnl3.Size = new System.Drawing.Size(229, 156);
            this.pnl3.TabIndex = 0;
            // 
            // pnl4
            // 
            this.pnl4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl4.BackgroundImage")));
            this.pnl4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl4.GradientBottomLeft = System.Drawing.Color.Aqua;
            this.pnl4.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.pnl4.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.pnl4.GradientTopRight = System.Drawing.Color.AliceBlue;
            this.pnl4.Location = new System.Drawing.Point(23, 550);
            this.pnl4.Name = "pnl4";
            this.pnl4.Quality = 10;
            this.pnl4.Size = new System.Drawing.Size(229, 156);
            this.pnl4.TabIndex = 0;
            // 
            // pnlExchanceRate
            // 
            this.pnlExchanceRate.BackColor = System.Drawing.Color.White;
            this.pnlExchanceRate.Controls.Add(this.bunifuDatepicker1);
            this.pnlExchanceRate.Controls.Add(this.panel2);
            this.pnlExchanceRate.Controls.Add(this.pnlUsd);
            this.pnlExchanceRate.Controls.Add(this.pnlEuro);
            this.pnlExchanceRate.Controls.Add(this.label1);
            this.pnlExchanceRate.Location = new System.Drawing.Point(280, 19);
            this.pnlExchanceRate.Name = "pnlExchanceRate";
            this.pnlExchanceRate.Size = new System.Drawing.Size(252, 234);
            this.pnlExchanceRate.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(11, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 40);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlUsd
            // 
            this.pnlUsd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUsd.BackgroundImage")));
            this.pnlUsd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUsd.Controls.Add(this.bunifuCustomLabel1);
            this.pnlUsd.Controls.Add(this.pictureBox1);
            this.pnlUsd.GradientBottomLeft = System.Drawing.Color.SpringGreen;
            this.pnlUsd.GradientBottomRight = System.Drawing.SystemColors.HotTrack;
            this.pnlUsd.GradientTopLeft = System.Drawing.Color.SpringGreen;
            this.pnlUsd.GradientTopRight = System.Drawing.Color.CornflowerBlue;
            this.pnlUsd.Location = new System.Drawing.Point(11, 55);
            this.pnlUsd.Name = "pnlUsd";
            this.pnlUsd.Quality = 10;
            this.pnlUsd.Size = new System.Drawing.Size(229, 55);
            this.pnlUsd.TabIndex = 0;
            // 
            // pnlEuro
            // 
            this.pnlEuro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEuro.BackgroundImage")));
            this.pnlEuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEuro.Controls.Add(this.bunifuCustomLabel2);
            this.pnlEuro.Controls.Add(this.pictureBox2);
            this.pnlEuro.GradientBottomLeft = System.Drawing.Color.Violet;
            this.pnlEuro.GradientBottomRight = System.Drawing.SystemColors.InactiveBorder;
            this.pnlEuro.GradientTopLeft = System.Drawing.Color.Tomato;
            this.pnlEuro.GradientTopRight = System.Drawing.Color.Cyan;
            this.pnlEuro.Location = new System.Drawing.Point(11, 118);
            this.pnlEuro.Name = "pnlEuro";
            this.pnlEuro.Quality = 10;
            this.pnlEuro.Size = new System.Drawing.Size(229, 55);
            this.pnlEuro.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Güncel Kur Bilgileri";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.bunifuDatepicker1.BorderRadius = 10;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(11, 181);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(229, 43);
            this.bunifuDatepicker1.TabIndex = 2;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 1, 13, 16, 21, 19, 0);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(86, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(78, 37);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "3,14";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(86, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 37);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "3,14";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlExchanceRate);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1347, 724);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.pnlExchanceRate.ResumeLayout(false);
            this.pnlExchanceRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUsd.ResumeLayout(false);
            this.pnlUsd.PerformLayout();
            this.pnlEuro.ResumeLayout(false);
            this.pnlEuro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl2;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl3;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl4;
        private System.Windows.Forms.Panel pnlExchanceRate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlUsd;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlEuro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}
