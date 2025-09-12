namespace Kaoordinate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKai = new FontAwesome.Sharp.IconButton();
            this.btnEvents = new FontAwesome.Sharp.IconButton();
            this.btnLocation = new FontAwesome.Sharp.IconButton();
            this.btnWhanau = new FontAwesome.Sharp.IconButton();
            this.btnRegistration = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnKai
            // 
            this.btnKai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKai.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.btnKai.IconColor = System.Drawing.Color.Black;
            this.btnKai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKai.IconSize = 80;
            this.btnKai.Location = new System.Drawing.Point(44, 168);
            this.btnKai.Margin = new System.Windows.Forms.Padding(2);
            this.btnKai.Name = "btnKai";
            this.btnKai.Size = new System.Drawing.Size(133, 115);
            this.btnKai.TabIndex = 1;
            this.btnKai.Text = "KAI";
            this.btnKai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKai.UseVisualStyleBackColor = true;
            this.btnKai.Click += new System.EventHandler(this.btnKai_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnEvents.IconColor = System.Drawing.Color.Black;
            this.btnEvents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvents.IconSize = 80;
            this.btnEvents.Location = new System.Drawing.Point(189, 168);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(2);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(133, 115);
            this.btnEvents.TabIndex = 2;
            this.btnEvents.Text = "EVENTS";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.IconChar = FontAwesome.Sharp.IconChar.MapMarked;
            this.btnLocation.IconColor = System.Drawing.Color.Black;
            this.btnLocation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLocation.IconSize = 80;
            this.btnLocation.Location = new System.Drawing.Point(483, 168);
            this.btnLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(133, 115);
            this.btnLocation.TabIndex = 3;
            this.btnLocation.Text = "LOCATION";
            this.btnLocation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnWhanau
            // 
            this.btnWhanau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhanau.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnWhanau.IconColor = System.Drawing.Color.Black;
            this.btnWhanau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWhanau.IconSize = 80;
            this.btnWhanau.Location = new System.Drawing.Point(338, 168);
            this.btnWhanau.Margin = new System.Windows.Forms.Padding(2);
            this.btnWhanau.Name = "btnWhanau";
            this.btnWhanau.Size = new System.Drawing.Size(133, 115);
            this.btnWhanau.TabIndex = 4;
            this.btnWhanau.Text = "WHĀNAU";
            this.btnWhanau.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWhanau.UseVisualStyleBackColor = true;
            this.btnWhanau.Click += new System.EventHandler(this.btnWhanau_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnRegistration.IconColor = System.Drawing.Color.Black;
            this.btnRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistration.IconSize = 80;
            this.btnRegistration.Location = new System.Drawing.Point(44, 303);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(133, 115);
            this.btnRegistration.TabIndex = 5;
            this.btnRegistration.Text = "REGISTRATION";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnReport.IconColor = System.Drawing.Color.Black;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 80;
            this.btnReport.Location = new System.Drawing.Point(189, 303);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(133, 115);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "REPORT";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 70;
            this.btnExit.Location = new System.Drawing.Point(483, 303);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 115);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(659, 448);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnWhanau);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnKai);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Kaioordinate - Community Event Management Software";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnKai;
        private FontAwesome.Sharp.IconButton btnEvents;
        private FontAwesome.Sharp.IconButton btnLocation;
        private FontAwesome.Sharp.IconButton btnWhanau;
        private FontAwesome.Sharp.IconButton btnRegistration;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}

