using SwimLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SwimLibForm
{
    public partial class EntryForm : Form
    {
        SwimEntry entryE;
        Meet currentMeet;
        SwimEvent currentEvent;
        public EntryForm(SwimEntry entry, Meet meet)
        {
            InitializeComponent();
            sexName.DataSource = Enum.GetValues(typeof(Sex));
            strokeBox.DataSource = Enum.GetValues(typeof(Stroke));
            entryE = entry;
            currentMeet = meet;
        }

        private void addEntry_Click(object sender, EventArgs e)
        {
            try
            {
          
                int id = Convert.ToInt32(IdName.Text);
                DateTime bday = birthdayName.Value;
                Sex ss = (Sex)sexName.SelectedItem;
                string club = clubName.Text;
                Swimmer s = new Swimmer(id, bday, club, ss);
                byte age = s.Age;
                byte ageGroup;
                if (age <= 10)
                {
                    ageGroup = 10;
                }
                else if (age <= 12)
                {
                    ageGroup = 11;
                }
                else if (age <= 14)
                {
                    ageGroup = 13;
                }
                else
                {
                    ageGroup = 15;
                }
                Stroke stk = (Stroke)strokeBox.SelectedItem;
                int distance = Convert.ToInt32(distanceName.Text);

                TimeSpan seed = TimeSpan.ParseExact(seedName.Text, @"mm\:ss\.ff", null);
                currentEvent = currentMeet.GetEvent(stk, distance, ss, ageGroup);
                entryE.Swimmer = s;
                entryE.Event = currentEvent;
                entryE.SeedTime = seed;

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format is not correct");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void EntryForm_Load(object sender, EventArgs e)
        {
            if(entryE.Swimmer != null)
            {
                IdName.Text = entryE.Swimmer.Id.ToString();
                sexName.SelectedItem = entryE.Swimmer.Sex;
                entryName.Text = entryE.Swimmer.Name.ToString();
                clubName.Text = entryE.Swimmer.Club.ToString();
                seedName.Text = entryE.SeedTime.ToString(@"mm:\:ss\.ff");
                birthdayName.Value = entryE.Swimmer.BDay;
                distanceName.Text = entryE.Event.Distance.ToString();
                strokeBox.SelectedItem = entryE.Event.Stroke;
            }
        }
    }
}
