using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SwimLib;
namespace SwimLibForm
{
    public partial class MeetCreationForm : Form
    {
        Meet currentMeet;
        SwimEvent ev;
        public MeetCreationForm()
        {
            InitializeComponent();
        }
        public MeetCreationForm(Meet m) : this()
        {
            currentMeet = m;
            updateEventBox();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            MeetForm mm = new MeetForm(currentMeet);
            mm.ShowDialog();
            updateEventBox();
        }
        private void updateEventBox()
        {
            eventList.Items.Clear();
            foreach (SwimEvent e in currentMeet.Events)
            {
                eventList.Items.Add(e);
                modifyButton.Visible = false;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Stroke stroke, int distance, Gender gender, byte age
            SwimEvent nEvent = new SwimEvent(Stroke.Freestyle, 0, Gender.Male ,0);
            EventForm eventForm = new EventForm(currentMeet, nEvent);
            if (eventForm.ShowDialog() == DialogResult.OK) 
            {
                currentMeet.Events.Add(nEvent);
            }
            updateEventBox();
        }

        private void eventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventList.SelectedIndex != -1)
            {
                ev = (SwimEvent)eventList.SelectedItem;
                modifyButton.Visible = true;
            }

        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(currentMeet, ev);
            eventForm.ShowDialog();
            updateEventBox();
        }

        private void MeetCreationForm_Load(object sender, EventArgs e)
        {

        }

        private void loadEventButton_Click(object sender, EventArgs e)
        {
            SwimMeetPlanningService swimMeetPlaningService = new SwimMeetPlanningService(currentMeet.PoolLength, currentMeet.PoolLanes);
            updateEventBox();
        }
    }
}
