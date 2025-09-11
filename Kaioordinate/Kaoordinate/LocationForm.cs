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

        public void BindControls()
        {
            txtLocationID.DataBindings.Add("Text", DM.dsKaioordinate, "LOCATION.LocationID");
            txtLocationName.DataBindings.Add("Text", DM.dsKaioordinate, "LOCATION.LocationName");
            txtLocationAddress.DataBindings.Add("Text", DM.dsKaioordinate, "LOCATION.Address");
            lstLocation.DataSource = DM.dsKaioordinate;
            lstLocation.DisplayMember = "LOCATION.LocationName";
            lstLocation.ValueMember = "LOCATION.LocationName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "LOCATION"];
        }
        public LocationForm()
        {
            InitializeComponent();
        }

        private void LocationForm_Load(object sender, EventArgs e)
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
            lstLocation.Visible = false;
            lblWhanauID.Visible = false;
            txtLocationID.Visible = false;

            btnUp.Enabled = false;
            btnDown.Enabled = false;

            txtLocationName.Text = "";
            txtLocationAddress.Text = "";

            //editable at enabled
            txtLocationName.ReadOnly = false;
            txtLocationName.Enabled = true;

            txtLocationAddress.ReadOnly = false;
            txtLocationAddress.Enabled = true;

            

            //buttons
            btnSave_add.Visible = true;
            btnSave_update.Visible = false;
            btnCancel.Visible = true;

            btnUpdate.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstLocation.Visible = true;
            lblWhanauID.Visible = true;
            txtLocationID.Visible = true;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;

            // Gawing pwede i-edit at enabled
            txtLocationName.ReadOnly = false;
            txtLocationName.Enabled = true;

            txtLocationAddress.ReadOnly = false;
            txtLocationAddress.Enabled = true;

         

            btnSave_update.Visible = true;
            btnSave_add.Visible = false;
            btnCancel.Visible = true;

            btnAdd.Enabled = false;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_add_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_update_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
