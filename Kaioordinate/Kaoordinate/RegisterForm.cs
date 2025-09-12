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
    public partial class RegisterForm : Form
    {

        private DataModule DM;
        private MainForm mainForm;
        private CurrencyManager currencyManager;

        public RegisterForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mnu;
            BindControls();
        }


        public void BindControls()
        {
            // Whanau Grid
            var whanauView = new DataView(DM.dtWhanau);
            dgvWhanau.DataSource = whanauView.ToTable(false, "WhanauID", "FirstName", "LastName", "Email", "Phone", "Address");

            // Event Grid
            var eventView = new DataView(DM.dtEvent);
            dgvEvents.DataSource = eventView.ToTable(false, "EventID", "EventName", "LocationID", "EventDate");

            // Event Registration Grid (all data initially)
            dgvEventRegistered.DataSource = DM.dtEventRegistration;

            currencyManager = (CurrencyManager)this.BindingContext[DM.dtEventRegistration];
        }

        private void dgvEvents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEvents.CurrentRow != null)
            {
                int selectedEventID = Convert.ToInt32(dgvEvents.CurrentRow.Cells["EventID"].Value);

                DataView regView = new DataView(DM.dtEventRegistration);
                regView.RowFilter = $"EventID = {selectedEventID}";

                dgvEventRegistered.DataSource = regView.ToTable(false, "RegistrationID", "WhanauID", "EventID", "KaiPreparation");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvWhanau.CurrentRow == null || dgvEvents.CurrentRow == null)
            {
                MessageBox.Show("Please select both a Whānau and an Event.");
                return;
            }

            int whanauID = Convert.ToInt32(dgvWhanau.CurrentRow.Cells["WhanauID"].Value);
            int eventID = Convert.ToInt32(dgvEvents.CurrentRow.Cells["EventID"].Value);
            bool KaiPreparation = cbKaiPrep.Checked;

            // Check if already registered
            DataRow[] existing = DM.dtEventRegistration.Select($"WhanauID = {whanauID} AND EventID = {eventID}");
            if (existing.Length > 0)
            {
                MessageBox.Show("Whānau can only be registered to an event once.");
                return;
            }

            // Add new row
            DataRow newRow = DM.dtEventRegistration.NewRow();
            newRow["WhanauID"] = whanauID;
            newRow["EventID"] = eventID;
            newRow["KaiPreparation"] = KaiPreparation;
            DM.dtEventRegistration.Rows.Add(newRow);

            DM.UpdateEventRegistration();

            MessageBox.Show("Entry added successfully");

            if (BindingContext[DM.dtEventRegistration] is CurrencyManager cm)
                cm.EndCurrentEdit();
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvEventRegistered.CurrentRow == null)
            {
                MessageBox.Show("Please select a registration to remove.");
                return;
            }

            int registrationID = Convert.ToInt32(dgvEventRegistered.CurrentRow.Cells["RegistrationID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to remove this entry?",
                                                  "Confirm Removal",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataRow row = DM.dtEventRegistration.Rows.Find(registrationID);
                if (row != null)
                {
                    row.Delete();
                    DM.UpdateEventRegistration();
                    MessageBox.Show("Entry removed successfully");
                }
            }
        }






        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(6, 73, 41);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
