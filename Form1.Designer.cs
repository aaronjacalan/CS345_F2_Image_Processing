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
			this.usePointersCheckBox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
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
			this.pictureBox1.Size = new System.Drawing.Size(525, 444);
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
			this.btnClose.Location = new System.Drawing.Point(1218, 0);
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
			this.btnMinimize.Location = new System.Drawing.Point(1186, 0);
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
			this.titleBarPanel.Size = new System.Drawing.Size(1250, 32);
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
            this.useWebcamToolStripMenuItem,
            this.switchToSubtractionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 32);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1250, 24);
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
			this.pictureBox2.Location = new System.Drawing.Point(711, 72);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(525, 444);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// CopyButton
			// 
			this.CopyButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.CopyButton.FlatAppearance.BorderSize = 0;
			this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CopyButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CopyButton.ForeColor = System.Drawing.Color.Black;
			this.CopyButton.Location = new System.Drawing.Point(550, 184);
			this.CopyButton.Margin = new System.Windows.Forms.Padding(0);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(151, 60);
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
			this.colorInverseButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colorInverseButton.Location = new System.Drawing.Point(550, 320);
			this.colorInverseButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.colorInverseButton.Name = "colorInverseButton";
			this.colorInverseButton.Size = new System.Drawing.Size(151, 60);
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
			this.greyscaleButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.greyscaleButton.Location = new System.Drawing.Point(550, 252);
			this.greyscaleButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.greyscaleButton.Name = "greyscaleButton";
			this.greyscaleButton.Size = new System.Drawing.Size(151, 60);
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
			this.histogramButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.histogramButton.Location = new System.Drawing.Point(550, 388);
			this.histogramButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.histogramButton.Name = "histogramButton";
			this.histogramButton.Size = new System.Drawing.Size(151, 60);
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
			this.sepiaButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sepiaButton.Location = new System.Drawing.Point(550, 456);
			this.sepiaButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.sepiaButton.Name = "sepiaButton";
			this.sepiaButton.Size = new System.Drawing.Size(151, 60);
			this.sepiaButton.TabIndex = 11;
			this.sepiaButton.Text = "Sepia";
			this.sepiaButton.UseVisualStyleBackColor = false;
			this.sepiaButton.Click += new System.EventHandler(this.sepiaButton_Click);
			// 
			// usePointersCheckBox
			// 
			this.usePointersCheckBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usePointersCheckBox.ForeColor = System.Drawing.Color.White;
			this.usePointersCheckBox.Location = new System.Drawing.Point(550, 133);
			this.usePointersCheckBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.usePointersCheckBox.Name = "usePointersCheckBox";
			this.usePointersCheckBox.Size = new System.Drawing.Size(151, 43);
			this.usePointersCheckBox.TabIndex = 13;
			this.usePointersCheckBox.Text = "USE POINTERS";
			this.usePointersCheckBox.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(550, 72);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 45);
			this.label1.TabIndex = 14;
			this.label1.Text = "FILTERS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// timer1
			// 
			this.timer1.Interval = 33;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
			this.ClientSize = new System.Drawing.Size(1250, 530);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.usePointersCheckBox);
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
		private System.Windows.Forms.CheckBox usePointersCheckBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem useWebcamToolStripMenuItem;
		private Timer timer1;
	}
}