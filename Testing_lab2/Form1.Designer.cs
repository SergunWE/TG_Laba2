namespace Testing_lab2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.originalImage = new System.Windows.Forms.PictureBox();
			this.filteredImage = new System.Windows.Forms.PictureBox();
			this.timeLabel = new System.Windows.Forms.Label();
			this.operationLabel = new System.Windows.Forms.Label();
			this.openButton = new System.Windows.Forms.Button();
			this.filterButton = new System.Windows.Forms.Button();
			this.timeValue = new System.Windows.Forms.Label();
			this.operationValue = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.filteredImage)).BeginInit();
			this.SuspendLayout();
			// 
			// originalImage
			// 
			this.originalImage.Location = new System.Drawing.Point(12, 12);
			this.originalImage.Name = "originalImage";
			this.originalImage.Size = new System.Drawing.Size(400, 400);
			this.originalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.originalImage.TabIndex = 0;
			this.originalImage.TabStop = false;
			// 
			// filteredImage
			// 
			this.filteredImage.Location = new System.Drawing.Point(472, 12);
			this.filteredImage.Name = "filteredImage";
			this.filteredImage.Size = new System.Drawing.Size(400, 400);
			this.filteredImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.filteredImage.TabIndex = 1;
			this.filteredImage.TabStop = false;
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Location = new System.Drawing.Point(472, 436);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(116, 15);
			this.timeLabel.TabIndex = 2;
			this.timeLabel.Text = "Execution time (ms):";
			// 
			// operationLabel
			// 
			this.operationLabel.AutoSize = true;
			this.operationLabel.Location = new System.Drawing.Point(472, 492);
			this.operationLabel.Name = "operationLabel";
			this.operationLabel.Size = new System.Drawing.Size(189, 15);
			this.operationLabel.TabIndex = 3;
			this.operationLabel.Text = "Number of elementary operations:";
			// 
			// openButton
			// 
			this.openButton.Location = new System.Drawing.Point(12, 418);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(100, 50);
			this.openButton.TabIndex = 4;
			this.openButton.Text = "Open Image";
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// filterButton
			// 
			this.filterButton.Location = new System.Drawing.Point(12, 474);
			this.filterButton.Name = "filterButton";
			this.filterButton.Size = new System.Drawing.Size(100, 50);
			this.filterButton.TabIndex = 5;
			this.filterButton.Text = "Filters run";
			this.filterButton.UseVisualStyleBackColor = true;
			this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
			// 
			// timeValue
			// 
			this.timeValue.AutoSize = true;
			this.timeValue.Location = new System.Drawing.Point(594, 436);
			this.timeValue.Name = "timeValue";
			this.timeValue.Size = new System.Drawing.Size(19, 15);
			this.timeValue.TabIndex = 6;
			this.timeValue.Text = "00";
			// 
			// operationValue
			// 
			this.operationValue.AutoSize = true;
			this.operationValue.Location = new System.Drawing.Point(667, 492);
			this.operationValue.Name = "operationValue";
			this.operationValue.Size = new System.Drawing.Size(19, 15);
			this.operationValue.TabIndex = 7;
			this.operationValue.Text = "00";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.operationValue);
			this.Controls.Add(this.timeValue);
			this.Controls.Add(this.filterButton);
			this.Controls.Add(this.openButton);
			this.Controls.Add(this.operationLabel);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.filteredImage);
			this.Controls.Add(this.originalImage);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.filteredImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox originalImage;
		private PictureBox filteredImage;
		private Label timeLabel;
		private Label operationLabel;
		private Button openButton;
		private Button filterButton;
		private Label timeValue;
		private Label operationValue;
	}
}