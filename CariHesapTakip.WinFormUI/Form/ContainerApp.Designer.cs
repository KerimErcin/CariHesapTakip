namespace CariHesapTakip.WinFormUI
{
    partial class ContainerApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerApp));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlIndıcator = new System.Windows.Forms.Panel();
            this.btnCompany = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.anmMenu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.pnlIndıcator);
            this.pnlMenu.Controls.Add(this.btnCompany);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.anmMenu.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(52, 767);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlIndıcator
            // 
            this.pnlIndıcator.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlIndıcator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.anmMenu.SetDecoration(this.pnlIndıcator, BunifuAnimatorNS.DecorationType.None);
            this.pnlIndıcator.Location = new System.Drawing.Point(45, 87);
            this.pnlIndıcator.Name = "pnlIndıcator";
            this.pnlIndıcator.Size = new System.Drawing.Size(7, 48);
            this.pnlIndıcator.TabIndex = 2;
            // 
            // btnCompany
            // 
            this.btnCompany.Activecolor = System.Drawing.Color.White;
            this.btnCompany.BackColor = System.Drawing.Color.White;
            this.btnCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompany.BorderRadius = 0;
            this.btnCompany.ButtonText = "        Kişiler";
            this.btnCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmMenu.SetDecoration(this.btnCompany, BunifuAnimatorNS.DecorationType.None);
            this.btnCompany.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompany.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCompany.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompany.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompany.Iconimage")));
            this.btnCompany.Iconimage_right = null;
            this.btnCompany.Iconimage_right_Selected = null;
            this.btnCompany.Iconimage_Selected = null;
            this.btnCompany.IconMarginLeft = 0;
            this.btnCompany.IconMarginRight = 0;
            this.btnCompany.IconRightVisible = true;
            this.btnCompany.IconRightZoom = 0D;
            this.btnCompany.IconVisible = true;
            this.btnCompany.IconZoom = 60D;
            this.btnCompany.IsTab = false;
            this.btnCompany.Location = new System.Drawing.Point(0, 141);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Normalcolor = System.Drawing.Color.White;
            this.btnCompany.OnHovercolor = System.Drawing.Color.White;
            this.btnCompany.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnCompany.selected = false;
            this.btnCompany.Size = new System.Drawing.Size(208, 48);
            this.btnCompany.TabIndex = 4;
            this.btnCompany.Text = "        Kişiler";
            this.btnCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompany.Textcolor = System.Drawing.Color.DimGray;
            this.btnCompany.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Activecolor = System.Drawing.Color.White;
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.ButtonText = "        Ayarlar";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmMenu.SetDecoration(this.btnSettings, BunifuAnimatorNS.DecorationType.None);
            this.btnSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSettings.Iconimage")));
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconMarginLeft = 0;
            this.btnSettings.IconMarginRight = 0;
            this.btnSettings.IconRightVisible = true;
            this.btnSettings.IconRightZoom = 0D;
            this.btnSettings.IconVisible = true;
            this.btnSettings.IconZoom = 60D;
            this.btnSettings.IsTab = false;
            this.btnSettings.Location = new System.Drawing.Point(0, 195);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.Color.White;
            this.btnSettings.OnHovercolor = System.Drawing.Color.White;
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnSettings.selected = false;
            this.btnSettings.Size = new System.Drawing.Size(208, 48);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "        Ayarlar";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Textcolor = System.Drawing.Color.DimGray;
            this.btnSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Activecolor = System.Drawing.Color.White;
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.ButtonText = "        Menü";
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmMenu.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenu.Iconimage")));
            this.btnMenu.Iconimage_right = null;
            this.btnMenu.Iconimage_right_Selected = null;
            this.btnMenu.Iconimage_Selected = null;
            this.btnMenu.IconMarginLeft = 0;
            this.btnMenu.IconMarginRight = 0;
            this.btnMenu.IconRightVisible = true;
            this.btnMenu.IconRightZoom = 0D;
            this.btnMenu.IconVisible = true;
            this.btnMenu.IconZoom = 60D;
            this.btnMenu.IsTab = false;
            this.btnMenu.Location = new System.Drawing.Point(0, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Normalcolor = System.Drawing.Color.White;
            this.btnMenu.OnHovercolor = System.Drawing.Color.White;
            this.btnMenu.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnMenu.selected = false;
            this.btnMenu.Size = new System.Drawing.Size(208, 48);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "        Menü";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Textcolor = System.Drawing.Color.DimGray;
            this.btnMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.White;
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "        Anasayfa";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmMenu.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 60D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(0, 87);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.White;
            this.btnHome.OnHovercolor = System.Drawing.Color.White;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(208, 48);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "        Anasayfa";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.DimGray;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnExit);
            this.anmMenu.SetDecoration(this.pnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(52, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1347, 43);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.anmMenu.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageActive")));
            this.btnExit.Location = new System.Drawing.Point(1309, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // anmMenu
            // 
            this.anmMenu.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.anmMenu.Cursor = null;
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
            this.anmMenu.DefaultAnimation = animation1;
            // 
            // pnlContainer
            // 
            this.anmMenu.SetDecoration(this.pnlContainer, BunifuAnimatorNS.DecorationType.None);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(52, 43);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1347, 724);
            this.pnlContainer.TabIndex = 2;
            // 
            // ContainerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 767);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.anmMenu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContainerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContainerApp";
            this.Load += new System.EventHandler(this.ContainerApp_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenu;
        private System.Windows.Forms.Panel pnlIndıcator;
        private Bunifu.Framework.UI.BunifuFlatButton btnSettings;
        private BunifuAnimatorNS.BunifuTransition anmMenu;
        private System.Windows.Forms.Panel pnlContainer;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompany;
    }
}