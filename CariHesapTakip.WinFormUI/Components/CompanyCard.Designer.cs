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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCompanyName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtPhone = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtGsm = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtMail = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlBackColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackColor
            // 
            this.pnlBackColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackColor.BackgroundImage")));
            this.pnlBackColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackColor.Controls.Add(this.lblId);
            this.pnlBackColor.Controls.Add(this.panel2);
            this.pnlBackColor.Controls.Add(this.txtMail);
            this.pnlBackColor.Controls.Add(this.txtGsm);
            this.pnlBackColor.Controls.Add(this.txtPhone);
            this.pnlBackColor.Controls.Add(this.txtCompanyName);
            this.pnlBackColor.Controls.Add(this.pictureBox1);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AcceptsReturn = false;
            this.txtCompanyName.AcceptsTab = false;
            this.txtCompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.txtCompanyName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCompanyName.BackgroundImage")));
            this.txtCompanyName.BorderColorActive = System.Drawing.Color.White;
            this.txtCompanyName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtCompanyName.BorderColorHover = System.Drawing.Color.White;
            this.txtCompanyName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtCompanyName.BorderRadius = 20;
            this.txtCompanyName.BorderThickness = 2;
            this.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCompanyName.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCompanyName.DefaultText = "";
            this.txtCompanyName.FillColor = System.Drawing.Color.White;
            this.txtCompanyName.HideSelection = true;
            this.txtCompanyName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtCompanyName.IconLeft")));
            this.txtCompanyName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtCompanyName.IconPadding = 10;
            this.txtCompanyName.IconRight = null;
            this.txtCompanyName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtCompanyName.Location = new System.Drawing.Point(29, 141);
            this.txtCompanyName.MaxLength = 32767;
            this.txtCompanyName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtCompanyName.Modified = false;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.ReadOnly = false;
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.SelectionLength = 0;
            this.txtCompanyName.SelectionStart = 0;
            this.txtCompanyName.ShortcutsEnabled = true;
            this.txtCompanyName.Size = new System.Drawing.Size(200, 35);
            this.txtCompanyName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtCompanyName.TabIndex = 1;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompanyName.TextMarginLeft = 5;
            this.txtCompanyName.TextPlaceholder = "";
            this.txtCompanyName.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            this.txtPhone.AcceptsReturn = false;
            this.txtPhone.AcceptsTab = false;
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPhone.BackgroundImage")));
            this.txtPhone.BorderColorActive = System.Drawing.Color.White;
            this.txtPhone.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPhone.BorderColorHover = System.Drawing.Color.White;
            this.txtPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPhone.BorderRadius = 20;
            this.txtPhone.BorderThickness = 2;
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhone.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone.DefaultText = "";
            this.txtPhone.FillColor = System.Drawing.Color.White;
            this.txtPhone.HideSelection = true;
            this.txtPhone.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPhone.IconLeft")));
            this.txtPhone.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPhone.IconPadding = 10;
            this.txtPhone.IconRight = null;
            this.txtPhone.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPhone.Location = new System.Drawing.Point(29, 182);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPhone.Modified = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ReadOnly = false;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(200, 35);
            this.txtPhone.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.TextMarginLeft = 5;
            this.txtPhone.TextPlaceholder = "";
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // txtGsm
            // 
            this.txtGsm.AcceptsReturn = false;
            this.txtGsm.AcceptsTab = false;
            this.txtGsm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGsm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGsm.BackColor = System.Drawing.Color.Transparent;
            this.txtGsm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtGsm.BackgroundImage")));
            this.txtGsm.BorderColorActive = System.Drawing.Color.White;
            this.txtGsm.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtGsm.BorderColorHover = System.Drawing.Color.White;
            this.txtGsm.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtGsm.BorderRadius = 20;
            this.txtGsm.BorderThickness = 2;
            this.txtGsm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGsm.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGsm.DefaultText = "";
            this.txtGsm.FillColor = System.Drawing.Color.White;
            this.txtGsm.HideSelection = true;
            this.txtGsm.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtGsm.IconLeft")));
            this.txtGsm.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtGsm.IconPadding = 10;
            this.txtGsm.IconRight = null;
            this.txtGsm.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtGsm.Location = new System.Drawing.Point(29, 223);
            this.txtGsm.MaxLength = 32767;
            this.txtGsm.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtGsm.Modified = false;
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.PasswordChar = '\0';
            this.txtGsm.ReadOnly = false;
            this.txtGsm.SelectedText = "";
            this.txtGsm.SelectionLength = 0;
            this.txtGsm.SelectionStart = 0;
            this.txtGsm.ShortcutsEnabled = true;
            this.txtGsm.Size = new System.Drawing.Size(200, 35);
            this.txtGsm.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtGsm.TabIndex = 1;
            this.txtGsm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGsm.TextMarginLeft = 5;
            this.txtGsm.TextPlaceholder = "";
            this.txtGsm.UseSystemPasswordChar = false;
            // 
            // txtMail
            // 
            this.txtMail.AcceptsReturn = false;
            this.txtMail.AcceptsTab = false;
            this.txtMail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMail.BackColor = System.Drawing.Color.Transparent;
            this.txtMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMail.BackgroundImage")));
            this.txtMail.BorderColorActive = System.Drawing.Color.White;
            this.txtMail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtMail.BorderColorHover = System.Drawing.Color.White;
            this.txtMail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtMail.BorderRadius = 20;
            this.txtMail.BorderThickness = 2;
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMail.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.DefaultText = "";
            this.txtMail.FillColor = System.Drawing.Color.White;
            this.txtMail.HideSelection = true;
            this.txtMail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtMail.IconLeft")));
            this.txtMail.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtMail.IconPadding = 10;
            this.txtMail.IconRight = null;
            this.txtMail.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtMail.Location = new System.Drawing.Point(29, 264);
            this.txtMail.MaxLength = 32767;
            this.txtMail.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtMail.Modified = false;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.ReadOnly = false;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(200, 35);
            this.txtMail.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMail.TabIndex = 1;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMail.TextMarginLeft = 5;
            this.txtMail.TextPlaceholder = "";
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 32);
            this.panel2.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(17, 7);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 25);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "1";
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
            this.pnlBackColor.ResumeLayout(false);
            this.pnlBackColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlBackColor;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtCompanyName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtMail;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtGsm;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPhone;
        private Bunifu.Framework.UI.BunifuCustomLabel lblId;
        private System.Windows.Forms.Panel panel2;
    }
}
