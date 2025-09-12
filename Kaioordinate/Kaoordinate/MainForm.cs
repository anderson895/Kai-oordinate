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
    public partial class MainForm : Form
    {
        private DataModule DM; // reference to the form that holds the data components
        private KaiForm frmKai; // reference to the kai form
        private EventForm frmEvent; // reference to the event form
        private WhanauForm frmWhanau; // reference to the whanau form
        private LocationForm frmLocation; // reference to the location form
        private RegisterForm frmRegister; // reference to the register form
        private ReportForm frmReport; // refrence to the report form
        private PrintForm frmPrint; // reference to the print form
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(6, 73, 41);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); //create the data module and load the dataset
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (frmEvent == null)
            {
                frmEvent = new EventForm(DM, this);
            }
            frmEvent.ShowDialog();
        }

        

        private void btnKai_Click(object sender, EventArgs e)
        {
            if (frmKai == null)
            {
                frmKai = new KaiForm(DM, this);
            }
            frmKai.ShowDialog();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (frmLocation == null)
            {
                frmLocation = new LocationForm(DM, this);
            }
            frmLocation.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnWhanau_Click(object sender, EventArgs e)
        {
            if (frmWhanau == null)
            {
                frmWhanau = new WhanauForm(DM, this);
            }
            frmWhanau.ShowDialog();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (frmRegister == null)
            {
                frmRegister = new RegisterForm(DM, this);
            }
            frmRegister.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (frmReport == null)
            {
                frmReport = new ReportForm(DM, this);
            }
            frmReport.ShowDialog();
        }
    }
}
