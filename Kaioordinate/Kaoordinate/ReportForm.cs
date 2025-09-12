using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Kaoordinate
{
    public partial class ReportForm : Form
    {
        private DataModule DM;
        private MainForm mainForm;

        private PrintDocument printDoc;
        private int selectedEventID = -1; // only print this event

        public ReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mnu;

            // Setup print doc
            printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);

            this.Load += ReportForm_Load;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(6, 73, 41);

            // Bind event table to combo box
            cboEvents.DataSource = DM.dtEvent;
            cboEvents.DisplayMember = "EventName";   // what shows in dropdown
            cboEvents.ValueMember = "EventID";       // the actual ID behind it
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cboEvents.SelectedValue != null)
            {
                selectedEventID = Convert.ToInt32(cboEvents.SelectedValue);

                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = printDoc;
                preview.Width = 900;
                preview.Height = 700;
                preview.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an event first.");
            }
        }


        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (selectedEventID == -1)
            {
                e.HasMorePages = false;
                return;
            }

            // Get the chosen event row
            DataRow eventRow = DM.dtEvent.Rows.Find(selectedEventID);
            if (eventRow == null)
            {
                e.Graphics.DrawString("Event not found.", new Font("Arial", 12), Brushes.Black, 100, 100);
                return;
            }

            // Get registrations for this event
            DataRow[] registrations = DM.dtEventRegistration.Select($"EventID = {selectedEventID}");

            if (registrations.Length == 0)
            {
                e.Graphics.DrawString("No registrations for this event.", new Font("Arial", 12), Brushes.Black, 100, 100);
                return;
            }

            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 10, FontStyle.Regular);
            Font detailFont = new Font("Arial", 9, FontStyle.Regular);

            int y = 100;

            // --- Event details ---
            e.Graphics.DrawString($"Event ID: {eventRow["EventID"]}", headerFont, Brushes.Black, 100, y); y += 25;
            e.Graphics.DrawString($"Event Name: {eventRow["EventName"]}", subHeaderFont, Brushes.Black, 100, y); y += 20;
            e.Graphics.DrawString($"Date: {Convert.ToDateTime(eventRow["EventDate"]).ToShortDateString()}", subHeaderFont, Brushes.Black, 100, y); y += 20;

            // Location lookup
            DataRow locationRow = DM.dtLocation.Rows.Find(eventRow["LocationID"]);
            if (locationRow != null)
            {
                e.Graphics.DrawString($"Location: {locationRow["LocationName"]}", subHeaderFont, Brushes.Black, 100, y); y += 20;
                e.Graphics.DrawString($"Address: {locationRow["Address"]}", subHeaderFont, Brushes.Black, 100, y); y += 30;
            }

            // Attendees header
            e.Graphics.DrawString("Attendees:", headerFont, Brushes.Black, 100, y); y += 25;

            // Column titles
            e.Graphics.DrawString("First Name", subHeaderFont, Brushes.Black, 120, y);
            e.Graphics.DrawString("Last Name", subHeaderFont, Brushes.Black, 250, y);
            e.Graphics.DrawString("Phone No.", subHeaderFont, Brushes.Black, 400, y);
            e.Graphics.DrawString("Helper", subHeaderFont, Brushes.Black, 520, y);
            y += 20;

            // --- Registrations loop ---
            foreach (DataRow reg in registrations)
            {
                DataRow whanauRow = DM.dtWhanau.Rows.Find(reg["WhanauID"]);
                if (whanauRow != null)
                {
                    e.Graphics.DrawString(whanauRow["FirstName"].ToString(), detailFont, Brushes.Black, 120, y);
                    e.Graphics.DrawString(whanauRow["LastName"].ToString(), detailFont, Brushes.Black, 250, y);
                    e.Graphics.DrawString(whanauRow["Phone"].ToString(), detailFont, Brushes.Black, 400, y);
                    e.Graphics.DrawString((bool)reg["KaiPreparation"] ? "Yes" : "No", detailFont, Brushes.Black, 520, y);
                    y += 20;
                }
            }

            e.HasMorePages = false; // only one event
        }
    }
}
