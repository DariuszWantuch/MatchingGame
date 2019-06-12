namespace MatchingGame
{
    partial class SecondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.howLong = new System.Windows.Forms.Timer(this.components);
            this.hide = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureStart = new System.Windows.Forms.PictureBox();
            this.pictureReset = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.clickCount = new System.Windows.Forms.Label();
            this.pictureSize = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSize)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.CountdownTimer_Tick);
            // 
            // howLong
            // 
            this.howLong.Interval = 1000;
            this.howLong.Tick += new System.EventHandler(this.HowLong_Tick);
            // 
            // hide
            // 
            this.hide.Interval = 1000;
            this.hide.Tick += new System.EventHandler(this.Hide_Tick);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 110);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.picture_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(125, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 110);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.picture_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(244, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 110);
            this.label4.TabIndex = 3;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.picture_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.Location = new System.Drawing.Point(6, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 110);
            this.label8.TabIndex = 7;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.picture_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.Location = new System.Drawing.Point(125, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 110);
            this.label9.TabIndex = 8;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.picture_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.Location = new System.Drawing.Point(244, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 110);
            this.label10.TabIndex = 9;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.picture_Click);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.Location = new System.Drawing.Point(6, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 110);
            this.label14.TabIndex = 13;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.picture_Click);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label15.Location = new System.Drawing.Point(125, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 110);
            this.label15.TabIndex = 14;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.picture_Click);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.Location = new System.Drawing.Point(244, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 110);
            this.label16.TabIndex = 15;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.picture_Click);
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label20.Location = new System.Drawing.Point(6, 342);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 110);
            this.label20.TabIndex = 19;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.picture_Click);
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label21.Location = new System.Drawing.Point(125, 342);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 110);
            this.label21.TabIndex = 20;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Click += new System.EventHandler(this.picture_Click);
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label22.Location = new System.Drawing.Point(244, 342);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 110);
            this.label22.TabIndex = 21;
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Click += new System.EventHandler(this.picture_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66222F));
            this.tableLayoutPanel1.Controls.Add(this.label37, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label36, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label35, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label34, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label33, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label32, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label31, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label30, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label29, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label28, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label27, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label25, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label24, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label23, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label21, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label17, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 681);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label37
            // 
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label37.Location = new System.Drawing.Point(600, 567);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(111, 111);
            this.label37.TabIndex = 36;
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label37.Click += new System.EventHandler(this.picture_Click);
            // 
            // label36
            // 
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label36.Location = new System.Drawing.Point(482, 567);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(109, 111);
            this.label36.TabIndex = 35;
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label36.Click += new System.EventHandler(this.picture_Click);
            // 
            // label35
            // 
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label35.Location = new System.Drawing.Point(363, 567);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(110, 111);
            this.label35.TabIndex = 34;
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label35.Click += new System.EventHandler(this.picture_Click);
            // 
            // label34
            // 
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label34.Location = new System.Drawing.Point(244, 567);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(110, 111);
            this.label34.TabIndex = 33;
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label34.Click += new System.EventHandler(this.picture_Click);
            // 
            // label33
            // 
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label33.Location = new System.Drawing.Point(125, 567);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(110, 111);
            this.label33.TabIndex = 32;
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label33.Click += new System.EventHandler(this.picture_Click);
            // 
            // label32
            // 
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label32.Location = new System.Drawing.Point(6, 567);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(110, 111);
            this.label32.TabIndex = 31;
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label32.Click += new System.EventHandler(this.picture_Click);
            // 
            // label31
            // 
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label31.Location = new System.Drawing.Point(600, 455);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(111, 109);
            this.label31.TabIndex = 30;
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label31.Click += new System.EventHandler(this.picture_Click);
            // 
            // label30
            // 
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label30.Location = new System.Drawing.Point(482, 455);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(109, 109);
            this.label30.TabIndex = 29;
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label30.Click += new System.EventHandler(this.picture_Click);
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label29.Location = new System.Drawing.Point(363, 455);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(110, 109);
            this.label29.TabIndex = 28;
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label29.Click += new System.EventHandler(this.picture_Click);
            // 
            // label28
            // 
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label28.Location = new System.Drawing.Point(244, 455);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(110, 109);
            this.label28.TabIndex = 27;
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label28.Click += new System.EventHandler(this.picture_Click);
            // 
            // label27
            // 
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label27.Location = new System.Drawing.Point(125, 455);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(110, 109);
            this.label27.TabIndex = 26;
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.Click += new System.EventHandler(this.picture_Click);
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label26.Location = new System.Drawing.Point(6, 455);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(110, 109);
            this.label26.TabIndex = 25;
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.Click += new System.EventHandler(this.picture_Click);
            // 
            // label25
            // 
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label25.Location = new System.Drawing.Point(600, 342);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(111, 110);
            this.label25.TabIndex = 24;
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.Click += new System.EventHandler(this.picture_Click);
            // 
            // label24
            // 
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label24.Location = new System.Drawing.Point(482, 342);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 110);
            this.label24.TabIndex = 23;
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label24.Click += new System.EventHandler(this.picture_Click);
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label23.Location = new System.Drawing.Point(363, 342);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 110);
            this.label23.TabIndex = 22;
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.Click += new System.EventHandler(this.picture_Click);
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label19.Location = new System.Drawing.Point(600, 229);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 110);
            this.label19.TabIndex = 18;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.picture_Click);
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label18.Location = new System.Drawing.Point(482, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 110);
            this.label18.TabIndex = 17;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.picture_Click);
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label17.Location = new System.Drawing.Point(363, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 110);
            this.label17.TabIndex = 16;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.picture_Click);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label13.Location = new System.Drawing.Point(600, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 110);
            this.label13.TabIndex = 12;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.picture_Click);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.Location = new System.Drawing.Point(482, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 110);
            this.label12.TabIndex = 11;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.picture_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.Location = new System.Drawing.Point(363, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 110);
            this.label11.TabIndex = 10;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.picture_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.Location = new System.Drawing.Point(600, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 110);
            this.label7.TabIndex = 6;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.picture_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.Location = new System.Drawing.Point(482, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 110);
            this.label6.TabIndex = 5;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.picture_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Wingdings", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(363, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 110);
            this.label5.TabIndex = 4;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.picture_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(0, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(797, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "4";
            // 
            // pictureStart
            // 
            this.pictureStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureStart.Image = global::MatchingGame.Properties.Resources.start;
            this.pictureStart.Location = new System.Drawing.Point(717, 0);
            this.pictureStart.Name = "pictureStart";
            this.pictureStart.Size = new System.Drawing.Size(207, 69);
            this.pictureStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureStart.TabIndex = 4;
            this.pictureStart.TabStop = false;
            this.pictureStart.Click += new System.EventHandler(this.PictureStart_Click);
            // 
            // pictureReset
            // 
            this.pictureReset.BackColor = System.Drawing.Color.Transparent;
            this.pictureReset.Image = global::MatchingGame.Properties.Resources.reset;
            this.pictureReset.Location = new System.Drawing.Point(773, 87);
            this.pictureReset.Name = "pictureReset";
            this.pictureReset.Size = new System.Drawing.Size(110, 110);
            this.pictureReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureReset.TabIndex = 5;
            this.pictureReset.TabStop = false;
            this.pictureReset.Click += new System.EventHandler(this.PictureReset_Click);
            // 
            // pictureClose
            // 
            this.pictureClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureClose.Image = global::MatchingGame.Properties.Resources.close;
            this.pictureClose.Location = new System.Drawing.Point(773, 567);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(110, 110);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 7;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.PictureClose_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(787, 320);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(78, 31);
            this.label38.TabIndex = 8;
            this.label38.Text = "Time";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(787, 421);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(83, 31);
            this.label39.TabIndex = 9;
            this.label39.Text = "Click";
            // 
            // clickCount
            // 
            this.clickCount.AutoSize = true;
            this.clickCount.BackColor = System.Drawing.Color.Transparent;
            this.clickCount.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickCount.Location = new System.Drawing.Point(797, 455);
            this.clickCount.Name = "clickCount";
            this.clickCount.Size = new System.Drawing.Size(34, 31);
            this.clickCount.TabIndex = 10;
            this.clickCount.Text = "0";
            // 
            // pictureSize
            // 
            this.pictureSize.BackColor = System.Drawing.Color.Transparent;
            this.pictureSize.Image = ((System.Drawing.Image)(resources.GetObject("pictureSize.Image")));
            this.pictureSize.Location = new System.Drawing.Point(741, 221);
            this.pictureSize.Name = "pictureSize";
            this.pictureSize.Size = new System.Drawing.Size(158, 80);
            this.pictureSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSize.TabIndex = 11;
            this.pictureSize.TabStop = false;
            this.pictureSize.Click += new System.EventHandler(this.PictureSize_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::MatchingGame.Properties.Resources.bckg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 681);
            this.Controls.Add(this.pictureSize);
            this.Controls.Add(this.clickCount);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.pictureClose);
            this.Controls.Add(this.pictureReset);
            this.Controls.Add(this.pictureStart);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Matching Game";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Timer howLong;
        private System.Windows.Forms.Timer hide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureStart;
        private System.Windows.Forms.PictureBox pictureReset;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label clickCount;
        private System.Windows.Forms.PictureBox pictureSize;
    }
}