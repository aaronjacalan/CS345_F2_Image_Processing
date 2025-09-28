using System.Windows.Forms;

namespace CS345___Image_Processing
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.AppIcon = new System.Windows.Forms.PictureBox();
			this.titleBarPanel = new System.Windows.Forms.Panel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.useWebcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.switchToSubtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.CopyButton = new System.Windows.Forms.Button();
			this.colorInverseButton = new System.Windows.Forms.Button();
			this.greyscaleButton = new System.Windows.Forms.Button();
			this.histogramButton = new System.Windows.Forms.Button();
			this.sepiaButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.smoothButton = new System.Windows.Forms.Button();
			this.gaussianBlurButton = new System.Windows.Forms.Button();
			this.sharpenButton = new System.Windows.Forms.Button();
			this.meanRemovalButton = new System.Windows.Forms.Button();
			this.embossingButton = new System.Windows.Forms.Button();
			this.sobelEdgeDetectionButton = new System.Windows.Forms.Button();
			this.prewittEdgeDetectionButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
			this.titleBarPanel.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(15, 72);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(550, 450);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this.btnClose.ForeColor = System.Drawing.Color.Black;
			this.btnClose.Location = new System.Drawing.Point(1268, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(32, 32);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "×";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnClose.MouseEnter += new System.EventHandler(this.MouseEnter_Color);
			this.btnClose.MouseLeave += new System.EventHandler(this.MouseLeave_Color);
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnMinimize.ForeColor = System.Drawing.Color.Black;
			this.btnMinimize.Location = new System.Drawing.Point(1236, 0);
			this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(32, 32);
			this.btnMinimize.TabIndex = 1;
			this.btnMinimize.Text = "–";
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			this.btnMinimize.MouseEnter += new System.EventHandler(this.MouseEnter_Color);
			this.btnMinimize.MouseLeave += new System.EventHandler(this.MouseLeave_Color);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.Black;
			this.lblTitle.Location = new System.Drawing.Point(29, 7);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(232, 17);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "CS345 - Image Processing App";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
			// 
			// AppIcon
			// 
			this.AppIcon.Image = ((System.Drawing.Image)(resources.GetObject("AppIcon.Image")));
			this.AppIcon.Location = new System.Drawing.Point(5, 5);
			this.AppIcon.Name = "AppIcon";
			this.AppIcon.Size = new System.Drawing.Size(22, 22);
			this.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.AppIcon.TabIndex = 31;
			this.AppIcon.TabStop = false;
			this.AppIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.AppIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			this.AppIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
			// 
			// titleBarPanel
			// 
			this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
			this.titleBarPanel.Controls.Add(this.AppIcon);
			this.titleBarPanel.Controls.Add(this.lblTitle);
			this.titleBarPanel.Controls.Add(this.btnMinimize);
			this.titleBarPanel.Controls.Add(this.btnClose);
			this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
			this.titleBarPanel.Name = "titleBarPanel";
			this.titleBarPanel.Size = new System.Drawing.Size(1300, 32);
			this.titleBarPanel.TabIndex = 0;
			this.titleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
			this.titleBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
			this.titleBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
			this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
			this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Snow;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.switchToSubtractionToolStripMenuItem,
            this.useWebcamToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 32);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1300, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// useWebcamToolStripMenuItem
			// 
			this.useWebcamToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
			this.useWebcamToolStripMenuItem.Name = "useWebcamToolStripMenuItem";
			this.useWebcamToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.useWebcamToolStripMenuItem.Text = "Use Webcam";
			this.useWebcamToolStripMenuItem.Click += new System.EventHandler(this.useWebcamToolStripMenuItem_Click);
			// 
			// switchToSubtractionToolStripMenuItem
			// 
			this.switchToSubtractionToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
			this.switchToSubtractionToolStripMenuItem.Name = "switchToSubtractionToolStripMenuItem";
			this.switchToSubtractionToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
			this.switchToSubtractionToolStripMenuItem.Text = "Switch to Subtraction";
			this.switchToSubtractionToolStripMenuItem.Click += new System.EventHandler(this.switchToSubtractionToolStripMenuItem_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(736, 72);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(550, 450);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// CopyButton
			// 
			this.CopyButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.CopyButton.FlatAppearance.BorderSize = 0;
			this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CopyButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CopyButton.ForeColor = System.Drawing.Color.Black;
			this.CopyButton.Location = new System.Drawing.Point(575, 72);
			this.CopyButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(151, 32);
			this.CopyButton.TabIndex = 7;
			this.CopyButton.Text = "Copy";
			this.CopyButton.UseVisualStyleBackColor = false;
			this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// colorInverseButton
			// 
			this.colorInverseButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.colorInverseButton.FlatAppearance.BorderSize = 0;
			this.colorInverseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colorInverseButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colorInverseButton.Location = new System.Drawing.Point(575, 148);
			this.colorInverseButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.colorInverseButton.Name = "colorInverseButton";
			this.colorInverseButton.Size = new System.Drawing.Size(151, 32);
			this.colorInverseButton.TabIndex = 8;
			this.colorInverseButton.Text = "Color Inverse";
			this.colorInverseButton.UseVisualStyleBackColor = false;
			this.colorInverseButton.Click += new System.EventHandler(this.colorInverseButton_Click);
			// 
			// greyscaleButton
			// 
			this.greyscaleButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.greyscaleButton.FlatAppearance.BorderSize = 0;
			this.greyscaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.greyscaleButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.greyscaleButton.Location = new System.Drawing.Point(575, 110);
			this.greyscaleButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.greyscaleButton.Name = "greyscaleButton";
			this.greyscaleButton.Size = new System.Drawing.Size(151, 32);
			this.greyscaleButton.TabIndex = 9;
			this.greyscaleButton.Text = "Greyscale";
			this.greyscaleButton.UseVisualStyleBackColor = false;
			this.greyscaleButton.Click += new System.EventHandler(this.greyscaleButton_Click);
			// 
			// histogramButton
			// 
			this.histogramButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.histogramButton.FlatAppearance.BorderSize = 0;
			this.histogramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.histogramButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.histogramButton.Location = new System.Drawing.Point(575, 186);
			this.histogramButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.histogramButton.Name = "histogramButton";
			this.histogramButton.Size = new System.Drawing.Size(151, 32);
			this.histogramButton.TabIndex = 10;
			this.histogramButton.Text = "Histogram";
			this.histogramButton.UseVisualStyleBackColor = false;
			this.histogramButton.Click += new System.EventHandler(this.histogramButton_Click);
			// 
			// sepiaButton
			// 
			this.sepiaButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.sepiaButton.FlatAppearance.BorderSize = 0;
			this.sepiaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sepiaButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sepiaButton.Location = new System.Drawing.Point(575, 224);
			this.sepiaButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.sepiaButton.Name = "sepiaButton";
			this.sepiaButton.Size = new System.Drawing.Size(151, 32);
			this.sepiaButton.TabIndex = 11;
			this.sepiaButton.Text = "Sepia";
			this.sepiaButton.UseVisualStyleBackColor = false;
			this.sepiaButton.Click += new System.EventHandler(this.sepiaButton_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 33;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// smoothButton
			// 
			this.smoothButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.smoothButton.FlatAppearance.BorderSize = 0;
			this.smoothButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.smoothButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.smoothButton.Location = new System.Drawing.Point(575, 262);
			this.smoothButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.smoothButton.Name = "smoothButton";
			this.smoothButton.Size = new System.Drawing.Size(151, 32);
			this.smoothButton.TabIndex = 15;
			this.smoothButton.Text = "Smooth";
			this.smoothButton.UseVisualStyleBackColor = false;
			this.smoothButton.Click += new System.EventHandler(this.smoothButton_Click);
			// 
			// gaussianBlurButton
			// 
			this.gaussianBlurButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.gaussianBlurButton.FlatAppearance.BorderSize = 0;
			this.gaussianBlurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gaussianBlurButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gaussianBlurButton.Location = new System.Drawing.Point(575, 338);
			this.gaussianBlurButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.gaussianBlurButton.Name = "gaussianBlurButton";
			this.gaussianBlurButton.Size = new System.Drawing.Size(151, 32);
			this.gaussianBlurButton.TabIndex = 16;
			this.gaussianBlurButton.Text = "Gaussian Blur";
			this.gaussianBlurButton.UseVisualStyleBackColor = false;
			this.gaussianBlurButton.Click += new System.EventHandler(this.gaussianBlurButton_Click);
			// 
			// sharpenButton
			// 
			this.sharpenButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.sharpenButton.FlatAppearance.BorderSize = 0;
			this.sharpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sharpenButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sharpenButton.Location = new System.Drawing.Point(575, 300);
			this.sharpenButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.sharpenButton.Name = "sharpenButton";
			this.sharpenButton.Size = new System.Drawing.Size(151, 32);
			this.sharpenButton.TabIndex = 17;
			this.sharpenButton.Text = "Sharpen";
			this.sharpenButton.UseVisualStyleBackColor = false;
			this.sharpenButton.Click += new System.EventHandler(this.sharpenButton_Click);
			// 
			// meanRemovalButton
			// 
			this.meanRemovalButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.meanRemovalButton.FlatAppearance.BorderSize = 0;
			this.meanRemovalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.meanRemovalButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.meanRemovalButton.Location = new System.Drawing.Point(575, 376);
			this.meanRemovalButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.meanRemovalButton.Name = "meanRemovalButton";
			this.meanRemovalButton.Size = new System.Drawing.Size(151, 32);
			this.meanRemovalButton.TabIndex = 18;
			this.meanRemovalButton.Text = "Mean Removal";
			this.meanRemovalButton.UseVisualStyleBackColor = false;
			this.meanRemovalButton.Click += new System.EventHandler(this.meanRemovalButton_Click);
			// 
			// embossingButton
			// 
			this.embossingButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.embossingButton.FlatAppearance.BorderSize = 0;
			this.embossingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.embossingButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.embossingButton.Location = new System.Drawing.Point(575, 414);
			this.embossingButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.embossingButton.Name = "embossingButton";
			this.embossingButton.Size = new System.Drawing.Size(151, 32);
			this.embossingButton.TabIndex = 19;
			this.embossingButton.Text = "Embossing";
			this.embossingButton.UseVisualStyleBackColor = false;
			this.embossingButton.Click += new System.EventHandler(this.embossingButton_Click);
			// 
			// sobelEdgeDetectionButton
			// 
			this.sobelEdgeDetectionButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.sobelEdgeDetectionButton.FlatAppearance.BorderSize = 0;
			this.sobelEdgeDetectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sobelEdgeDetectionButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sobelEdgeDetectionButton.Location = new System.Drawing.Point(575, 452);
			this.sobelEdgeDetectionButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.sobelEdgeDetectionButton.Name = "sobelEdgeDetectionButton";
			this.sobelEdgeDetectionButton.Size = new System.Drawing.Size(151, 32);
			this.sobelEdgeDetectionButton.TabIndex = 21;
			this.sobelEdgeDetectionButton.Text = "Sobel";
			this.sobelEdgeDetectionButton.UseVisualStyleBackColor = false;
			this.sobelEdgeDetectionButton.Click += new System.EventHandler(this.sobelEdgeDetectionButton_Click);
			// 
			// prewittEdgeDetectionButton
			// 
			this.prewittEdgeDetectionButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.prewittEdgeDetectionButton.FlatAppearance.BorderSize = 0;
			this.prewittEdgeDetectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.prewittEdgeDetectionButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prewittEdgeDetectionButton.Location = new System.Drawing.Point(575, 490);
			this.prewittEdgeDetectionButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.prewittEdgeDetectionButton.Name = "prewittEdgeDetectionButton";
			this.prewittEdgeDetectionButton.Size = new System.Drawing.Size(151, 32);
			this.prewittEdgeDetectionButton.TabIndex = 22;
			this.prewittEdgeDetectionButton.Text = "Prewitt";
			this.prewittEdgeDetectionButton.UseVisualStyleBackColor = false;
			this.prewittEdgeDetectionButton.Click += new System.EventHandler(this.prewittEdgeDetectionButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
			this.ClientSize = new System.Drawing.Size(1300, 540);
			this.Controls.Add(this.prewittEdgeDetectionButton);
			this.Controls.Add(this.sobelEdgeDetectionButton);
			this.Controls.Add(this.embossingButton);
			this.Controls.Add(this.meanRemovalButton);
			this.Controls.Add(this.sharpenButton);
			this.Controls.Add(this.gaussianBlurButton);
			this.Controls.Add(this.smoothButton);
			this.Controls.Add(this.sepiaButton);
			this.Controls.Add(this.histogramButton);
			this.Controls.Add(this.greyscaleButton);
			this.Controls.Add(this.colorInverseButton);
			this.Controls.Add(this.CopyButton);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.titleBarPanel);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Image Processing";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
			this.titleBarPanel.ResumeLayout(false);
			this.titleBarPanel.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox AppIcon;
		private System.Windows.Forms.Panel titleBarPanel;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolStripMenuItem switchToSubtractionToolStripMenuItem;
		private System.Windows.Forms.Button CopyButton;
		private System.Windows.Forms.Button colorInverseButton;
		private System.Windows.Forms.Button greyscaleButton;
		private System.Windows.Forms.Button histogramButton;
		private System.Windows.Forms.Button sepiaButton;
		private System.Windows.Forms.ToolStripMenuItem useWebcamToolStripMenuItem;
		private Timer timer1;
		private Button smoothButton;
		private Button gaussianBlurButton;
		private Button sharpenButton;
		private Button meanRemovalButton;
		private Button embossingButton;
		private Button sobelEdgeDetectionButton;
		private Button prewittEdgeDetectionButton;
	}
}