using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Kaoordinate
{
    public partial class DataModule : Form
    {
        public DataTable dtKai;
        public DataTable dtEvent;
        public DataTable dtWhanau;
        public DataTable dtLocation;
        public DataTable dtEventRegistration;

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

            // Ensure primary keys are set
            if (dtKai.PrimaryKey.Length == 0)
                dtKai.PrimaryKey = new DataColumn[] { dtKai.Columns["KaiID"] };
            if (dtWhanau.PrimaryKey.Length == 0)
                dtWhanau.PrimaryKey = new DataColumn[] { dtWhanau.Columns["WhanauID"] };
            if (dtLocation.PrimaryKey.Length == 0)
                dtLocation.PrimaryKey = new DataColumn[] { dtLocation.Columns["LocationID"] };
        }

        private void DataModule_Load(object sender, EventArgs e) { }

        // ================= UPDATE METHODS ===================
        public void UpdateKai()
        {
            try
            {
                // Commit any pending edits
                if (BindingContext[dtKai] is CurrencyManager cm)
                    cm.EndCurrentEdit();

                // Auto-generate INSERT/UPDATE/DELETE commands
                OleDbCommandBuilder cb = new OleDbCommandBuilder(daKai);
                daKai.Update(dtKai);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kai update failed: " + ex.Message);
            }
        }

        public void UpdateWhanau()
        {
            try
            {
                if (BindingContext[dtWhanau] is CurrencyManager cm)
                    cm.EndCurrentEdit();

                OleDbCommandBuilder cb = new OleDbCommandBuilder(daWhanau);
                daWhanau.Update(dtWhanau);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whanau update failed: " + ex.Message);
            }
        }

        public void UpdateLocation()
        {
            try
            {
                if (BindingContext[dtLocation] is CurrencyManager cm)
                    cm.EndCurrentEdit();

                OleDbCommandBuilder cb = new OleDbCommandBuilder(daLocation);
                daLocation.Update(dtLocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Location update failed: " + ex.Message);
            }
        }


        // ================= UPDATE EVENT ===================
        public void UpdateEvent()
        {
            try
            {
                // Commit pending edits
                if (BindingContext[dtEvent] is CurrencyManager cm)
                    cm.EndCurrentEdit();

                // Auto-generate INSERT/UPDATE/DELETE commands
                OleDbCommandBuilder cb = new OleDbCommandBuilder(daEvent);
                daEvent.Update(dtEvent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Event update failed: " + ex.Message);
            }
        }



        public void UpdateEventRegistration()
        {
            try
            {
                if (BindingContext[dtEventRegistration] is CurrencyManager cm)
                    cm.EndCurrentEdit();

                OleDbCommandBuilder cb = new OleDbCommandBuilder(daEventRegistration);
                daEventRegistration.Update(dtEventRegistration);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EventRegistration update failed: " + ex.Message);
            }
        }


    }
}
