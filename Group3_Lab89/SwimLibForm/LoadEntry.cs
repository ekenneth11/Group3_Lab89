using SwimLib;

namespace SwimLibForm
{
    public partial class LoadEntry : Form
    {
        private Meet currentMeet;
        public LoadEntry()
        {
            InitializeComponent();
            sexName.DataSource = Enum.GetValues(typeof(Sex));
        }
        public LoadEntry(Meet meet): this()
        {
            this.currentMeet = meet;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void entries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
