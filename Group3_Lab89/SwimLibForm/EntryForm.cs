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
            entryE = entry;
            currentMeet = meet;
            sexName.DataSource = Enum.GetValues(typeof(Sex));
            swimEventBox.DataSource = null;
            swimEventBox.DataSource = currentMeet.Events;
        }

        private void addEntry_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(IdName.Text);
                DateTime bday = birthdayName.Value;
                Sex ss = (Sex)sexName.SelectedItem;
                string club = clubName.Text;
                string name = entryName.Text;
                Swimmer s = new Swimmer(id, bday, club, ss) { Name = name };
                currentEvent = (SwimEvent)swimEventBox.SelectedItem;

                TimeSpan seed = TimeSpan.ParseExact(seedName.Text, @"mm\:ss\:ff", null);
                entryE.Swimmer = s;
                entryE.Event = currentEvent;
                entryE.SeedTime = seed;
                currentEvent.AddSwimEntry(entryE);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format is not correct" + seedName.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void EntryForm_Load(object sender, EventArgs e)
        {
            if (entryE.Swimmer.Id != 0)
            {
                IdName.Text = entryE.Swimmer.Id.ToString();
                sexName.SelectedItem = entryE.Swimmer.Sex;
                entryName.Text = entryE.Swimmer.Name.ToString();
                clubName.Text = entryE.Swimmer.Club.ToString();
                seedName.Text = entryE.SeedTime.ToString(@"mm\:ss\:ff");
                birthdayName.Value = entryE.Swimmer.BDay;
                swimEventBox.SelectedItem = entryE.Event;
            }
        }

        private void IdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void entryName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
