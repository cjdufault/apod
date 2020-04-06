namespace APOD
{
    partial class AstronomyPictureForm
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
            this.picAstronomyPicture = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnGetToday = new System.Windows.Forms.Button();
            this.btnGetForDate = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.apodBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.dtePictureDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picAstronomyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // picAstronomyPicture
            // 
            this.picAstronomyPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAstronomyPicture.Location = new System.Drawing.Point(18, 178);
            this.picAstronomyPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picAstronomyPicture.Name = "picAstronomyPicture";
            this.picAstronomyPicture.Size = new System.Drawing.Size(1163, 664);
            this.picAstronomyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAstronomyPicture.TabIndex = 0;
            this.picAstronomyPicture.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(18, 967);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.MaximumSize = new System.Drawing.Size(1163, 624);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(1163, 279);
            this.lblDescription.TabIndex = 1;
            // 
            // btnGetToday
            // 
            this.btnGetToday.Location = new System.Drawing.Point(22, 17);
            this.btnGetToday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetToday.Name = "btnGetToday";
            this.btnGetToday.Size = new System.Drawing.Size(290, 47);
            this.btnGetToday.TabIndex = 0;
            this.btnGetToday.Text = "Get Today\'s Picture";
            this.btnGetToday.UseVisualStyleBackColor = true;
            this.btnGetToday.Click += new System.EventHandler(this.btnGetToday_Click);
            // 
            // btnGetForDate
            // 
            this.btnGetForDate.Location = new System.Drawing.Point(924, 17);
            this.btnGetForDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetForDate.Name = "btnGetForDate";
            this.btnGetForDate.Size = new System.Drawing.Size(258, 47);
            this.btnGetForDate.TabIndex = 2;
            this.btnGetForDate.Text = "Get Picture for Date";
            this.btnGetForDate.UseVisualStyleBackColor = true;
            this.btnGetForDate.Click += new System.EventHandler(this.btnGetForDate_Click);
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(18, 866);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(394, 80);
            this.lblDate.TabIndex = 5;
            // 
            // lblCredits
            // 
            this.lblCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCredits.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCredits.Location = new System.Drawing.Point(788, 866);
            this.lblCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(394, 80);
            this.lblCredits.TabIndex = 6;
            this.lblCredits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(18, 94);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1163, 61);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(639, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar.Location = new System.Drawing.Point(348, 412);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.MarqueeAnimationSpeed = 40;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(472, 36);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            // 
            // apodBackgroundWorker
            // 
            this.apodBackgroundWorker.WorkerSupportsCancellation = true;
            this.apodBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.apodBackgroundWorker_DoWork);
            this.apodBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.apodBackgroundWorker_RunWorkerCompleted);
            // 
            // dtePictureDate
            // 
            this.dtePictureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtePictureDate.Location = new System.Drawing.Point(703, 23);
            this.dtePictureDate.Name = "dtePictureDate";
            this.dtePictureDate.Size = new System.Drawing.Size(200, 31);
            this.dtePictureDate.TabIndex = 10;
            // 
            // AstronomyPictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(1209, 1261);
            this.Controls.Add(this.dtePictureDate);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnGetForDate);
            this.Controls.Add(this.btnGetToday);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picAstronomyPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AstronomyPictureForm";
            this.Text = "Astronomy Picture of the Day";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAstronomyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAstronomyPicture;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnGetToday;
        private System.Windows.Forms.Button btnGetForDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker apodBackgroundWorker;
        private System.Windows.Forms.DateTimePicker dtePictureDate;
    }
}

