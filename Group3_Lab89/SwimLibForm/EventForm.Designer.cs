namespace SwimLibForm
{
    partial class EventForm
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
            EventBox = new GroupBox();
            cancelButton = new Button();
            addButton = new Button();
            label5 = new Label();
            ageGroupBox = new TextBox();
            label4 = new Label();
            distanceBox = new TextBox();
            genderBox = new ComboBox();
            label3 = new Label();
            strokeBox = new ComboBox();
            label2 = new Label();
            EventBox.SuspendLayout();
            SuspendLayout();
            // 
            // EventBox
            // 
            EventBox.Controls.Add(cancelButton);
            EventBox.Controls.Add(addButton);
            EventBox.Controls.Add(label5);
            EventBox.Controls.Add(ageGroupBox);
            EventBox.Controls.Add(label4);
            EventBox.Controls.Add(distanceBox);
            EventBox.Controls.Add(genderBox);
            EventBox.Controls.Add(label3);
            EventBox.Controls.Add(strokeBox);
            EventBox.Controls.Add(label2);
            EventBox.Location = new Point(12, 12);
            EventBox.Name = "EventBox";
            EventBox.Size = new Size(340, 233);
            EventBox.TabIndex = 0;
            EventBox.TabStop = false;
            EventBox.Text = "Add/Modify Event";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(178, 204);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(259, 204);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 9;
            addButton.Text = "Add Event";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 147);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Age Group: ";
            // 
            // ageGroupBox
            // 
            ageGroupBox.Location = new Point(107, 144);
            ageGroupBox.Name = "ageGroupBox";
            ageGroupBox.Size = new Size(121, 23);
            ageGroupBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 107);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Distance: ";
            // 
            // distanceBox
            // 
            distanceBox.Location = new Point(107, 107);
            distanceBox.Name = "distanceBox";
            distanceBox.Size = new Size(121, 23);
            distanceBox.TabIndex = 5;
            // 
            // genderBox
            // 
            genderBox.FormattingEnabled = true;
            genderBox.Location = new Point(107, 65);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(121, 23);
            genderBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 68);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Gender: ";
            // 
            // strokeBox
            // 
            strokeBox.FormattingEnabled = true;
            strokeBox.Location = new Point(107, 28);
            strokeBox.Name = "strokeBox";
            strokeBox.Size = new Size(121, 23);
            strokeBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 31);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Stroke: ";
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 257);
            Controls.Add(EventBox);
            Name = "EventForm";
            Text = "EventForm";
            Load += EventForm_Load;
            EventBox.ResumeLayout(false);
            EventBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EventBox;
        private Label label3;
        private ComboBox strokeBox;
        private Label label2;
        private TextBox ageGroupBox;
        private Label label4;
        private TextBox distanceBox;
        private ComboBox genderBox;
        private Label label5;
        private Button cancelButton;
        private Button addButton;
    }
}