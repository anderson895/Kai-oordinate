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

            // Ensure primary keys are set
            if (dtKai.PrimaryKey.Length == 0)
                dtKai.PrimaryKey = new DataColumn[] { dtKai.Columns["KaiID"] };
            if (dtWhanau.PrimaryKey.Length == 0)
                dtWhanau.PrimaryKey = new DataColumn[] { dtWhanau.Columns["WhanauID"] };
            if (dtLocation.PrimaryKey.Length == 0)
                dtLocation.PrimaryKey = new DataColumn[] { dtLocation.Columns["LocationID"] };

            // ✅ Setup cascade delete rules
            SetupCascadeRelations();

            dsKaioordinate.EnforceConstraints = true;
        }

        private void DataModule_Load(object sender, EventArgs e) { }

        // ================= RELATIONS WITH CASCADE ===================
        private void SetupCascadeRelations()
        {
            // Event → Location
            ForeignKeyConstraint fkEventLocation = new ForeignKeyConstraint(
                "FK_Event_Location",
                dtLocation.Columns["LocationID"],
                dtEvent.Columns["LocationID"]
            );
            fkEventLocation.DeleteRule = Rule.Cascade;
            fkEventLocation.UpdateRule = Rule.Cascade;
            dtEvent.Constraints.Add(fkEventLocation);

            // EventRegistration → Event
            ForeignKeyConstraint fkEventRegEvent = new ForeignKeyConstraint(
                "FK_EventReg_Event",
                dtEvent.Columns["EventID"],
                dtEventRegistration.Columns["EventID"]
            );
            fkEventRegEvent.DeleteRule = Rule.Cascade;
            fkEventRegEvent.UpdateRule = Rule.Cascade;
            dtEventRegistration.Constraints.Add(fkEventRegEvent);

            // EventRegistration → Whanau
            ForeignKeyConstraint fkEventRegWhanau = new ForeignKeyConstraint(
                "FK_EventReg_Whanau",
                dtWhanau.Columns["WhanauID"],
                dtEventRegistration.Columns["WhanauID"]
            );
            fkEventRegWhanau.DeleteRule = Rule.Cascade;
            fkEventRegWhanau.UpdateRule = Rule.Cascade;
            dtEventRegistration.Constraints.Add(fkEventRegWhanau);

            // ✅ Kai → Event
            if (dtKai.Columns.Contains("EventID"))
            {
                ForeignKeyConstraint fkKaiEvent = new ForeignKeyConstraint(
                    "FK_Kai_Event",
                    dtEvent.Columns["EventID"],
                    dtKai.Columns["EventID"]
                );
                fkKaiEvent.DeleteRule = Rule.Cascade;
                fkKaiEvent.UpdateRule = Rule.Cascade;
                dtKai.Constraints.Add(fkKaiEvent);
            }
        }


        // ================= UPDATE METHODS ===================
        public void UpdateKai()
        {
            try
            {
                if (BindingContext[dtKai] is CurrencyManager cm)
                    cm.EndCurrentEdit();

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

                //Commit muna yung EventRegistration kasi naka-cascade
                UpdateEventRegistration();

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

                // Commit muna yung Event at EventRegistration bago Location
                UpdateEventRegistration();
                UpdateEvent();

                OleDbCommandBuilder cb = new OleDbCommandBuilder(daLocation);
                daLocation.Update(dtLocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Location update failed: " + ex.Message);
            }
        }

        public void UpdateEvent()
        {
            try
            {
                if (BindingContext[dtEvent] is CurrencyManager cm)
                    cm.EndCurrentEdit();

                // Unahin muna yung mga child bago i-update ang parent
                UpdateEventRegistration();
                UpdateKai();

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
