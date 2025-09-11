namespace Kaoordinate
{
    partial class LocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationForm));
            this.txtLocationAddress = new System.Windows.Forms.TextBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.lblLocationAddress = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblWhanauID = new System.Windows.Forms.Label();
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.btnSave_update = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocationAddress
            // 
            this.txtLocationAddress.BackColor = System.Drawing.Color.White;
            this.txtLocationAddress.Enabled = false;
            this.txtLocationAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationAddress.Location = new System.Drawing.Point(470, 131);
            this.txtLocationAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocationAddress.Multiline = true;
            this.txtLocationAddress.Name = "txtLocationAddress";
            this.txtLocationAddress.ReadOnly = true;
            this.txtLocationAddress.Size = new System.Drawing.Size(296, 137);
            this.txtLocationAddress.TabIndex = 53;
            // 
            // txtLocationName
            // 
            this.txtLocationName.BackColor = System.Drawing.Color.White;
            this.txtLocationName.Enabled = false;
            this.txtLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationName.Location = new System.Drawing.Point(470, 91);
            this.txtLocationName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.ReadOnly = true;
            this.txtLocationName.Size = new System.Drawing.Size(296, 28);
            this.txtLocationName.TabIndex = 52;
            // 
            // txtLocationID
            // 
            this.txtLocationID.BackColor = System.Drawing.Color.White;
            this.txtLocationID.Enabled = false;
            this.txtLocationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationID.Location = new System.Drawing.Point(470, 47);
            this.txtLocationID.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.ReadOnly = true;
            this.txtLocationID.Size = new System.Drawing.Size(164, 28);
            this.txtLocationID.TabIndex = 51;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 80;
            this.btnReturn.Location = new System.Drawing.Point(687, 362);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 98);
            this.btnReturn.TabIndex = 50;
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
            this.btnDelete.Location = new System.Drawing.Point(541, 362);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 98);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 70;
            this.btnUpdate.Location = new System.Drawing.Point(441, 362);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 98);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 80;
            this.btnAdd.Location = new System.Drawing.Point(341, 362);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 98);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 80;
            this.btnDown.Location = new System.Drawing.Point(151, 362);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(95, 98);
            this.btnDown.TabIndex = 46;
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
            this.btnUp.Location = new System.Drawing.Point(43, 362);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(95, 98);
            this.btnUp.TabIndex = 45;
            this.btnUp.Text = "UP";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblLocationAddress
            // 
            this.lblLocationAddress.AutoSize = true;
            this.lblLocationAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationAddress.ForeColor = System.Drawing.Color.White;
            this.lblLocationAddress.Location = new System.Drawing.Point(354, 133);
            this.lblLocationAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationAddress.Name = "lblLocationAddress";
            this.lblLocationAddress.Size = new System.Drawing.Size(80, 24);
            this.lblLocationAddress.TabIndex = 41;
            this.lblLocationAddress.Text = "Address";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.ForeColor = System.Drawing.Color.White;
            this.lblLocationName.Location = new System.Drawing.Point(319, 93);
            this.lblLocationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(137, 24);
            this.lblLocationName.TabIndex = 40;
            this.lblLocationName.Text = "Location Name";
            // 
            // lblWhanauID
            // 
            this.lblWhanauID.AutoSize = true;
            this.lblWhanauID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhanauID.ForeColor = System.Drawing.Color.White;
            this.lblWhanauID.Location = new System.Drawing.Point(354, 50);
            this.lblWhanauID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhanauID.Name = "lblWhanauID";
            this.lblWhanauID.Size = new System.Drawing.Size(103, 24);
            this.lblWhanauID.TabIndex = 39;
            this.lblWhanauID.Text = "Location ID";
            // 
            // lstLocation
            // 
            this.lstLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.ItemHeight = 22;
            this.lstLocation.Location = new System.Drawing.Point(16, 35);
            this.lstLocation.Margin = new System.Windows.Forms.Padding(2);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(259, 268);
            this.lstLocation.TabIndex = 38;
            // 
            // btnSave_update
            // 
            this.btnSave_update.Location = new System.Drawing.Point(470, 280);
            this.btnSave_update.Name = "btnSave_update";
            this.btnSave_update.Size = new System.Drawing.Size(118, 23);
            this.btnSave_update.TabIndex = 55;
            this.btnSave_update.Text = "Save Update";
            this.btnSave_update.UseVisualStyleBackColor = true;
            this.btnSave_update.Visible = false;
            this.btnSave_update.Click += new System.EventHandler(this.btnSave_update_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(600, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave_add
            // 
            this.btnSave_add.Location = new System.Drawing.Point(470, 280);
            this.btnSave_add.Name = "btnSave_add";
            this.btnSave_add.Size = new System.Drawing.Size(118, 23);
            this.btnSave_add.TabIndex = 56;
            this.btnSave_add.Text = "Save Add";
            this.btnSave_add.UseVisualStyleBackColor = true;
            this.btnSave_add.Visible = false;
            this.btnSave_add.Click += new System.EventHandler(this.btnSave_add_Click);
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(799, 494);
            this.Controls.Add(this.btnSave_add);
            this.Controls.Add(this.btnSave_update);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLocationAddress);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.txtLocationID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblLocationAddress);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.lblWhanauID);
            this.Controls.Add(this.lstLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LocationForm";
            this.Text = "Location Maintenance";
            this.Load += new System.EventHandler(this.LocationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLocationAddress;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.TextBox txtLocationID;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.Label lblLocationAddress;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblWhanauID;
        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.Button btnSave_update;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave_add;
    }
}