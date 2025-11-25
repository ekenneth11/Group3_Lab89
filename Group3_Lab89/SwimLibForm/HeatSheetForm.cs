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
    public partial class HeatSheetForm : Form
    {
        Meet currentMeet;
        public HeatSheetForm()
        {
            InitializeComponent();
        }
        public HeatSheetForm(Meet m) : this()
        {
            currentMeet = m;
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            currentMeet.SeedingService = new RandomSeedingService(currentMeet);
            seedingServiceName.Text = "Random Seeding Service";
        }

        private void timedButton_Click(object sender, EventArgs e)
        {
            currentMeet.SeedingService = new TimeFinalSeedingService(currentMeet);
            seedingServiceName.Text = "Time Final Seeding Service";
        }

        private void heatSheetButton_Click(object sender, EventArgs e)
        {
            currentMeet.GenerateHeatSheet(fileName.Text);
            FileStream fileIn = new FileStream(fileName.Text, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fileIn);
            string line = reader.ReadToEnd();
            heatSheetBox.Text = line;
            fileIn.Close();
            reader.Close();

        }
    }
}
