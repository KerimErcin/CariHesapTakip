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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlExchanceRate = new System.Windows.Forms.Panel();
            this.dtPicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlUsd = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblUsd = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEuro = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblEuro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bgWorkerChar = new System.ComponentModel.BackgroundWorker();
            this.ch1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlChar = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlExchanceRate.SuspendLayout();
            this.pnlUsd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEuro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).BeginInit();
            this.pnlChar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
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
            this.pnlExchanceRate.Controls.Add(this.dtPicker);
            this.pnlExchanceRate.Controls.Add(this.panel2);
            this.pnlExchanceRate.Controls.Add(this.pnlUsd);
            this.pnlExchanceRate.Controls.Add(this.pnlEuro);
            this.pnlExchanceRate.Controls.Add(this.label1);
            this.pnlExchanceRate.Location = new System.Drawing.Point(280, 19);
            this.pnlExchanceRate.Name = "pnlExchanceRate";
            this.pnlExchanceRate.Size = new System.Drawing.Size(252, 234);
            this.pnlExchanceRate.TabIndex = 1;
            // 
            // dtPicker
            // 
            this.dtPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.dtPicker.BorderRadius = 10;
            this.dtPicker.ForeColor = System.Drawing.Color.White;
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPicker.FormatCustom = null;
            this.dtPicker.Location = new System.Drawing.Point(11, 181);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(229, 43);
            this.dtPicker.TabIndex = 2;
            this.dtPicker.Value = new System.DateTime(2019, 1, 13, 16, 21, 19, 0);
            this.dtPicker.onValueChanged += new System.EventHandler(this.dtPicker_onValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(11, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 40);
            this.panel2.TabIndex = 2;
            // 
            // pnlUsd
            // 
            this.pnlUsd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUsd.BackgroundImage")));
            this.pnlUsd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUsd.Controls.Add(this.lblUsd);
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
            // lblUsd
            // 
            this.lblUsd.AutoSize = true;
            this.lblUsd.BackColor = System.Drawing.Color.Transparent;
            this.lblUsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsd.ForeColor = System.Drawing.Color.White;
            this.lblUsd.Location = new System.Drawing.Point(86, 9);
            this.lblUsd.Name = "lblUsd";
            this.lblUsd.Size = new System.Drawing.Size(78, 37);
            this.lblUsd.TabIndex = 5;
            this.lblUsd.Text = "3,14";
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
            // pnlEuro
            // 
            this.pnlEuro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEuro.BackgroundImage")));
            this.pnlEuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEuro.Controls.Add(this.lblEuro);
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
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.BackColor = System.Drawing.Color.Transparent;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuro.ForeColor = System.Drawing.Color.White;
            this.lblEuro.Location = new System.Drawing.Point(86, 9);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(78, 37);
            this.lblEuro.TabIndex = 5;
            this.lblEuro.Text = "3,14";
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
            // bgWorkerChar
            // 
            this.bgWorkerChar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerChar_DoWork);
            // 
            // ch1
            // 
            chartArea1.Name = "ChartArea1";
            this.ch1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch1.Legends.Add(legend1);
            this.ch1.Location = new System.Drawing.Point(0, 0);
            this.ch1.Name = "ch1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BackSecondaryColor = System.Drawing.Color.DeepSkyBlue;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Turquoise;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerBorderWidth = 50;
            series1.Name = "Gelir";
            series1.ShadowColor = System.Drawing.Color.Maroon;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Gider";
            this.ch1.Series.Add(series1);
            this.ch1.Series.Add(series2);
            this.ch1.Size = new System.Drawing.Size(726, 234);
            this.ch1.TabIndex = 2;
            this.ch1.Text = "chart1";
            this.ch1.Click += new System.EventHandler(this.ch1_Click);
            // 
            // pnlChar
            // 
            this.pnlChar.BackColor = System.Drawing.Color.White;
            this.pnlChar.Controls.Add(this.ch1);
            this.pnlChar.Location = new System.Drawing.Point(560, 19);
            this.pnlChar.Name = "pnlChar";
            this.pnlChar.Size = new System.Drawing.Size(729, 234);
            this.pnlChar.TabIndex = 3;
            this.pnlChar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChar_Paint);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(280, 270);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1009, 436);
            this.bunifuCustomDataGrid1.TabIndex = 4;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.pnlChar);
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
            this.pnlUsd.ResumeLayout(false);
            this.pnlUsd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEuro.ResumeLayout(false);
            this.pnlEuro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).EndInit();
            this.pnlChar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuDatepicker dtPicker;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsd;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEuro;
        private System.ComponentModel.BackgroundWorker bgWorkerChar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch1;
        private System.Windows.Forms.Panel pnlChar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}
