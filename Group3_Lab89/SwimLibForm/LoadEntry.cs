using SwimLib;

namespace SwimLibForm
{
    public partial class LoadEntry : Form
    {
        private Meet currentMeet;
        List<SwimEntry> entries;
        SwimEntry entry;
        public LoadEntry()
        {
            InitializeComponent();
            updateEntryListBox();

        }
        public LoadEntry(Meet meet) : this()
        {
            this.currentMeet = meet;
            entries = new List<SwimEntry>();
        }

        private void entries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Entries.SelectedIndex != -1)
            {
                entry = (SwimEntry)Entries.SelectedItem;
                modify_entry.Visible = true;
                remove_entry.Visible = true;
            }
        }

        private void addEntry_Click(object sender, EventArgs e)
        {
            SwimEntry entry = new SwimEntry(new Swimmer(0,DateTime.Today, "", Sex.Male), new SwimEvent(), TimeSpan.Zero);
            EntryForm frmEntry = new EntryForm(entry, currentMeet);
            if (frmEntry.ShowDialog() == DialogResult.OK)
            {
                entries.Add(entry);
                updateEntryListBox();
            }
        }

        private void entryLoad_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    SwimmersRegistration.RegisterSwimmers(currentMeet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

                //i need to loop inside the events in the meet and the entries in the events
                List<SwimEvent> events = currentMeet.Events;
                foreach (SwimEvent ee in events)
                {
                    foreach (SwimEntry entry in ee.SwimEntries)
                    {
                        entries.Add(entry);
                    }
                }
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format is not correct");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updateEntryListBox();

        }
        private void updateEntryListBox()
        {
            Entries.Items.Clear();
            foreach (SwimEntry entry in entries)
            {
                Entries.Items.Add(entry);
            }
        }

        private void modify_entry_Click(object sender, EventArgs e)
        {
            EntryForm frmEntry = new EntryForm(entry, currentMeet);
            if(frmEntry.ShowDialog() == DialogResult.OK)
            {
                updateEntryListBox();
                modify_entry.Visible = false;
                remove_entry.Visible = false;
            }
        }

        private void remove_entry_Click(object sender, EventArgs e)
        {
            foreach(SwimEvent ee in currentMeet.Events)
            {
                ee.SwimEntries.RemoveAll(x => x.Swimmer.Id == entry.Swimmer.Id);
            }
            updateEntryListBox();
            modify_entry.Visible = false;
            remove_entry.Visible = false;

        }
    }
}
