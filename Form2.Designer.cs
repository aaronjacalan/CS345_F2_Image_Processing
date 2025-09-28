namespace CS345___Image_Processing
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.AppIcon = new System.Windows.Forms.PictureBox();
			this.titleBarPanel = new System.Windows.Forms.Panel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.switchToFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.chooseBackgroundButton = new System.Windows.Forms.Button();
			this.chooseImageButton = new System.Windows.Forms.Button();
			this.subtractGrayscaleButton = new System.Windows.Forms.Button();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.chooseChromaKeyColorButton = new System.Windows.Forms.Button();
			this.chromaKeyThreshold = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.thresholdNumber = new System.Windows.Forms.Label();
			this.subtractRGBButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
			this.titleBarPanel.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chromaKeyThreshold)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(14, 72);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(400, 300);
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
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
			this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.saveToolStripMenuItem.Text = "Save Output";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Snow;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.switchToFiltersToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 32);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1300, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// switchToFiltersToolStripMenuItem
			// 
			this.switchToFiltersToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
			this.switchToFiltersToolStripMenuItem.Name = "switchToFiltersToolStripMenuItem";
			this.switchToFiltersToolStripMenuItem.Size = new System.Drawing.Size(201, 20);
			this.switchToFiltersToolStripMenuItem.Text = "Switch to Image Processing";
			this.switchToFiltersToolStripMenuItem.Click += new System.EventHandler(this.switchToFiltersToolStripMenuItem_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(424, 72);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(400, 300);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Location = new System.Drawing.Point(834, 72);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(400, 300);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			// 
			// chooseBackgroundButton
			// 
			this.chooseBackgroundButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.chooseBackgroundButton.FlatAppearance.BorderSize = 0;
			this.chooseBackgroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chooseBackgroundButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chooseBackgroundButton.ForeColor = System.Drawing.Color.Black;
			this.chooseBackgroundButton.Location = new System.Drawing.Point(14, 382);
			this.chooseBackgroundButton.Margin = new System.Windows.Forms.Padding(0);
			this.chooseBackgroundButton.Name = "chooseBackgroundButton";
			this.chooseBackgroundButton.Size = new System.Drawing.Size(400, 35);
			this.chooseBackgroundButton.TabIndex = 7;
			this.chooseBackgroundButton.Text = "Choose Image A (Background)";
			this.chooseBackgroundButton.UseVisualStyleBackColor = false;
			this.chooseBackgroundButton.Click += new System.EventHandler(this.chooseBackgroundButton_Click);
			// 
			// chooseImageButton
			// 
			this.chooseImageButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.chooseImageButton.FlatAppearance.BorderSize = 0;
			this.chooseImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chooseImageButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chooseImageButton.ForeColor = System.Drawing.Color.Black;
			this.chooseImageButton.Location = new System.Drawing.Point(424, 382);
			this.chooseImageButton.Margin = new System.Windows.Forms.Padding(0);
			this.chooseImageButton.Name = "chooseImageButton";
			this.chooseImageButton.Size = new System.Drawing.Size(400, 35);
			this.chooseImageButton.TabIndex = 8;
			this.chooseImageButton.Text = "Choose Image B (Image)";
			this.chooseImageButton.UseVisualStyleBackColor = false;
			this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
			// 
			// subtractGrayscaleButton
			// 
			this.subtractGrayscaleButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.subtractGrayscaleButton.FlatAppearance.BorderSize = 0;
			this.subtractGrayscaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.subtractGrayscaleButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.subtractGrayscaleButton.ForeColor = System.Drawing.Color.Black;
			this.subtractGrayscaleButton.Location = new System.Drawing.Point(834, 382);
			this.subtractGrayscaleButton.Margin = new System.Windows.Forms.Padding(5);
			this.subtractGrayscaleButton.Name = "subtractGrayscaleButton";
			this.subtractGrayscaleButton.Size = new System.Drawing.Size(400, 62);
			this.subtractGrayscaleButton.TabIndex = 9;
			this.subtractGrayscaleButton.Text = "Subtract (Greyscale Method)";
			this.subtractGrayscaleButton.UseVisualStyleBackColor = false;
			this.subtractGrayscaleButton.Click += new System.EventHandler(this.subtractButton_Click);
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "openFileDialog2";
			this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
			// 
			// chooseChromaKeyColorButton
			// 
			this.chooseChromaKeyColorButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.chooseChromaKeyColorButton.FlatAppearance.BorderSize = 0;
			this.chooseChromaKeyColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chooseChromaKeyColorButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chooseChromaKeyColorButton.ForeColor = System.Drawing.Color.Black;
			this.chooseChromaKeyColorButton.Location = new System.Drawing.Point(14, 441);
			this.chooseChromaKeyColorButton.Margin = new System.Windows.Forms.Padding(0);
			this.chooseChromaKeyColorButton.Name = "chooseChromaKeyColorButton";
			this.chooseChromaKeyColorButton.Size = new System.Drawing.Size(250, 75);
			this.chooseChromaKeyColorButton.TabIndex = 10;
			this.chooseChromaKeyColorButton.Text = "Chroma Key Color";
			this.chooseChromaKeyColorButton.UseVisualStyleBackColor = false;
			this.chooseChromaKeyColorButton.Click += new System.EventHandler(this.chooseChromaKeyColorButton_Click);
			// 
			// chromaKeyThreshold
			// 
			this.chromaKeyThreshold.LargeChange = 1;
			this.chromaKeyThreshold.Location = new System.Drawing.Point(274, 471);
			this.chromaKeyThreshold.Margin = new System.Windows.Forms.Padding(5);
			this.chromaKeyThreshold.Maximum = 30;
			this.chromaKeyThreshold.Minimum = 5;
			this.chromaKeyThreshold.Name = "chromaKeyThreshold";
			this.chromaKeyThreshold.Size = new System.Drawing.Size(550, 45);
			this.chromaKeyThreshold.TabIndex = 11;
			this.chromaKeyThreshold.Value = 5;
			this.chromaKeyThreshold.Scroll += new System.EventHandler(this.chromaKeyThreshold_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(279, 441);
			this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 18);
			this.label1.TabIndex = 12;
			this.label1.Text = "Chroma Key Threshold:";
			// 
			// thresholdNumber
			// 
			this.thresholdNumber.AutoSize = true;
			this.thresholdNumber.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.thresholdNumber.ForeColor = System.Drawing.Color.White;
			this.thresholdNumber.Location = new System.Drawing.Point(465, 441);
			this.thresholdNumber.Margin = new System.Windows.Forms.Padding(0);
			this.thresholdNumber.Name = "thresholdNumber";
			this.thresholdNumber.Size = new System.Drawing.Size(16, 18);
			this.thresholdNumber.TabIndex = 13;
			this.thresholdNumber.Text = "0";
			// 
			// subtractRGBButton
			// 
			this.subtractRGBButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.subtractRGBButton.FlatAppearance.BorderSize = 0;
			this.subtractRGBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.subtractRGBButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.subtractRGBButton.ForeColor = System.Drawing.Color.Black;
			this.subtractRGBButton.Location = new System.Drawing.Point(834, 454);
			this.subtractRGBButton.Margin = new System.Windows.Forms.Padding(5);
			this.subtractRGBButton.Name = "subtractRGBButton";
			this.subtractRGBButton.Size = new System.Drawing.Size(400, 62);
			this.subtractRGBButton.TabIndex = 14;
			this.subtractRGBButton.Text = "Subtract (RGB Method)";
			this.subtractRGBButton.UseVisualStyleBackColor = false;
			this.subtractRGBButton.Click += new System.EventHandler(this.subtractRGBButton_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
			this.ClientSize = new System.Drawing.Size(1300, 540);
			this.Controls.Add(this.subtractRGBButton);
			this.Controls.Add(this.thresholdNumber);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chromaKeyThreshold);
			this.Controls.Add(this.chooseChromaKeyColorButton);
			this.Controls.Add(this.subtractGrayscaleButton);
			this.Controls.Add(this.chooseImageButton);
			this.Controls.Add(this.chooseBackgroundButton);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.titleBarPanel);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form2";
			this.Text = "Image Processing";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
			this.titleBarPanel.ResumeLayout(false);
			this.titleBarPanel.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chromaKeyThreshold)).EndInit();
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
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolStripMenuItem switchToFiltersToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button chooseBackgroundButton;
		private System.Windows.Forms.Button chooseImageButton;
		private System.Windows.Forms.Button subtractGrayscaleButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button chooseChromaKeyColorButton;
		private System.Windows.Forms.TrackBar chromaKeyThreshold;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label thresholdNumber;
		private System.Windows.Forms.Button subtractRGBButton;
	}
}