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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.AppIcon = new System.Windows.Forms.PictureBox();
			this.titleBarPanel = new System.Windows.Forms.Panel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.useWebcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.normalSpeedCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highSpeedCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.normalSpeedGreyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hiSpeedGreyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.normalSpeedInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hiSpeedInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
			this.titleBarPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(14, 71);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(590, 443);
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
			this.btnClose.Location = new System.Drawing.Point(1183, 0);
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
			this.btnMinimize.Location = new System.Drawing.Point(1151, 0);
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
			this.titleBarPanel.Size = new System.Drawing.Size(1215, 32);
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
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(614, 71);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(590, 443);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.useWebcamToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F);
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// useWebcamToolStripMenuItem
			// 
			this.useWebcamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.useWebcamToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.useWebcamToolStripMenuItem.Name = "useWebcamToolStripMenuItem";
			this.useWebcamToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.useWebcamToolStripMenuItem.Text = "Use Webcam";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// filtersToolStripMenuItem
			// 
			this.filtersToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.inversionToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.sepiaToolStripMenuItem});
			this.filtersToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F);
			this.filtersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
			this.filtersToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.filtersToolStripMenuItem.Text = "Filters";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalSpeedCopyToolStripMenuItem,
            this.highSpeedCopyToolStripMenuItem});
			this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			// 
			// normalSpeedCopyToolStripMenuItem
			// 
			this.normalSpeedCopyToolStripMenuItem.Name = "normalSpeedCopyToolStripMenuItem";
			this.normalSpeedCopyToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.normalSpeedCopyToolStripMenuItem.Text = "Normal";
			this.normalSpeedCopyToolStripMenuItem.Click += new System.EventHandler(this.normalSpeedToolStripMenuItem_Click);
			// 
			// highSpeedCopyToolStripMenuItem
			// 
			this.highSpeedCopyToolStripMenuItem.Name = "highSpeedCopyToolStripMenuItem";
			this.highSpeedCopyToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.highSpeedCopyToolStripMenuItem.Text = "Pointers";
			this.highSpeedCopyToolStripMenuItem.Click += new System.EventHandler(this.highSpeedCopyToolStripMenuItem_Click);
			// 
			// greyscaleToolStripMenuItem
			// 
			this.greyscaleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.greyscaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalSpeedGreyscaleToolStripMenuItem,
            this.hiSpeedGreyscaleToolStripMenuItem});
			this.greyscaleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
			this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.greyscaleToolStripMenuItem.Text = "Greyscale";
			// 
			// normalSpeedGreyscaleToolStripMenuItem
			// 
			this.normalSpeedGreyscaleToolStripMenuItem.Name = "normalSpeedGreyscaleToolStripMenuItem";
			this.normalSpeedGreyscaleToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.normalSpeedGreyscaleToolStripMenuItem.Text = "Normal";
			this.normalSpeedGreyscaleToolStripMenuItem.Click += new System.EventHandler(this.normalSpeedGreyscaleToolStripMenuItem_Click);
			// 
			// hiSpeedGreyscaleToolStripMenuItem
			// 
			this.hiSpeedGreyscaleToolStripMenuItem.Name = "hiSpeedGreyscaleToolStripMenuItem";
			this.hiSpeedGreyscaleToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.hiSpeedGreyscaleToolStripMenuItem.Text = "Pointers";
			this.hiSpeedGreyscaleToolStripMenuItem.Click += new System.EventHandler(this.hiSpeedGreyscaleToolStripMenuItem_Click);
			// 
			// inversionToolStripMenuItem
			// 
			this.inversionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.inversionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalSpeedInversionToolStripMenuItem,
            this.hiSpeedInversionToolStripMenuItem});
			this.inversionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
			this.inversionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.inversionToolStripMenuItem.Text = "Color Inversion";
			// 
			// normalSpeedInversionToolStripMenuItem
			// 
			this.normalSpeedInversionToolStripMenuItem.Name = "normalSpeedInversionToolStripMenuItem";
			this.normalSpeedInversionToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.normalSpeedInversionToolStripMenuItem.Text = "Normal";
			this.normalSpeedInversionToolStripMenuItem.Click += new System.EventHandler(this.normalSpeedInversionToolStripMenuItem_Click);
			// 
			// hiSpeedInversionToolStripMenuItem
			// 
			this.hiSpeedInversionToolStripMenuItem.Name = "hiSpeedInversionToolStripMenuItem";
			this.hiSpeedInversionToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.hiSpeedInversionToolStripMenuItem.Text = "Pointers";
			this.hiSpeedInversionToolStripMenuItem.Click += new System.EventHandler(this.hiSpeedInversionToolStripMenuItem_Click_1);
			// 
			// histogramToolStripMenuItem
			// 
			this.histogramToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.histogramToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
			this.histogramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.histogramToolStripMenuItem.Text = "Histogram";
			this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
			// 
			// sepiaToolStripMenuItem
			// 
			this.sepiaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.sepiaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
			this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.sepiaToolStripMenuItem.Text = "Sepia";
			this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 32);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
			this.ClientSize = new System.Drawing.Size(1215, 528);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.titleBarPanel);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Image Processing";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
			this.titleBarPanel.ResumeLayout(false);
			this.titleBarPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem useWebcamToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem normalSpeedCopyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem highSpeedCopyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem normalSpeedGreyscaleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hiSpeedGreyscaleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem normalSpeedInversionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hiSpeedInversionToolStripMenuItem;
	}
}