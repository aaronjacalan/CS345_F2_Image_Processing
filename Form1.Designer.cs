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
			this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
			this.btnClose.Location = new System.Drawing.Point(1185, 0);
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
			this.btnMinimize.Location = new System.Drawing.Point(1153, 0);
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
			this.titleBarPanel.Size = new System.Drawing.Size(1217, 32);
			this.titleBarPanel.TabIndex = 0;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(614, 71);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(590, 443);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
			this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// useWebcamToolStripMenuItem
			// 
			this.useWebcamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.useWebcamToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.useWebcamToolStripMenuItem.Name = "useWebcamToolStripMenuItem";
			this.useWebcamToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.useWebcamToolStripMenuItem.Text = "Use Webcam";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// filtersToolStripMenuItem
			// 
			this.filtersToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.sepiaToolStripMenuItem});
			this.filtersToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F);
			this.filtersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
			this.filtersToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.filtersToolStripMenuItem.Text = "F&ilters";
			// 
			// blurToolStripMenuItem
			// 
			this.blurToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.blurToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
			this.blurToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.blurToolStripMenuItem.Text = "Greyscale";
			// 
			// sharpenToolStripMenuItem
			// 
			this.sharpenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.sharpenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
			this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.sharpenToolStripMenuItem.Text = "Color Inversion";
			// 
			// grayscaleToolStripMenuItem
			// 
			this.grayscaleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.grayscaleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
			this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.grayscaleToolStripMenuItem.Text = "Histogram";
			// 
			// sepiaToolStripMenuItem
			// 
			this.sepiaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.sepiaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
			this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.sepiaToolStripMenuItem.Text = "Sepia";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 32);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1217, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
			this.ClientSize = new System.Drawing.Size(1217, 528);
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
		private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}