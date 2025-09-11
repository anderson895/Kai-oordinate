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
        }

        public void BindControls()
        {
            txtEventID.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.EventName");
            txtLocation.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.LocationID");
            txtEventDate.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.EventDate");
            lstEvent.DataSource = DM.dsKaioordinate;
            lstEvent.DisplayMember = "EVENT.EventName";
            lstEvent.ValueMember = "EVENT.EventName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENT"];
        }
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
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
    }
}
