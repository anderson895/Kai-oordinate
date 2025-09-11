using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void BindControls()
        {
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

        public WhanauForm()
        {
            InitializeComponent();
        }

        private void WhanauForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(6, 73, 41);
        }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstWhanau.Visible = false;
            lblWhanauID.Visible = false;
            txtWhanauID.Visible = false;

            btnUp.Enabled = false;
            btnDown.Enabled = false;

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtWhanauAddress.Text = "";

            //editable at enabled
            txtFirstName.ReadOnly = false;
            txtFirstName.Enabled = true;

            txtLastName.ReadOnly = false;
            txtLastName.Enabled = true;

            txtEmail.ReadOnly = false;
            txtEmail.Enabled = true;

            txtPhone.ReadOnly = false;
            txtPhone.Enabled = true;

            txtWhanauAddress.ReadOnly = false;
            txtWhanauAddress.Enabled = true;

            //buttons
            btnSave_add.Visible = true;
            btnSave_update.Visible = false;
            btnCancel.Visible = true;

            btnUpdate.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
           

            btnUp.Enabled = false;
            btnDown.Enabled = false;

            // Gawing pwede i-edit at enabled
            txtFirstName.ReadOnly = false;
            txtFirstName.Enabled = true;

            txtLastName.ReadOnly = false;
            txtLastName.Enabled = true;

            txtEmail.ReadOnly = false;
            txtEmail.Enabled = true;

            txtPhone.ReadOnly = false;
            txtPhone.Enabled = true;

            txtWhanauAddress.ReadOnly = false;
            txtWhanauAddress.Enabled = true;




            btnSave_update.Visible = true;
            btnSave_add.Visible = false;
            btnCancel.Visible = true;

            btnAdd.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
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


            
            btnSave_add.Visible = false;
            btnCancel.Visible = false;
            btnSave_update.Visible = false;

           
            currencyManager.Refresh();
        }

        private void btnSave_add_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new row in WHANAU table
                DataRow newWhanauRow = DM.dtWhanau.NewRow();

                // Fill in the values from your textboxes
                newWhanauRow["FirstName"] = txtFirstName.Text;
                newWhanauRow["LastName"] = txtLastName.Text;
                newWhanauRow["Email"] = txtEmail.Text;
                newWhanauRow["Phone"] = txtPhone.Text;
                newWhanauRow["Address"] = txtWhanauAddress.Text;

                // Add to the DataTable
                DM.dtWhanau.Rows.Add(newWhanauRow);

                // Push changes to the database
                DM.UpdateWhanau();

                MessageBox.Show("Whanau successfully added.", "Success");

                // ✅ Reset form after successful save
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtWhanauAddress.Clear();

                // Optionally set focus back to first field
                txtFirstName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding Whanau: " + ex.Message, "Error");
            }
        }



        private void btnSave_update_Click(object sender, EventArgs e)
        {
            try
            {
                int whanauID = int.Parse(txtWhanauID.Text);
                DataRow rowToUpdate = DM.dtWhanau.Rows.Find(whanauID);

                if (rowToUpdate != null)
                {
                    // update values mula sa textboxes
                    rowToUpdate["FirstName"] = txtFirstName.Text;
                    rowToUpdate["LastName"] = txtLastName.Text;
                    rowToUpdate["Email"] = txtEmail.Text;
                    rowToUpdate["Phone"] = txtPhone.Text;
                    rowToUpdate["Address"] = txtWhanauAddress.Text;

                    // push to database
                    DM.UpdateWhanau();

                    MessageBox.Show("Whanau successfully updated.", "Success");

                    // reset form state (same as cancel)
                    lstWhanau.Visible = true;
                    lblWhanauID.Visible = true;
                    txtWhanauID.Visible = true;

                    btnUp.Enabled = true;
                    btnDown.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnReturn.Enabled = true;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;

                    btnSave_add.Visible = false;
                    btnCancel.Visible = false;
                    btnSave_update.Visible = false;

                    // refresh binding
                    currencyManager.Refresh();
                }
                else
                {
                    MessageBox.Show("Whanau ID not found.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Whanau: " + ex.Message, "Error");
            }
        }

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

    }
}
