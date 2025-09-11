using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kaoordinate
{
    public partial class WhanauForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        public WhanauForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mnu;
            BindControls();
        }

        public WhanauForm()
        {
            InitializeComponent();
        }

        private void WhanauForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(6, 73, 41);
        }

        // ================= BINDING ===================
        public void BindControls()
        {
            txtWhanauID.DataBindings.Clear();
            txtFirstName.DataBindings.Clear();
            txtLastName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtWhanauAddress.DataBindings.Clear();

            txtWhanauID.DataBindings.Add("Text", DM.dtWhanau, "WhanauID");
            txtFirstName.DataBindings.Add("Text", DM.dtWhanau, "FirstName");
            txtLastName.DataBindings.Add("Text", DM.dtWhanau, "LastName");
            txtEmail.DataBindings.Add("Text", DM.dtWhanau, "Email");
            txtPhone.DataBindings.Add("Text", DM.dtWhanau, "Phone");
            txtWhanauAddress.DataBindings.Add("Text", DM.dtWhanau, "Address");

            if (!DM.dtWhanau.Columns.Contains("FullName"))
            {
                DM.dtWhanau.Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
            }

            lstWhanau.DataSource = DM.dtWhanau;
            lstWhanau.DisplayMember = "FullName";
            lstWhanau.ValueMember = "WhanauID";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dtWhanau];
        }

        // ================= NAVIGATION ===================
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ================= ADD ===================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstWhanau.Visible = false;
            lblWhanauID.Visible = false;
            txtWhanauID.Visible = false;

            btnUp.Enabled = false;
            btnDown.Enabled = false;

            // Clear bindings to avoid overwriting current row
            txtWhanauID.DataBindings.Clear();
            txtFirstName.DataBindings.Clear();
            txtLastName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtWhanauAddress.DataBindings.Clear();

            // Clear inputs
            txtWhanauID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtWhanauAddress.Text = "";

            // Enable editing
            txtFirstName.ReadOnly = false; txtFirstName.Enabled = true;
            txtLastName.ReadOnly = false; txtLastName.Enabled = true;
            txtEmail.ReadOnly = false; txtEmail.Enabled = true;
            txtPhone.ReadOnly = false; txtPhone.Enabled = true;
            txtWhanauAddress.ReadOnly = false; txtWhanauAddress.Enabled = true;

            // Buttons
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
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("First Name and Last Name are required.", "Validation Error");
                    return;
                }

                // Create new row
                DataRow newWhanauRow = DM.dtWhanau.NewRow();
                newWhanauRow["FirstName"] = txtFirstName.Text.Trim();
                newWhanauRow["LastName"] = txtLastName.Text.Trim();
                newWhanauRow["Email"] = txtEmail.Text.Trim();
                newWhanauRow["Phone"] = txtPhone.Text.Trim();
                newWhanauRow["Address"] = txtWhanauAddress.Text.Trim();

                DM.dtWhanau.Rows.Add(newWhanauRow);
                DM.UpdateWhanau();

                MessageBox.Show("Whanau successfully added.", "Success");

                // Rebind to refresh view
                BindControls();

                // Move to newly added row
                int newIndex = DM.dtWhanau.Rows.IndexOf(newWhanauRow);
                if (newIndex >= 0)
                {
                    currencyManager.Position = newIndex;
                }

                ResetFormState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding Whanau: " + ex.Message, "Error");
            }
        }

        // ================= UPDATE ===================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;

            txtFirstName.ReadOnly = false; txtFirstName.Enabled = true;
            txtLastName.ReadOnly = false; txtLastName.Enabled = true;
            txtEmail.ReadOnly = false; txtEmail.Enabled = true;
            txtPhone.ReadOnly = false; txtPhone.Enabled = true;
            txtWhanauAddress.ReadOnly = false; txtWhanauAddress.Enabled = true;

            btnSave_update.Visible = true;
            btnSave_add.Visible = false;
            btnCancel.Visible = true;

            btnAdd.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstWhanau.SelectedValue == null) return;

                int whanauID = (int)lstWhanau.SelectedValue;
                DataRow rowToUpdate = DM.dtWhanau.Rows.Find(whanauID);

                if (rowToUpdate != null)
                {
                    rowToUpdate["FirstName"] = txtFirstName.Text.Trim();
                    rowToUpdate["LastName"] = txtLastName.Text.Trim();
                    rowToUpdate["Email"] = txtEmail.Text.Trim();
                    rowToUpdate["Phone"] = txtPhone.Text.Trim();
                    rowToUpdate["Address"] = txtWhanauAddress.Text.Trim();

                    // Commit any pending edits
                    if (BindingContext[DM.dtWhanau] is CurrencyManager cm)
                        cm.EndCurrentEdit();

                    DM.UpdateWhanau();

                    MessageBox.Show("Whanau successfully updated.", "Success");
                    ResetFormState();
                }
                else
                {
                    MessageBox.Show("Selected Whanau not found.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Whanau: " + ex.Message, "Error");
            }
        }



        // ================= DELETE ===================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int whanauID = int.Parse(txtWhanauID.Text);

                if (MessageBox.Show("Delete this Whanau?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataRow rowToDelete = DM.dtWhanau.Rows.Find(whanauID);
                    if (rowToDelete != null)
                    {
                        rowToDelete.Delete();
                        DM.UpdateWhanau();
                        MessageBox.Show("Whanau successfully deleted.", "Success");
                        currencyManager.Refresh();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error deleting Whanau.", "Error");
            }
        }

        // ================= CANCEL / RESET ===================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }

        private void ResetFormState()
        {
            lstWhanau.Visible = true;
            lblWhanauID.Visible = true;
            txtWhanauID.Visible = true;

            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnUpdate.Enabled = true;
            btnReturn.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;

            txtFirstName.ReadOnly = true; txtFirstName.Enabled = false;
            txtLastName.ReadOnly = true; txtLastName.Enabled = false;
            txtEmail.ReadOnly = true; txtEmail.Enabled = false;
            txtPhone.ReadOnly = true; txtPhone.Enabled = false;
            txtWhanauAddress.ReadOnly = true; txtWhanauAddress.Enabled = false;

            btnSave_add.Visible = false;
            btnCancel.Visible = false;
            btnSave_update.Visible = false;

            currencyManager.Refresh();
        }
    }
}
