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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlExchanceRate = new System.Windows.Forms.Panel();
            this.dtPicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.pnlUsd = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblUsd = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEuro = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblEuro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bgWorkerChar = new System.ComponentModel.BackgroundWorker();
            this.ch1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlChar = new System.Windows.Forms.Panel();
            this.dgwHome = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlNote = new System.Windows.Forms.Panel();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.flwnlNoteList = new System.Windows.Forms.FlowLayoutPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pnl4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pnl3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnl2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnl1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlExchanceRate.SuspendLayout();
            this.pnlUsd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEuro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).BeginInit();
            this.pnlChar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHome)).BeginInit();
            this.pnlNote.SuspendLayout();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlExchanceRate
            // 
            this.pnlExchanceRate.BackColor = System.Drawing.Color.White;
            this.pnlExchanceRate.Controls.Add(this.dtPicker);
            this.pnlExchanceRate.Controls.Add(this.pnlUsd);
            this.pnlExchanceRate.Controls.Add(this.pnlEuro);
            this.pnlExchanceRate.Location = new System.Drawing.Point(280, 19);
            this.pnlExchanceRate.Name = "pnlExchanceRate";
            this.pnlExchanceRate.Size = new System.Drawing.Size(252, 187);
            this.pnlExchanceRate.TabIndex = 1;
            // 
            // dtPicker
            // 
            this.dtPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.dtPicker.BorderRadius = 10;
            this.dtPicker.ForeColor = System.Drawing.Color.White;
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPicker.FormatCustom = null;
            this.dtPicker.Location = new System.Drawing.Point(11, 136);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(229, 43);
            this.dtPicker.TabIndex = 2;
            this.dtPicker.Value = new System.DateTime(2019, 1, 13, 16, 21, 19, 0);
            this.dtPicker.onValueChanged += new System.EventHandler(this.dtPicker_onValueChanged);
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
            this.pnlUsd.Location = new System.Drawing.Point(11, 10);
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
            this.pnlEuro.Location = new System.Drawing.Point(11, 73);
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
            // bgWorkerChar
            // 
            this.bgWorkerChar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerChar_DoWork);
            // 
            // ch1
            // 
            chartArea3.Name = "ChartArea1";
            this.ch1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ch1.Legends.Add(legend3);
            this.ch1.Location = new System.Drawing.Point(0, 0);
            this.ch1.Name = "ch1";
            this.ch1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series5.BackSecondaryColor = System.Drawing.Color.DeepSkyBlue;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Turquoise;
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.Red;
            series5.MarkerBorderWidth = 50;
            series5.Name = "Gelir";
            series5.ShadowColor = System.Drawing.Color.Maroon;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Gider";
            this.ch1.Series.Add(series5);
            this.ch1.Series.Add(series6);
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
            // dgwHome
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwHome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgwHome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHome.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwHome.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwHome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwHome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgwHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHome.DoubleBuffered = true;
            this.dgwHome.EnableHeadersVisualStyles = false;
            this.dgwHome.GridColor = System.Drawing.Color.White;
            this.dgwHome.HeaderBgColor = System.Drawing.Color.White;
            this.dgwHome.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(231)))), ((int)(((byte)(224)))));
            this.dgwHome.Location = new System.Drawing.Point(560, 281);
            this.dgwHome.Name = "dgwHome";
            this.dgwHome.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwHome.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgwHome.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgwHome.Size = new System.Drawing.Size(729, 425);
            this.dgwHome.TabIndex = 4;
            // 
            // pnlNote
            // 
            this.pnlNote.BackColor = System.Drawing.Color.White;
            this.pnlNote.Controls.Add(this.bunifuSeparator4);
            this.pnlNote.Controls.Add(this.bunifuSeparator3);
            this.pnlNote.Controls.Add(this.bunifuSeparator2);
            this.pnlNote.Controls.Add(this.bunifuSeparator1);
            this.pnlNote.Controls.Add(this.flwnlNoteList);
            this.pnlNote.Controls.Add(this.monthCalendar1);
            this.pnlNote.Location = new System.Drawing.Point(280, 233);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(252, 473);
            this.pnlNote.TabIndex = 5;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator4.LineThickness = 5;
            this.bunifuSeparator4.Location = new System.Drawing.Point(-8, 21);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(20, 150);
            this.bunifuSeparator4.TabIndex = 6;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = true;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 5;
            this.bunifuSeparator3.Location = new System.Drawing.Point(234, 21);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(30, 150);
            this.bunifuSeparator3.TabIndex = 6;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator2.LineThickness = 5;
            this.bunifuSeparator2.Location = new System.Drawing.Point(9, 167);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(234, 10);
            this.bunifuSeparator2.TabIndex = 6;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(9, -11);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(234, 35);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // flwnlNoteList
            // 
            this.flwnlNoteList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwnlNoteList.Location = new System.Drawing.Point(3, 183);
            this.flwnlNoteList.Name = "flwnlNoteList";
            this.flwnlNoteList.Size = new System.Drawing.Size(246, 287);
            this.flwnlNoteList.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.White;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.White;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.White;
            // 
            // pnl4
            // 
            this.pnl4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl4.BackgroundImage")));
            this.pnl4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl4.Controls.Add(this.pictureBox6);
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
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(15, 15);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pnl3
            // 
            this.pnl3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl3.BackgroundImage")));
            this.pnl3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl3.Controls.Add(this.pictureBox5);
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
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pnl2
            // 
            this.pnl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl2.BackgroundImage")));
            this.pnl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl2.Controls.Add(this.pictureBox4);
            this.pnl2.Controls.Add(this.label3);
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
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pnl1
            // 
            this.pnl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl1.BackgroundImage")));
            this.pnl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl1.Controls.Add(this.pictureBox3);
            this.pnl1.Controls.Add(this.label1);
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam Alacak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kayıtlı Şirket Sayısı";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNote);
            this.Controls.Add(this.dgwHome);
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
            this.pnlUsd.ResumeLayout(false);
            this.pnlUsd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEuro.ResumeLayout(false);
            this.pnlEuro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).EndInit();
            this.pnlChar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHome)).EndInit();
            this.pnlNote.ResumeLayout(false);
            this.pnl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl2;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl3;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl4;
        private System.Windows.Forms.Panel pnlExchanceRate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlUsd;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlEuro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDatepicker dtPicker;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsd;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEuro;
        private System.ComponentModel.BackgroundWorker bgWorkerChar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch1;
        private System.Windows.Forms.Panel pnlChar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwHome;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel flwnlNoteList;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
