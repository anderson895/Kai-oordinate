namespace Kaoordinate
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventNo = new System.Windows.Forms.Label();
            this.lstEvent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtEventDate
            // 
            this.txtEventDate.BackColor = System.Drawing.Color.White;
            this.txtEventDate.Enabled = false;
            this.txtEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDate.Location = new System.Drawing.Point(638, 197);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.ReadOnly = true;
            this.txtEventDate.Size = new System.Drawing.Size(217, 34);
            this.txtEventDate.TabIndex = 35;
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Enabled = false;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(638, 141);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(394, 34);
            this.txtLocation.TabIndex = 34;
            // 
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.Color.White;
            this.txtEventName.Enabled = false;
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(638, 92);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(394, 34);
            this.txtEventName.TabIndex = 33;
            // 
            // txtEventID
            // 
            this.txtEventID.BackColor = System.Drawing.Color.White;
            this.txtEventID.Enabled = false;
            this.txtEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID.Location = new System.Drawing.Point(638, 38);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(217, 34);
            this.txtEventID.TabIndex = 32;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 80;
            this.btnReturn.Location = new System.Drawing.Point(927, 406);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(127, 120);
            this.btnReturn.TabIndex = 31;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 80;
            this.btnDelete.Location = new System.Drawing.Point(732, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 120);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 70;
            this.btnUpdate.Location = new System.Drawing.Point(599, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 120);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 80;
            this.btnAdd.Location = new System.Drawing.Point(466, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 120);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 80;
            this.btnDown.Location = new System.Drawing.Point(212, 406);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(127, 120);
            this.btnDown.TabIndex = 27;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 80;
            this.btnUp.Location = new System.Drawing.Point(68, 406);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(127, 120);
            this.btnUp.TabIndex = 26;
            this.btnUp.Text = "UP";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.ForeColor = System.Drawing.Color.White;
            this.lblEventDate.Location = new System.Drawing.Point(482, 200);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(129, 29);
            this.lblEventDate.TabIndex = 23;
            this.lblEventDate.Text = "Event Date";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(507, 146);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(104, 29);
            this.lblLocation.TabIndex = 22;
            this.lblLocation.Text = "Location";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(468, 92);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(144, 29);
            this.lblEventName.TabIndex = 21;
            this.lblEventName.Text = "Event Name";
            // 
            // lblEventNo
            // 
            this.lblEventNo.AutoSize = true;
            this.lblEventNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventNo.ForeColor = System.Drawing.Color.White;
            this.lblEventNo.Location = new System.Drawing.Point(510, 41);
            this.lblEventNo.Name = "lblEventNo";
            this.lblEventNo.Size = new System.Drawing.Size(102, 29);
            this.lblEventNo.TabIndex = 20;
            this.lblEventNo.Text = "Event ID";
            // 
            // lstEvent
            // 
            this.lstEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEvent.FormattingEnabled = true;
            this.lstEvent.ItemHeight = 29;
            this.lstEvent.Location = new System.Drawing.Point(33, 23);
            this.lstEvent.Name = "lstEvent";
            this.lstEvent.Size = new System.Drawing.Size(344, 352);
            this.lstEvent.TabIndex = 19;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1086, 549);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblEventNo);
            this.Controls.Add(this.lstEvent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventForm";
            this.Text = "Event Maintenance";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventID;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventNo;
        private System.Windows.Forms.ListBox lstEvent;
    }
}