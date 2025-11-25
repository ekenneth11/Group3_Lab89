using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using SwimLib;
namespace SwimLibForm
{
    public partial class EventForm : Form
    {
        Meet currentMeet;
        SwimEvent currentEvent;
        public EventForm()
        {
            InitializeComponent();
        }
        public EventForm(Meet meet, SwimEvent ev) : this()
        {
            currentMeet = meet;
            currentEvent = ev;
            strokeBox.DataSource = Enum.GetValues(typeof(Stroke));
            genderBox.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Stroke stroke, int distance, Gender gender, byte age
                Stroke stk = (Stroke)strokeBox.SelectedItem;
                int distance = Convert.ToInt32(distanceBox.Text);
                Gender gender = (Gender)genderBox.SelectedItem;
                byte age = Convert.ToByte(ageGroupBox.Text);
                currentEvent.Stroke = stk;
                currentEvent.Gender = gender;
                currentEvent.Distance = distance;
                currentEvent.AgeGroup = age;

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format is not correct");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            if (currentEvent.Distance != 0)
            {
                strokeBox.SelectedItem = currentEvent.Stroke;
                genderBox.SelectedItem = currentEvent.Gender;
                distanceBox.Text = Convert.ToString(currentEvent.Distance);
                ageGroupBox.Text = Convert.ToString(currentEvent.AgeGroup);
            }
        }
    }
}
