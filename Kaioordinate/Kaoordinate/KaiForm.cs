using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kaoordinate
{
    public partial class KaiForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        public KaiForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mnu;
            BindControls();
        }

        public KaiForm()
        {
            InitializeComponent();
        }

        public void BindControls()
        {
            // Clear previous bindings
            txtKaiID.DataBindings.Clear();
            cmbEvent.DataBindings.Clear();
            txtKaiName.DataBindings.Clear();
            txtPreparation.DataBindings.Clear();
            txtPreparationTime.DataBindings.Clear();
            txtServingQuantity.DataBindings.Clear();

            // Bind textboxes
            txtKaiID.DataBindings.Add("Text", DM.dtKai, "KaiID");
            txtKaiName.DataBindings.Add("Text", DM.dtKai, "KaiName");
            txtPreparation.DataBindings.Add("Text", DM.dtKai, "PreparationRequired");
            txtPreparationTime.DataBindings.Add("Text", DM.dtKai, "PreparationMinutes");
            txtServingQuantity.DataBindings.Add("Text", DM.dtKai, "ServeQuantity");

            // Bind ComboBox as dropdown
            cmbEvent.DataSource = DM.dtEvent;          // DataTable with EventID & EventName
            cmbEvent.DisplayMember = "EventName";      // What the user sees
            cmbEvent.ValueMember = "EventID";          // The actual value
            cmbEvent.DataBindings.Add("SelectedValue", DM.dtKai, "EventID");

            // Bind listbox
            lstKai.DataSource = DM.dtKai;
            lstKai.DisplayMember = "KaiName";
            lstKai.ValueMember = "KaiID";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dtKai];

            // Set primary key
            if (DM.dtKai.PrimaryKey.Length == 0)
                DM.dtKai.PrimaryKey = new DataColumn[] { DM.dtKai.Columns["KaiID"] };
        }


        private void KaiForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(6, 73, 41);
        }

        // ================= NAVIGATION ===================
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0) currencyManager.Position--;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1) currencyManager.Position++;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ================= ADD ===================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstKai.Visible = false;
            txtKaiID.Visible = false;
            lblKaiNo.Visible = false;

            btnUp.Enabled = false;
            btnDown.Enabled = false;

            // Clear bindings to avoid overwriting the selected row
            txtKaiID.DataBindings.Clear();
            txtKaiName.DataBindings.Clear();
            txtPreparation.DataBindings.Clear();
            txtPreparationTime.DataBindings.Clear();
            txtServingQuantity.DataBindings.Clear();
            cmbEvent.DataBindings.Clear();

            // Clear input fields
            cmbEvent.SelectedIndex = -1;
            txtKaiName.Text = "";
            txtPreparation.Text = "";
            txtPreparationTime.Text = "";
            txtServingQuantity.Text = "";

            // Enable editing
            txtKaiName.ReadOnly = false; txtKaiName.Enabled = true;
            txtPreparation.ReadOnly = false; txtPreparation.Enabled = true;
            txtPreparationTime.ReadOnly = false; txtPreparationTime.Enabled = true;
            txtServingQuantity.ReadOnly = false; txtServingQuantity.Enabled = true;

            // Show save/cancel buttons
            btnSave_add.Visible = true;
            btnSave_update.Visible = false;
            button1.Visible = true;

            btnUpdate.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
        }


        private void btnSave_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtKaiName.Text))
                {
                    MessageBox.Show("Kai Name is required.", "Validation Error");
                    return;
                }

                if (cmbEvent.SelectedValue == null)
                {
                    MessageBox.Show("Please select an Event.", "Validation Error");
                    return;
                }

                // Create new DataRow
                DataRow newRow = DM.dtKai.NewRow();
                newRow["EventID"] = Convert.ToInt32(cmbEvent.SelectedValue);
                newRow["KaiName"] = txtKaiName.Text.Trim();
                newRow["PreparationRequired"] = txtPreparation.Text.Trim();
                newRow["PreparationMinutes"] = txtPreparationTime.Text.Trim();
                newRow["ServeQuantity"] = txtServingQuantity.Text.Trim();

                // Add to DataTable
                DM.dtKai.Rows.Add(newRow);
                DM.UpdateKai();

                MessageBox.Show("Kai added successfully.", "Success");

                // Move CurrencyManager to the new row
                currencyManager.Position = DM.dtKai.Rows.IndexOf(newRow);

                // Reset form
                ResetFormState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding Kai: " + ex.Message, "Error");
            }
        }


        // ================= UPDATE ===================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;

            txtKaiName.ReadOnly = false; txtKaiName.Enabled = true;
            txtPreparation.ReadOnly = false; txtPreparation.Enabled = true;
            txtPreparationTime.ReadOnly = false; txtPreparationTime.Enabled = true;
            txtServingQuantity.ReadOnly = false; txtServingQuantity.Enabled = true;

            btnSave_update.Visible = true;
            btnSave_add.Visible = false;
            button1.Visible = true;

            btnAdd.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstKai.SelectedValue == null) return;

                int kaiID = (int)lstKai.SelectedValue;
                DataRow rowToUpdate = DM.dtKai.Rows.Find(kaiID);

                if (rowToUpdate != null)
                {
                    rowToUpdate["EventID"] = Convert.ToInt32(cmbEvent.SelectedValue); // <-- dito
                    rowToUpdate["KaiName"] = txtKaiName.Text.Trim();
                    rowToUpdate["PreparationRequired"] = txtPreparation.Text.Trim();
                    rowToUpdate["PreparationMinutes"] = txtPreparationTime.Text.Trim();
                    rowToUpdate["ServeQuantity"] = txtServingQuantity.Text.Trim();

                    if (BindingContext[DM.dtKai] is CurrencyManager cm)
                        cm.EndCurrentEdit();

                    DM.UpdateKai();
                    MessageBox.Show("Kai updated successfully.", "Success");
                    ResetFormState();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Kai: " + ex.Message, "Error");
            }
        }

        // ================= DELETE ===================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstKai.SelectedValue == null) return;

                int kaiID = (int)lstKai.SelectedValue;

                if (MessageBox.Show("Delete this Kai?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataRow rowToDelete = DM.dtKai.Rows.Find(kaiID);
                    if (rowToDelete != null)
                    {
                        rowToDelete.Delete();
                        DM.UpdateKai();
                        MessageBox.Show("Kai deleted successfully.", "Success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting Kai: " + ex.Message, "Error");
            }
        }

        // ================= CANCEL ===================
        private void button1_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            ResetFormState();
        }


        private void ResetFormState()
        {
            lstKai.Visible = true;
            txtKaiID.Visible = true;
            lblKaiNo.Visible = true;

            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnUpdate.Enabled = true;
            btnReturn.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

            txtKaiName.ReadOnly = true; txtKaiName.Enabled = false;
            txtPreparation.ReadOnly = true; txtPreparation.Enabled = false;
            txtPreparationTime.ReadOnly = true; txtPreparationTime.Enabled = false;
            txtServingQuantity.ReadOnly = true; txtServingQuantity.Enabled = false;

            btnSave_add.Visible = false;
            btnSave_update.Visible = false;
            button1.Visible = false;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lstKai.SelectedValue == null) return;

                int kaiID = (int)lstKai.SelectedValue;

                if (MessageBox.Show("Delete this Kai?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataRow rowToDelete = DM.dtKai.Rows.Find(kaiID);
                    if (rowToDelete != null)
                    {
                        rowToDelete.Delete();
                        DM.UpdateKai();
                        MessageBox.Show("Kai deleted successfully.", "Success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting Kai: " + ex.Message, "Error");
            }
        }
    }
}
