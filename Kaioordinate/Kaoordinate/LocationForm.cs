using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kaoordinate
{
    public partial class LocationForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        public LocationForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mnu;
            BindControls();
        }

        public LocationForm()
        {
            InitializeComponent();
        }

        public void BindControls()
        {
            // Clear previous bindings
            txtLocationID.DataBindings.Clear();
            txtLocationName.DataBindings.Clear();
            txtLocationAddress.DataBindings.Clear();

            txtLocationID.DataBindings.Add("Text", DM.dtLocation, "LocationID");
            txtLocationName.DataBindings.Add("Text", DM.dtLocation, "LocationName");
            txtLocationAddress.DataBindings.Add("Text", DM.dtLocation, "Address");

            lstLocation.DataSource = DM.dtLocation;
            lstLocation.DisplayMember = "LocationName";
            lstLocation.ValueMember = "LocationID";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dtLocation];

            // Ensure Primary Key exists
            if (DM.dtLocation.PrimaryKey.Length == 0)
                DM.dtLocation.PrimaryKey = new DataColumn[] { DM.dtLocation.Columns["LocationID"] };
        }

        private void LocationForm_Load(object sender, EventArgs e)
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
            lblWhanauID.Visible = false;
            lstLocation.Visible = false;
            txtLocationID.Visible = false;

            btnUp.Enabled = false;
            btnDown.Enabled = false;

            // Clear bindings to avoid updating the selected row
            txtLocationID.DataBindings.Clear();
            txtLocationName.DataBindings.Clear();
            txtLocationAddress.DataBindings.Clear();

            // Clear input fields
            txtLocationName.Text = "";
            txtLocationAddress.Text = "";

            // Enable editing
            txtLocationName.ReadOnly = false; txtLocationName.Enabled = true;
            txtLocationAddress.ReadOnly = false; txtLocationAddress.Enabled = true;

            // Show appropriate buttons
            btnSave_add.Visible = true;
            btnSave_update.Visible = false;
            btnCancel.Visible = true;

            btnUpdate.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
        }


        private void btnSave_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLocationName.Text))
                {
                    MessageBox.Show("Location Name is required.", "Validation Error");
                    return;
                }

                DataRow newRow = DM.dtLocation.NewRow();
                newRow["LocationName"] = txtLocationName.Text.Trim();
                newRow["Address"] = txtLocationAddress.Text.Trim();

                DM.dtLocation.Rows.Add(newRow);
                DM.UpdateLocation();

                MessageBox.Show("Location added successfully.", "Success");

                // Move CurrencyManager to new row
                currencyManager.Position = DM.dtLocation.Rows.IndexOf(newRow);

                ResetFormState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding location: " + ex.Message, "Error");
            }
        }


        // ================= UPDATE ===================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;

            txtLocationName.ReadOnly = false; txtLocationName.Enabled = true;
            txtLocationAddress.ReadOnly = false; txtLocationAddress.Enabled = true;

            btnSave_update.Visible = true;
            btnSave_add.Visible = false;
            btnCancel.Visible = true;
            lstLocation.Visible = false;

            btnAdd.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstLocation.SelectedValue == null) return;

                int locationID = (int)lstLocation.SelectedValue;
                DataRow rowToUpdate = DM.dtLocation.Rows.Find(locationID);

                if (rowToUpdate != null)
                {
                    rowToUpdate["LocationName"] = txtLocationName.Text.Trim();
                    rowToUpdate["Address"] = txtLocationAddress.Text.Trim();

                    // End edit and commit
                    if (BindingContext[DM.dtLocation] is CurrencyManager cm)
                        cm.EndCurrentEdit();

                    DM.UpdateLocation();
                    MessageBox.Show("Location updated successfully.", "Success");

                    ResetFormState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating location: " + ex.Message, "Error");
            }
        }

        // ================= DELETE ===================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstLocation.SelectedValue == null) return;

                int locationID = (int)lstLocation.SelectedValue;

                if (MessageBox.Show("Delete this location?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataRow rowToDelete = DM.dtLocation.Rows.Find(locationID);
                    if (rowToDelete != null)
                    {
                        rowToDelete.Delete();
                        DM.UpdateLocation();
                        MessageBox.Show("Location deleted successfully.", "Success");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting location: " + ex.Message, "Error");
            }
        }

        // ================= CANCEL ===================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }

        private void ResetFormState()
        {
            lstLocation.Visible = true;
            txtLocationID.Visible = true;
            lblWhanauID.Visible = true;

            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnUpdate.Enabled = true;
            btnReturn.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

            txtLocationName.ReadOnly = true; txtLocationName.Enabled = false;
            txtLocationAddress.ReadOnly = true; txtLocationAddress.Enabled = false;

            btnSave_add.Visible = false;
            btnSave_update.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
