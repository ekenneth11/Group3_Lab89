namespace SwimLibForm
{
    partial class MeetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cancelButton = new Button();
            addMeetButton = new Button();
            poolLanes = new TextBox();
            poolLength = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cancelButton);
            groupBox1.Controls.Add(addMeetButton);
            groupBox1.Controls.Add(poolLanes);
            groupBox1.Controls.Add(poolLength);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "MeetCreation";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(154, 151);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(79, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addMeetButton
            // 
            addMeetButton.Location = new Point(239, 151);
            addMeetButton.Name = "addMeetButton";
            addMeetButton.Size = new Size(79, 23);
            addMeetButton.TabIndex = 4;
            addMeetButton.Text = "Create Meet";
            addMeetButton.UseVisualStyleBackColor = true;
            addMeetButton.Click += addMeetButton_Click;
            // 
            // poolLanes
            // 
            poolLanes.Location = new Point(121, 71);
            poolLanes.Name = "poolLanes";
            poolLanes.Size = new Size(100, 23);
            poolLanes.TabIndex = 3;
            // 
            // poolLength
            // 
            poolLength.Location = new Point(121, 34);
            poolLength.Name = "poolLength";
            poolLength.Size = new Size(100, 23);
            poolLength.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 74);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Pool Lanes: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Pool Length: ";
            // 
            // MeetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 204);
            Controls.Add(groupBox1);
            Name = "MeetForm";
            Text = "MeetForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button addMeetButton;
        private TextBox poolLanes;
        private TextBox poolLength;
        private Label label2;
        private Label label1;
        private Button cancelButton;
    }
}