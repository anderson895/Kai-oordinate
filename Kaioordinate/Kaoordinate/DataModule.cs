using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kaoordinate
{
    public partial class DataModule : Form
    {
        public DataTable dtKai;
        public DataTable dtEvent;
        public DataTable dtWhanau;
        public DataTable dtLocation;
        public DataTable dtEventRegistration;
        public DataView KaiView;
        public DataView EventView;
        public DataView WhanauView;
        public DataTable LocationView;
        public DataView EventRegistrationView;
        public DataModule()
        {
            InitializeComponent();
            dsKaioordinate.EnforceConstraints = false;
            daKai.Fill(dsKaioordinate);
            daEvent.Fill(dsKaioordinate);
            daWhanau.Fill(dsKaioordinate);
            daLocation.Fill(dsKaioordinate);
            daEventRegistration.Fill(dsKaioordinate);
            dtKai = dsKaioordinate.Tables["KAI"];
            dtEvent = dsKaioordinate.Tables["EVENT"];
            dtWhanau = dsKaioordinate.Tables["WHANAU"];
            dtLocation = dsKaioordinate.Tables["LOCATION"];
            dtEventRegistration = dsKaioordinate.Tables["EVENTREGISTER"];
            dsKaioordinate.EnforceConstraints = true;
        }
         public void UpdateKAI()
        {
            daKai.Update(dtKai);
        }
        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        public void UpdateWhanau()
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(daWhanau);
            daWhanau.Update(dtWhanau);
        }
    }
}
