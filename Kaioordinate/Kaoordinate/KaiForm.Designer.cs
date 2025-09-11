namespace Kaoordinate
{
    partial class KaiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaiForm));
            this.lstKai = new System.Windows.Forms.ListBox();
            this.lblKaiNo = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblKaiName = new System.Windows.Forms.Label();
            this.lblPreparation = new System.Windows.Forms.Label();
            this.lblPreparationTime = new System.Windows.Forms.Label();
            this.lblServingQuantity = new System.Windows.Forms.Label();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.txtKaiID = new System.Windows.Forms.TextBox();
            this.txtKaiName = new System.Windows.Forms.TextBox();
            this.txtPreparation = new System.Windows.Forms.TextBox();
            this.txtPreparationTime = new System.Windows.Forms.TextBox();
            this.txtServingQuantity = new System.Windows.Forms.TextBox();
            this.panelSave = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnSave_update = new System.Windows.Forms.Button();
            this.btnSave_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.panelSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKai
            // 
            this.lstKai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKai.FormattingEnabled = true;
            this.lstKai.ItemHeight = 22;
            this.lstKai.Location = new System.Drawing.Point(26, 25);
            this.lstKai.Margin = new System.Windows.Forms.Padding(2);
            this.lstKai.Name = "lstKai";
            this.lstKai.Size = new System.Drawing.Size(259, 268);
            this.lstKai.TabIndex = 0;
            // 
            // lblKaiNo
            // 
            this.lblKaiNo.AutoSize = true;
            this.lblKaiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiNo.ForeColor = System.Drawing.Color.White;
            this.lblKaiNo.Location = new System.Drawing.Point(403, 41);
            this.lblKaiNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaiNo.Name = "lblKaiNo";
            this.lblKaiNo.Size = new System.Drawing.Size(58, 24);
            this.lblKaiNo.TabIndex = 1;
            this.lblKaiNo.Text = "Kai ID";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.Color.White;
            this.lblEvent.Location = new System.Drawing.Point(406, 72);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(58, 24);
            this.lblEvent.TabIndex = 2;
            this.lblEvent.Text = "Event";
            // 
            // lblKaiName
            // 
            this.lblKaiName.AutoSize = true;
            this.lblKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaiName.ForeColor = System.Drawing.Color.White;
            this.lblKaiName.Location = new System.Drawing.Point(371, 105);
            this.lblKaiName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaiName.Name = "lblKaiName";
            this.lblKaiName.Size = new System.Drawing.Size(92, 24);
            this.lblKaiName.TabIndex = 3;
            this.lblKaiName.Text = "Kai Name";
            // 
            // lblPreparation
            // 
            this.lblPreparation.AutoSize = true;
            this.lblPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparation.ForeColor = System.Drawing.Color.White;
            this.lblPreparation.Location = new System.Drawing.Point(347, 135);
            this.lblPreparation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreparation.Name = "lblPreparation";
            this.lblPreparation.Size = new System.Drawing.Size(116, 24);
            this.lblPreparation.TabIndex = 4;
            this.lblPreparation.Text = "Preparation?";
            // 
            // lblPreparationTime
            // 
            this.lblPreparationTime.AutoSize = true;
            this.lblPreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparationTime.ForeColor = System.Drawing.Color.White;
            this.lblPreparationTime.Location = new System.Drawing.Point(310, 168);
            this.lblPreparationTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreparationTime.Name = "lblPreparationTime";
            this.lblPreparationTime.Size = new System.Drawing.Size(154, 24);
            this.lblPreparationTime.TabIndex = 5;
            this.lblPreparationTime.Text = "Preparation Time";
            // 
            // lblServingQuantity
            // 
            this.lblServingQuantity.AutoSize = true;
            this.lblServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServingQuantity.ForeColor = System.Drawing.Color.White;
            this.lblServingQuantity.Location = new System.Drawing.Point(320, 199);
            this.lblServingQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServingQuantity.Name = "lblServingQuantity";
            this.lblServingQuantity.Size = new System.Drawing.Size(147, 24);
            this.lblServingQuantity.TabIndex = 6;
            this.lblServingQuantity.Text = "Serving Quantity";
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 80;
            this.btnUp.Location = new System.Drawing.Point(52, 336);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(95, 98);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "UP";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 80;
            this.btnDown.Location = new System.Drawing.Point(160, 336);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(95, 98);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 80;
            this.btnAdd.Location = new System.Drawing.Point(351, 336);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 98);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 70;
            this.btnUpdate.Location = new System.Drawing.Point(451, 336);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 98);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 80;
            this.btnDelete.Location = new System.Drawing.Point(550, 336);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 98);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 80;
            this.btnReturn.Location = new System.Drawing.Point(697, 336);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 98);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtKaiID
            // 
            this.txtKaiID.BackColor = System.Drawing.Color.White;
            this.txtKaiID.Enabled = false;
            this.txtKaiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKaiID.Location = new System.Drawing.Point(480, 37);
            this.txtKaiID.Margin = new System.Windows.Forms.Padding(2);
            this.txtKaiID.Name = "txtKaiID";
            this.txtKaiID.ReadOnly = true;
            this.txtKaiID.Size = new System.Drawing.Size(164, 28);
            this.txtKaiID.TabIndex = 13;
            // 
            // txtKaiName
            // 
            this.txtKaiName.BackColor = System.Drawing.Color.White;
            this.txtKaiName.Enabled = false;
            this.txtKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKaiName.Location = new System.Drawing.Point(480, 101);
            this.txtKaiName.Margin = new System.Windows.Forms.Padding(2);
            this.txtKaiName.Name = "txtKaiName";
            this.txtKaiName.ReadOnly = true;
            this.txtKaiName.Size = new System.Drawing.Size(296, 28);
            this.txtKaiName.TabIndex = 15;
            // 
            // txtPreparation
            // 
            this.txtPreparation.BackColor = System.Drawing.Color.White;
            this.txtPreparation.Enabled = false;
            this.txtPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreparation.Location = new System.Drawing.Point(480, 133);
            this.txtPreparation.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreparation.Name = "txtPreparation";
            this.txtPreparation.ReadOnly = true;
            this.txtPreparation.Size = new System.Drawing.Size(164, 28);
            this.txtPreparation.TabIndex = 16;
            // 
            // txtPreparationTime
            // 
            this.txtPreparationTime.BackColor = System.Drawing.Color.White;
            this.txtPreparationTime.Enabled = false;
            this.txtPreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreparationTime.Location = new System.Drawing.Point(480, 165);
            this.txtPreparationTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreparationTime.Name = "txtPreparationTime";
            this.txtPreparationTime.ReadOnly = true;
            this.txtPreparationTime.Size = new System.Drawing.Size(164, 28);
            this.txtPreparationTime.TabIndex = 17;
            // 
            // txtServingQuantity
            // 
            this.txtServingQuantity.BackColor = System.Drawing.Color.White;
            this.txtServingQuantity.Enabled = false;
            this.txtServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServingQuantity.Location = new System.Drawing.Point(480, 197);
            this.txtServingQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtServingQuantity.Name = "txtServingQuantity";
            this.txtServingQuantity.ReadOnly = true;
            this.txtServingQuantity.Size = new System.Drawing.Size(164, 28);
            this.txtServingQuantity.TabIndex = 18;
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.btnCancel);
            this.panelSave.Controls.Add(this.btnSave);
            this.panelSave.Location = new System.Drawing.Point(786, 189);
            this.panelSave.Margin = new System.Windows.Forms.Padding(2);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(490, 142);
            this.panelSave.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 80;
            this.btnCancel.Location = new System.Drawing.Point(195, 25);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 98);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 80;
            this.btnSave.Location = new System.Drawing.Point(49, 25);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 98);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "ADD";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSave_update
            // 
            this.btnSave_update.Location = new System.Drawing.Point(437, 276);
            this.btnSave_update.Name = "btnSave_update";
            this.btnSave_update.Size = new System.Drawing.Size(118, 23);
            this.btnSave_update.TabIndex = 43;
            this.btnSave_update.Text = "Save Update";
            this.btnSave_update.UseVisualStyleBackColor = true;
            this.btnSave_update.Visible = false;
            this.btnSave_update.Click += new System.EventHandler(this.btnSave_update_Click);
            // 
            // btnSave_add
            // 
            this.btnSave_add.Location = new System.Drawing.Point(437, 247);
            this.btnSave_add.Name = "btnSave_add";
            this.btnSave_add.Size = new System.Drawing.Size(118, 23);
            this.btnSave_add.TabIndex = 41;
            this.btnSave_add.Text = "Save Add";
            this.btnSave_add.UseVisualStyleBackColor = true;
            this.btnSave_add.Visible = false;
            this.btnSave_add.Click += new System.EventHandler(this.btnSave_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmbEvent
            // 
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(480, 72);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(165, 21);
            this.cmbEvent.TabIndex = 56;
            // 
            // KaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(817, 459);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave_update);
            this.Controls.Add(this.btnSave_add);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.txtServingQuantity);
            this.Controls.Add(this.txtPreparationTime);
            this.Controls.Add(this.txtPreparation);
            this.Controls.Add(this.txtKaiName);
            this.Controls.Add(this.txtKaiID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblServingQuantity);
            this.Controls.Add(this.lblPreparationTime);
            this.Controls.Add(this.lblPreparation);
            this.Controls.Add(this.lblKaiName);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblKaiNo);
            this.Controls.Add(this.lstKai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KaiForm";
            this.Text = "Kai Maintenance";
            this.Load += new System.EventHandler(this.KaiForm_Load);
            this.panelSave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKai;
        private System.Windows.Forms.Label lblKaiNo;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblKaiName;
        private System.Windows.Forms.Label lblPreparation;
        private System.Windows.Forms.Label lblPreparationTime;
        private System.Windows.Forms.Label lblServingQuantity;
        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.TextBox txtKaiID;
        private System.Windows.Forms.TextBox txtKaiName;
        private System.Windows.Forms.TextBox txtPreparation;
        private System.Windows.Forms.TextBox txtPreparationTime;
        private System.Windows.Forms.TextBox txtServingQuantity;
        private System.Windows.Forms.Panel panelSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Button btnSave_update;
        private System.Windows.Forms.Button btnSave_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbEvent;
    }
}