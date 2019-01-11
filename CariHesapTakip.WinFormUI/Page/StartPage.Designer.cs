namespace CariHesapTakip.WinFormUI.Page
{
    partial class StartPage
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.moveControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnStartLearning = new Bunifu.Framework.UI.BunifuThinButton2();
            this.anmPageChange = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // moveControl
            // 
            this.moveControl.Fixed = true;
            this.moveControl.Horizontal = true;
            this.moveControl.TargetControl = this.pnlHeader;
            this.moveControl.Vertical = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.btnExit);
            this.anmPageChange.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(949, 43);
            this.pnlHeader.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.anmPageChange.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageActive")));
            this.btnExit.Location = new System.Drawing.Point(912, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            // 
            // btnStartLearning
            // 
            this.btnStartLearning.ActiveBorderThickness = 1;
            this.btnStartLearning.ActiveCornerRadius = 20;
            this.btnStartLearning.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(5)))), ((int)(((byte)(36)))));
            this.btnStartLearning.ActiveForecolor = System.Drawing.Color.White;
            this.btnStartLearning.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(5)))), ((int)(((byte)(36)))));
            this.btnStartLearning.BackColor = System.Drawing.Color.Transparent;
            this.btnStartLearning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartLearning.BackgroundImage")));
            this.btnStartLearning.ButtonText = "Öğrenmeye Başla";
            this.btnStartLearning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmPageChange.SetDecoration(this.btnStartLearning, BunifuAnimatorNS.DecorationType.None);
            this.btnStartLearning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartLearning.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnStartLearning.IdleBorderThickness = 1;
            this.btnStartLearning.IdleCornerRadius = 20;
            this.btnStartLearning.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(13)))), ((int)(((byte)(91)))));
            this.btnStartLearning.IdleForecolor = System.Drawing.Color.White;
            this.btnStartLearning.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(13)))), ((int)(((byte)(91)))));
            this.btnStartLearning.Location = new System.Drawing.Point(750, 431);
            this.btnStartLearning.Margin = new System.Windows.Forms.Padding(5);
            this.btnStartLearning.Name = "btnStartLearning";
            this.btnStartLearning.Size = new System.Drawing.Size(181, 52);
            this.btnStartLearning.TabIndex = 3;
            this.btnStartLearning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartLearning.Click += new System.EventHandler(this.btnStartLearning_Click);
            // 
            // anmPageChange
            // 
            this.anmPageChange.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.anmPageChange.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.anmPageChange.DefaultAnimation = animation1;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnStartLearning);
            this.anmPageChange.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "StartPage";
            this.Size = new System.Drawing.Size(949, 553);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStartLearning;
        private Bunifu.Framework.UI.BunifuDragControl moveControl;
        private BunifuAnimatorNS.BunifuTransition anmPageChange;
    }
}
