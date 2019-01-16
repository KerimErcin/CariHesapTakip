namespace CariHesapTakip.WinFormUI.Components
{
    partial class CompanyCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyCard));
            this.pnlBackColor = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // pnlBackColor
            // 
            this.pnlBackColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackColor.BackgroundImage")));
            this.pnlBackColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackColor.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlBackColor.GradientBottomRight = System.Drawing.Color.White;
            this.pnlBackColor.GradientTopLeft = System.Drawing.Color.White;
            this.pnlBackColor.GradientTopRight = System.Drawing.Color.White;
            this.pnlBackColor.Location = new System.Drawing.Point(0, 0);
            this.pnlBackColor.Name = "pnlBackColor";
            this.pnlBackColor.Quality = 10;
            this.pnlBackColor.Size = new System.Drawing.Size(259, 332);
            this.pnlBackColor.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // CompanyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBackColor);
            this.Name = "CompanyCard";
            this.Size = new System.Drawing.Size(259, 332);
            this.Load += new System.EventHandler(this.CompanyCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlBackColor;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
