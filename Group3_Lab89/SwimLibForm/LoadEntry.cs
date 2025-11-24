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

        }
        public LoadEntry(Meet meet) : this()
        {
            this.currentMeet = meet;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            SwimEntry entry = new SwimEntry(null, null, TimeSpan.Zero);
            EntryForm frmEntry = new EntryForm(entry, currentMeet);
            if (frmEntry.ShowDialog() == DialogResult.OK)
            {
                entries.Add(entry);
                updateEntryListBox();
            }
        }

        private void entryLoad_Click(object sender, EventArgs e)
        {
            SwimmersRegistration.RegisterSwimmers(currentMeet);

            //i need to loop inside the events in the meet and the entries in the events
            List<SwimEvent> events = currentMeet.Events;
            foreach (SwimEvent ee in events)
            {
                foreach (SwimEntry entry in ee.SwimEntries)
                {
                    entries.Add(entry);
                }
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
