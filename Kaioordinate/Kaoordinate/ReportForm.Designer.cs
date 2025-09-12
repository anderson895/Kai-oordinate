namespace Kaoordinate
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.cboEvents = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboEvents
            // 
            this.cboEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvents.FormattingEnabled = true;
            this.cboEvents.Location = new System.Drawing.Point(166, 111);
            this.cboEvents.Name = "cboEvents";
            this.cboEvents.Size = new System.Drawing.Size(233, 21);
            this.cboEvents.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "GENERATE REPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportForm";
            this.Text = "Report Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEvents;
        private System.Windows.Forms.Button button1;
    }
}