using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kaoordinate
{
    public partial class EventForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        public EventForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mnu;
            BindControls();
            lstEvent.SelectedIndexChanged += LstEvent_SelectedIndexChanged;
        }

        private void BindControls()
        {
            // Clear previous bindings
            txtEventID.DataBindings.Clear();
            txtEventName.DataBindings.Clear();
            dtpEventDate.DataBindings.Clear();

            // Bind textboxes and datetime
            txtEventID.DataBindings.Add("Text", DM.dtEvent, "EventID");
            txtEventName.DataBindings.Add("Text", DM.dtEvent, "EventName");
            dtpEventDate.DataBindings.Add("Value", DM.dtEvent, "EventDate");

            // Setup Location ComboBox (do not bind SelectedValue)
            cmbLocation.DataSource = DM.dtLocation;
            cmbLocation.DisplayMember = "LocationName";
            cmbLocation.ValueMember = "LocationID";

            // Bind ListBox
            lstEvent.DataSource = DM.dtEvent;
            lstEvent.DisplayMember = "EventName";
            lstEvent.ValueMember = "EventID";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dtEvent];

            if (DM.dtEvent.PrimaryKey.Length == 0)
                DM.dtEvent.PrimaryKey = new DataColumn[] { DM.dtEvent.Columns["EventID"] };
        }

        private void LstEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEvent.SelectedValue == null) return;

            int eventID = (int)lstEvent.SelectedValue;
            DataRow row = DM.dtEvent.Rows.Find(eventID);
            if (row != null)
            {
                txtEventID.Text = row["EventID"].ToString();
                txtEventName.Text = row["EventName"].ToString();
                dtpEventDate.Value = Convert.ToDateTime(row["EventDate"]);

                // Manually set selected LocationID
                int locID = Convert.ToInt32(row["LocationID"]);
                cmbLocation.SelectedValue = locID;
            }
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(6, 73, 41);
            ResetFormState();
        }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFormState();
            LstEvent_SelectedIndexChanged(null, null);
        }

        private void ResetFormState()
        {
            lstEvent.Visible = true;
            txtEventID.Visible = true;
            lblEventNo.Visible = true;

            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnUpdate.Enabled = true;
            btnReturn.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

            txtEventName.ReadOnly = true; txtEventName.Enabled = false;
            cmbLocation.Enabled = false;
            dtpEventDate.Enabled = false;

            btnSave_add.Visible = false;
            btnSave_update.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstEvent.Visible=false;
            txtEventID.Visible = false;
            lblEventNo.Visible = false;

            btnUp.Enabled = false;
            btnDown.Enabled = false;

            // Clear bindings BEFORE user types
            txtEventID.DataBindings.Clear();
            txtEventName.DataBindings.Clear();
            dtpEventDate.DataBindings.Clear();

            // Clear input fields
            txtEventName.Text = "";
            cmbLocation.SelectedIndex = -1;
            dtpEventDate.Value = DateTime.Now;

            // Enable editing
            txtEventName.ReadOnly = false; txtEventName.Enabled = true;
            cmbLocation.Enabled = true;
            dtpEventDate.Enabled = true;

            // Show appropriate buttons
            btnSave_add.Visible = true;
            btnSave_update.Visible = false;
            btnCancel.Visible = true;

            btnUpdate.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstEvent.SelectedValue == null) return;


            lstEvent.Visible = false;
            txtEventName.ReadOnly = false; txtEventName.Enabled = true;
            cmbLocation.Enabled = true;
            dtpEventDate.Enabled = true;

            btnSave_update.Visible = true;
            btnSave_add.Visible = false;
            btnCancel.Visible = true;

            btnAdd.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
        }

        private void btnSave_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEventName.Text))
                {
                    MessageBox.Show("Event Name is required.", "Validation Error");
                    return;
                }

                if (cmbLocation.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Location.", "Validation Error");
                    return;
                }

                // Create new DataRow AFTER user input
                DataRow newRow = DM.dtEvent.NewRow();
                newRow["EventName"] = txtEventName.Text.Trim();
                newRow["LocationID"] = Convert.ToInt32(cmbLocation.SelectedValue);
                newRow["EventDate"] = dtpEventDate.Value;

                // Add row to DataTable
                DM.dtEvent.Rows.Add(newRow);

                // Commit to database
                DM.UpdateEvent();

                MessageBox.Show("Event added successfully.", "Success");

                // Move CurrencyManager to new row
                currencyManager.Position = DM.dtEvent.Rows.IndexOf(newRow);

                // Reset form
                ResetFormState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding Event: " + ex.Message, "Error");
            }
        }


        private void btnSave_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEvent.SelectedValue == null) return;

                int eventID = (int)lstEvent.SelectedValue;
                DataRow rowToUpdate = DM.dtEvent.Rows.Find(eventID);

                if (rowToUpdate != null)
                {
                    if (cmbLocation.SelectedValue == null)
                    {
                        MessageBox.Show("Please select a Location.", "Validation Error");
                        return;
                    }

                    int locationID = Convert.ToInt32(cmbLocation.SelectedValue);

                    // Debug: Show IDs
                    //MessageBox.Show($"Updating EventID: {eventID}\nNew LocationID: {locationID}");

                    // Update DataRow
                    rowToUpdate["EventName"] = txtEventName.Text.Trim();
                    rowToUpdate["LocationID"] = locationID;
                    rowToUpdate["EventDate"] = dtpEventDate.Value;

                    // Commit the change manually
                    DM.UpdateEvent();

                    MessageBox.Show("Event updated successfully.", "Success");

                    // Refresh ComboBox selection
                    LstEvent_SelectedIndexChanged(null, null);

                    ResetFormState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Event: " + ex.Message, "Error");
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEvent.SelectedValue == null) return;

                int eventID = (int)lstEvent.SelectedValue;

                if (MessageBox.Show("Delete this Event?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataRow rowToDelete = DM.dtEvent.Rows.Find(eventID);
                    if (rowToDelete != null)
                    {
                        rowToDelete.Delete();
                        if (BindingContext[DM.dtEvent] is CurrencyManager cm) cm.EndCurrentEdit();
                        DM.UpdateEvent();
                        MessageBox.Show("Event deleted successfully.", "Success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting Event: " + ex.Message, "Error");
            }
        }
    }
}
