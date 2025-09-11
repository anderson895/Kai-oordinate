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
        public void BindControls()
        {
            txtKaiID.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.KaiID");
            txtEvent.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.EventID");
            txtKaiName.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.KaiName");
            txtPreparation.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.PreparationRequired");
            txtPreparationTime.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.PreparationMinutes");
            txtServingQuantity.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.ServeQuantity");
            lstKai.DataSource = DM.dsKaioordinate;
            lstKai.DisplayMember = "KAI.Kainame";
            lstKai.ValueMember = "KAI.Kainame";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "KAI"];
        }
        public KaiForm()
        {
            InitializeComponent();
        
        }

        private void lblPreperationTime_Click(object sender, EventArgs e)
        {

        }

        private void txtEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void KaiForm_Load(object sender, EventArgs e)
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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
