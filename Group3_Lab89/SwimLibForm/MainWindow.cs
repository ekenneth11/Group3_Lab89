using SwimLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SwimLibForm
{
    public partial class MainWindow : Form
    {
        Meet currentMeet;
        public MainWindow()
        {
            InitializeComponent();
            currentMeet = Meet.CreateMeet(0, 0);
            updateMeetDetails();
        }

        private void meetButton_Click(object sender, EventArgs e)
        {
            MeetCreationForm creationForm = new MeetCreationForm(currentMeet);
            creationForm.ShowDialog();
            updateMeetDetails();
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            LoadEntry loadE = new LoadEntry(currentMeet);
            if (loadE.ShowDialog() != DialogResult.OK)
            {
                updateMeetDetails();
            }
        }
        private void updateMeetDetails()
        {
            if (currentMeet != null)
            {
                meetDetails.Clear();
                meetDetails.Font = new Font("Courier New", 10, FontStyle.Regular);
                meetDetails.AppendText(currentMeet.ToString());
            }
        }

        private void heatSheetButton_Click(object sender, EventArgs e)
        {
            HeatSheetForm heatSheetForm = new HeatSheetForm(currentMeet);
            heatSheetForm.ShowDialog();
            updateMeetDetails();
        }
    }
}
