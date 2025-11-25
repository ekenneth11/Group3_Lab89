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
    public partial class MeetForm : Form
    {
        Meet currentMeet;
        public MeetForm()
        {
            InitializeComponent();
        }
        public MeetForm(Meet meet) : this()
        {
            currentMeet = meet;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addMeetButton_Click(object sender, EventArgs e)
        {
            //the created a new meet
            try
            {
                int nLength = Convert.ToInt32(poolLength.Text);
                byte nlane = Convert.ToByte(poolLanes.Text);
                if (nLength != currentMeet.PoolLength || nlane != currentMeet.PoolLanes)
                {
                    currentMeet.Events.Clear();
                    currentMeet.PoolLength = nLength;
                    currentMeet.PoolLanes = nlane;
                }
                DialogResult = DialogResult.OK;
                this.Close();
                //if the user put the same length and lane, it is not creating a new meet, isnt it.
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
    }
}
